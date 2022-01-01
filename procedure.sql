USE CHUYEN_HANG_ONLINE
GO
CREATE PROCEDURE store_error4 @ma_hd CHAR(8), @so_ngay_them INT
AS
BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE;
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NGAY_KT_HD FROM HOP_DONG WHERE MA_HD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));
		--Update lại ngày cuối của hợp đồng
		UPDATE HOP_DONG
		SET NGAY_KT_HD = @ngay_hien_tai
		WHERE MA_HD = @ma_hd;
	END
COMMIT TRANSACTION
GO
CREATE PROCEDURE store_fix4 @ma_hd CHAR(8), @so_ngay_them INT
AS
BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE;
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NGAY_KT_HD FROM HOP_DONG with (updlock) WHERE MA_HD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));
		--Update lại ngày cuối của hợp đồng
		UPDATE HOP_DONG
		SET NGAY_KT_HD = @ngay_hien_tai
		WHERE MA_HD = @ma_hd;
	END
COMMIT TRANSACTION
GO
CREATE PROCEDURE store_error5_2 @ma_dh CHAR(8), @ma_cn CHAR(8), @ma_kh CHAR(8), @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		DECLARE @phi_sp INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SAN_PHAM sp JOIN @san_pham_so_luong spsl
								ON sp.MA_SP = spsl.MA_SP)

		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_DH, MA_CN, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, PHI_SP, PHI_VC)
		VALUES (@ma_dh, @ma_cn, NULL, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

		--Kiểm tra chi nhánh đủ số lượng sản phẩm hay không
		IF EXISTS (SELECT * 
					FROM CHI_NHANH_SP cnsp JOIN @san_pham_so_luong spsl ON cnsp.MA_SP = spsl.MA_SP
					WHERE cnsp.MA_CN = @ma_cn AND (cnsp.SO_LUONG_CNSP - spsl.SO_LUONG < 0))
			BEGIN
				ROLLBACK TRANSACTION;
			END

		--Tạo chi tiết đơn hàng
		INSERT INTO DON_HANG_SP(MA_DH, MA_SP, SO_LUONG_SP_DH, GIA_SP_DH)
		SELECT @ma_dh, spsl.MA_SP, spsl.SO_LUONG, SP.GIA_SP
		FROM @san_pham_so_luong spsl JOIN SAN_PHAM SP
			ON SP.MA_SP = spsl.MA_SP;


		--Trừ sản phẩm trong chi nhánh sản phẩm
		UPDATE CHI_NHANH_SP
		SET SO_LUONG_CNSP = SO_LUONG_CNSP - (SELECT TOP 1 spsl.SO_LUONG 
												FROM @san_pham_so_luong spsl 
												WHERE spsl.MA_SP = MA_SP)
		WHERE MA_CN = @ma_cn AND MA_SP IN (SELECT MA_SP FROM @san_pham_so_luong)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION
GO
CREATE PROCEDURE store_error5_1 @ma_sp CHAR(8), @ma_cn CHAR(8), @chenh_lech INT
AS
BEGIN TRANSACTION
	BEGIN TRY
		--Lấy số lượng sản phảm hiện tại
		DECLARE @so_luong_hien_tai INT;
		SET @so_luong_hien_tai = (SELECT TOP 1 SO_LUONG_CNSP FROM CHI_NHANH_SP WHERE MA_SP = @ma_sp AND MA_CN = @ma_cn);
		--Thêm vào bảng chi nhánh sản phẩm nếu chưa tồn tại
		IF @so_luong_hien_tai IS NULL
			BEGIN
				INSERT INTO CHI_NHANH_SP(MA_CN, MA_SP, SO_LUONG_CNSP)
				VALUES (@ma_sp, @ma_cn, @chenh_lech);
			END
		--Cập nhật lại số lượng nếu đã tồn tại
		ELSE
			BEGIN
				--Tính số lượng mới
				SET @so_luong_hien_tai = @so_luong_hien_tai + @chenh_lech;
				--Cập nhật lại số lượng
				UPDATE CHI_NHANH_SP
				SET SO_LUONG_CNSP = @so_luong_hien_tai
				WHERE MA_CN = @ma_cn AND MA_SP = @ma_sp;
			END
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION
GO
CREATE PROCEDURE store_fix5_1 @ma_sp CHAR(8), @ma_cn CHAR(8), @chenh_lech INT
AS
BEGIN TRANSACTION
	BEGIN TRY
		--Lấy số lượng sản phảm hiện tại
		DECLARE @so_luong_hien_tai INT;
		SET @so_luong_hien_tai = (SELECT TOP 1 SO_LUONG_CNSP FROM CHI_NHANH_SP with (updlock) WHERE MA_SP = @ma_sp AND MA_CN = @ma_cn);
		--Thêm vào bảng chi nhánh sản phẩm nếu chưa tồn tại
		IF @so_luong_hien_tai IS NULL
			BEGIN
				INSERT INTO CHI_NHANH_SP(MA_CN, MA_SP, SO_LUONG_CNSP)
				VALUES (@ma_sp, @ma_cn, @chenh_lech);
			END
		--Cập nhật lại số lượng nếu đã tồn tại
		ELSE
			BEGIN
				--Tính số lượng mới
				SET @so_luong_hien_tai = @so_luong_hien_tai + @chenh_lech;
				--Cập nhật lại số lượng
				UPDATE CHI_NHANH_SP
				SET SO_LUONG_CNSP = @so_luong_hien_tai
				WHERE MA_CN = @ma_cn AND MA_SP = @ma_sp;
			END
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION
GO
CREATE PROCEDURE store_fix5_2 @ma_dh CHAR(8), @ma_cn CHAR(8), @ma_kh CHAR(8), @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		DECLARE @phi_sp INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SAN_PHAM sp JOIN @san_pham_so_luong spsl
								ON sp.MA_SP = spsl.MA_SP)

		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_DH, MA_CN, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, PHI_SP, PHI_VC)
		VALUES (@ma_dh, @ma_cn, NULL, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

		--Kiểm tra chi nhánh đủ số lượng sản phẩm hay không
		IF EXISTS (SELECT * 
					FROM CHI_NHANH_SP cnsp with (updlock) JOIN @san_pham_so_luong spsl ON cnsp.MA_SP = spsl.MA_SP
					WHERE cnsp.MA_CN = @ma_cn AND (cnsp.SO_LUONG_CNSP - spsl.SO_LUONG < 0))
			BEGIN
				ROLLBACK TRANSACTION;
			END

		--Tạo chi tiết đơn hàng
		INSERT INTO DON_HANG_SP(MA_DH, MA_SP, SO_LUONG_SP_DH, GIA_SP_DH)
		SELECT @ma_dh, spsl.MA_SP, spsl.SO_LUONG, SP.GIA_SP
		FROM @san_pham_so_luong spsl JOIN SAN_PHAM SP
			ON SP.MA_SP = spsl.MA_SP;


		--Trừ sản phẩm trong chi nhánh sản phẩm
		UPDATE CHI_NHANH_SP
		SET SO_LUONG_CNSP = SO_LUONG_CNSP - (SELECT TOP 1 spsl.SO_LUONG 
												FROM @san_pham_so_luong spsl 
												WHERE spsl.MA_SP = MA_SP)
		WHERE MA_CN = @ma_cn AND MA_SP IN (SELECT MA_SP FROM @san_pham_so_luong)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION
GO