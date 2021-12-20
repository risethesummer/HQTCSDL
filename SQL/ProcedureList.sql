USE CHUYEN_HANG_ONLINE;
GO

--Procedure dùng để đăng nhập
CREATE PROCEDURE dang_nhap @tai_khoan VARCHAR(20), @mat_khau VARCHAR(50)
AS
BEGIN TRANSACTION
	DECLARE @loai_tk CHAR(2);
	SET @loai_tk = NULL;
	--Lấy ra loại tài khoản
	SET @loai_tk = (SELECT TOP 1 tk.LOAI_TK
					FROM TAI_KHOAN tk
					WHERE tk.TEN_TK = @tai_khoan AND tk.MAT_KHAU = @mat_khau AND tk.TRANG_THAI_KHOA = 0)
	IF @loai_tk IS NOT NULL
		BEGIN
			--Trả về mã (đối tác/khách hàng/tài xế) tương ứng với loại tài khoản đó
			IF @loai_tk = 'DT'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', dt.MA_DT AS 'ma' FROM DOI_TAC dt WHERE dt.TEN_TK = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'KH'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', kh.MA_KH AS 'ma' FROM KHACH_HANG kh WHERE kh.TEN_TK = @tai_khoan;
					COMMIT TRAN;
					RETURN;
				END
			ELSE IF @loai_tk = 'TX'
				BEGIN
					SELECT @loai_tk AS 'loai_tk', tx.MA_TX AS 'ma' FROM TAI_XE tx WHERE tx.TEN_TK = @tai_khoan;
					COMMIT TRAN;
					RETURN
				END
		END
COMMIT TRANSACTION
GO

--Procedure gia hạn hợp đồng
CREATE PROCEDURE gia_han_hop_dong_ERROR @ma_hd INT, @so_ngay_them INT, @delay DATETIME
AS
BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE;
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NGAY_KT_HD FROM HOP_DONG WHERE MA_HD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
			
		WAITFOR DELAY @delay;

		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));
		--Update lại ngày cuối của hợp đồng
		UPDATE HOP_DONG
		SET NGAY_KT_HD = @ngay_hien_tai
		WHERE MA_HD = @ma_hd;
	END
	COMMIT TRANSACTION;
GO

--Procedure gia hạn hợp đồng
CREATE PROCEDURE gia_han_hop_dong @ma_hd INT, @so_ngay_them INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE;
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NGAY_KT_HD 
							FROM HOP_DONG WITH (UPDLOCK) 
							WHERE MA_HD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
			
		WAITFOR DELAY @delay;

		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));
		--Update lại ngày cuối của hợp đồng
		UPDATE HOP_DONG
		SET NGAY_KT_HD = @ngay_hien_tai
		WHERE MA_HD = @ma_hd;
	END
	COMMIT TRANSACTION;
GO

--Procedure cập nhật sản phẩm
CREATE PROCEDURE cap_nhat_san_pham @ma_sp INT, @ten_sp NVARCHAR(20), @mo_ta NVARCHAR(30), @gia INT, @delay DATETIME
AS
BEGIN TRANSACTION
	--Nếu tên sản phẩm, mô tả không trống, giá không bị âm -> cập nhật giá trị mới
	--Nếu không thì giữ những giá trị cũ lại
	IF (@ten_sp = '')
		BEGIN
			SET @ten_sp = (SELECT TEN_SP FROM SAN_PHAM WHERE MA_SP = @ma_sp);
		END
	IF (@mo_ta = '')
		BEGIN
			SET @mo_ta = (SELECT MO_TA_SP FROM SAN_PHAM WHERE MA_SP = @ma_sp);
		END
	IF (@gia < 0)
		BEGIN
			SET @gia = (SELECT GIA_SP FROM SAN_PHAM WHERE MA_SP = @ma_sp);
		END
	UPDATE SAN_PHAM
	SET TEN_SP = @ten_sp,
		MO_TA_SP = @mo_ta,
		GIA_SP = @gia
	WHERE MA_SP = @ma_sp
COMMIT TRANSACTION
GO

--Procedure tài xế tiếp nhận đơn hàng
CREATE PROCEDURE tiep_nhan_dh_ERROR @ma_tx INT, @ma_dh INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	--Nếu đơn hàng đã có tài xế khác tiếp nhận
	IF NOT EXISTS (SELECT * 
				FROM DON_HANG
				WHERE MA_DH = @ma_dh AND MA_TX IS NULL 
						AND TINH_TRANG_DH = N'Đang xử lý')
	BEGIN	
		PRINT N'Nhận đơn hàng thất bại'
		ROLLBACK TRANSACTION;
		RETURN;
	END

	--Delay để gây ra lỗi
	WAITFOR DELAY @delay;

	UPDATE DON_HANG
	SET MA_TX = @ma_tx, TINH_TRANG_DH = N'Đang giao'
	WHERE MA_DH = @ma_dh;

	PRINT N'Nhận đơn hàng thành công'
COMMIT TRANSACTION
GO

--Procedure tài xế tiếp nhận đơn hàng
CREATE PROCEDURE tiep_nhan_dh @ma_tx INT, @ma_dh INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	--Nếu đơn hàng đã có tài xế khác tiếp nhận
	IF NOT EXISTS (SELECT *
				FROM DON_HANG WITH (UPDLOCK)
				WHERE MA_DH = @ma_dh AND MA_TX IS NULL 
						AND TINH_TRANG_DH = N'Đang xử lý')
	BEGIN	
		PRINT N'Nhận đơn hàng thất bại'
		ROLLBACK TRANSACTION;
		RETURN;
	END

	--Delay để gây ra lỗi
	WAITFOR DELAY @delay;

	UPDATE DON_HANG
	SET MA_TX = @ma_tx, TINH_TRANG_DH = N'Đang giao'
	WHERE MA_DH = @ma_dh;

	PRINT N'Nhận đơn hàng thành công'
COMMIT TRANSACTION
GO

--Procedure tăng, giảm số lượng sản phẩm đang có
CREATE PROCEDURE cap_nhat_so_luong_cnsp_ERROR @ma_sp INT, @ma_cn INT, 
												@chenh_lech INT, 
												@delay DATETIME
AS
BEGIN TRANSACTION
	BEGIN TRY
		--Lấy số lượng sản phảm hiện tại
		DECLARE @so_luong_hien_tai INT;
		SET @so_luong_hien_tai = (SELECT TOP 1 SO_LUONG_CNSP 
								FROM CHI_NHANH_SP 
								WHERE MA_SP = @ma_sp AND MA_CN = @ma_cn);

		WAITFOR DELAY @delay;

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
		RETURN;
	END CATCH
COMMIT TRANSACTION
GO

--Procedure tăng, giảm số lượng sản phẩm đang có
CREATE PROCEDURE cap_nhat_so_luong_cnsp @ma_sp INT, @ma_cn INT, 
												@chenh_lech INT, 
												@delay DATETIME
AS
BEGIN TRANSACTION
	BEGIN TRY
		--Lấy số lượng sản phảm hiện tại
		DECLARE @so_luong_hien_tai INT;
		SET @so_luong_hien_tai = (SELECT TOP 1 SO_LUONG_CNSP 
								FROM CHI_NHANH_SP WITH (UPDLOCK)
								WHERE MA_SP = @ma_sp AND MA_CN = @ma_cn);

		WAITFOR DELAY @delay;

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
		RETURN;
	END CATCH
COMMIT TRANSACTION
GO

CREATE TYPE SAN_PHAM_SO_LUONG AS TABLE
(
	MA_SP CHAR(8),
	SO_LUONG INT
);
GO

--Procedure tạo đơn hàng
CREATE PROCEDURE tao_don_dat_hang_ERROR @ma_cn INT, @ma_kh INT, @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @delay DATETIME, 
									@san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		DECLARE @phi_sp INT, @ma_dh INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SAN_PHAM sp JOIN @san_pham_so_luong spsl
								ON sp.MA_SP = spsl.MA_SP)

		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_CN, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, PHI_SP, PHI_VC)
		VALUES (@ma_cn, NULL, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

		WAITFOR DELAY @delay;

		--Lấy mã đơn hàng vừa tạo
		SET @ma_dh = (SELECT TOP 1 MA_DH FROM DON_HANG ORDER BY MA_DH DESC);


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
		RETURN;
	END CATCH
COMMIT TRANSACTION
GO

--Procedure tạo đơn hàng
CREATE PROCEDURE tao_don_dat_hang @ma_cn INT, @ma_kh INT, @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @delay DATETIME, 
									@san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

		DECLARE @phi_sp INT, @ma_dh INT;
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SAN_PHAM sp JOIN @san_pham_so_luong spsl
								ON sp.MA_SP = spsl.MA_SP)

		--Đọc để đặt khóa shared lock
		SELECT * FROM DON_HANG;

		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_CN, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, PHI_SP, PHI_VC)
		VALUES (@ma_cn, NULL, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

		WAITFOR DELAY @delay;

		--Lấy mã đơn hàng vừa tạo
		SET @ma_dh = (SELECT TOP 1 MA_DH FROM DON_HANG ORDER BY MA_DH DESC);


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
		RETURN;
	END CATCH
COMMIT TRANSACTION
GO

--Procedure cho khách hàng hủy đơn đặt hàng
CREATE PROC huy_don_dat_hang_ERROR @ma_dh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	BEGIN TRY
	--Chỉ có thể hủy khi đơn hàng đang trong trạng thái Đang xử lý
	IF EXISTS (SELECT * 
				FROM DON_HANG
				WHERE MA_DH = @ma_dh AND TINH_TRANG_DH = N'Đang xử lý')
		BEGIN

			WAITFOR DELAY @delay;

			UPDATE DON_HANG
			SET TINH_TRANG_DH = N'Đã hủy'
			WHERE MA_DH = @ma_dh;

			--Cộng lại sản phẩm trong chi nhánh sản phẩm
			UPDATE CHI_NHANH_SP
			SET SO_LUONG_CNSP = SO_LUONG_CNSP + (SELECT TOP 1 dhsp.SO_LUONG_SP_DH
												FROM DON_HANG_SP dhsp
												WHERE dhsp.MA_SP = MA_SP 
													AND dhsp.MA_DH = MA_DH)
			WHERE MA_CN = (SELECT TOP 1 dh.MA_CN 
							FROM DON_HANG dh
							WHERE dh.MA_DH = @ma_dh)
				AND MA_SP IN (SELECT dhsp.MA_SP 
								FROM DON_HANG_SP dhsp
								WHERE dhsp.MA_DH = @ma_dh);

			PRINT N'Hủy đơn hàng thành công';
			COMMIT TRANSACTION;
			RETURN;
		END
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END TRY
	BEGIN CATCH
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
GO

--Procedure cho khách hàng hủy đơn đặt hàng
CREATE PROC huy_don_dat_hang @ma_dh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	BEGIN TRY
	--Chỉ có thể hủy khi đơn hàng đang trong trạng thái Đang xử lý
	IF EXISTS (SELECT * 
				FROM DON_HANG WITH (UPDLOCK)
				WHERE MA_DH = @ma_dh AND TINH_TRANG_DH = N'Đang xử lý')
		BEGIN

			WAITFOR DELAY @delay;

			UPDATE DON_HANG
			SET TINH_TRANG_DH = N'Đã hủy'
			WHERE MA_DH = @ma_dh;

			--Cộng lại sản phẩm trong chi nhánh sản phẩm
			UPDATE CHI_NHANH_SP
			SET SO_LUONG_CNSP = SO_LUONG_CNSP + (SELECT TOP 1 dhsp.SO_LUONG_SP_DH
												FROM DON_HANG_SP dhsp
												WHERE dhsp.MA_SP = MA_SP 
													AND dhsp.MA_DH = MA_DH)
			WHERE MA_CN = (SELECT TOP 1 dh.MA_CN 
							FROM DON_HANG dh
							WHERE dh.MA_DH = @ma_dh)
				AND MA_SP IN (SELECT dhsp.MA_SP 
								FROM DON_HANG_SP dhsp
								WHERE dhsp.MA_DH = @ma_dh);

			PRINT N'Hủy đơn hàng thành công';
			COMMIT TRANSACTION;
			RETURN;
		END
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END TRY
	BEGIN CATCH
		PRINT N'Hủy đơn hàng thất bại';
		ROLLBACK TRANSACTION;
		RETURN;
	END CATCH
GO

--Store procedure để đối tác thống kê đơn hàng
CREATE PROC doi_tac_thong_ke_ERROR @ma_dt INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION

	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	SELECT 'total', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
					SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt;

	SELECT 'shipping', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
						SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
						SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
					SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt AND dh.TINH_TRANG_DH = N'Thành công';

	SELECT 'product', sp.MA_SP, sp.TEN_SP, 
			SUM(dhsp.SO_LUONG_SP_DH) AS N'Số lượng đã bán'
	FROM DON_HANG_SP dhsp
		JOIN SAN_PHAM sp ON dhsp.MA_SP = sp.MA_SP
		JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
		JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
		JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
	WHERE cn.MA_DT = @ma_dt
	GROUP BY sp.MA_SP, sp.TEN_SP
	HAVING SUM(dhsp.SO_LUONG_SP_DH) >= ALL (SELECT SUM(dhsp.SO_LUONG_SP_DH)
											FROM DON_HANG_SP dhsp
												JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
												JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
												JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
											WHERE cn.MA_DT = @ma_dt
											GROUP BY dhsp.MA_SP);
COMMIT TRANSACTION;
GO

--Store procedure để đối tác thống kê đơn hàng
CREATE PROC doi_tac_thong_ke @ma_dt INT, 
									@delay DATETIME
AS
BEGIN TRANSACTION
	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE

	SELECT 'total', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
					SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt;

	SELECT 'shipping', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
						SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
						SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) AS N'Tổng hóa đơn', 
					SUM(dh.PHI_SP) AS N'Tổng giá sản phẩm hóa đơn', 
					SUM(dh.PHI_VC) AS N'Tổng phí vận chuyển'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt AND dh.TINH_TRANG_DH = N'Thành công';

	SELECT 'product', sp.MA_SP, sp.TEN_SP, 
			SUM(dhsp.SO_LUONG_SP_DH) AS N'Số lượng đã bán'
	FROM DON_HANG_SP dhsp
		JOIN SAN_PHAM sp ON dhsp.MA_SP = sp.MA_SP
		JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
		JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
		JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
	WHERE cn.MA_DT = @ma_dt
	GROUP BY sp.MA_SP, sp.TEN_SP
	HAVING SUM(dhsp.SO_LUONG_SP_DH) >= ALL (SELECT SUM(dhsp.SO_LUONG_SP_DH)
											FROM DON_HANG_SP dhsp
												JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
												JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
												JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
											WHERE cn.MA_DT = @ma_dt
											GROUP BY dhsp.MA_SP);
COMMIT TRANSACTION;
GO


--Store procedure để khách hàng thống kê đơn hàng
CREATE PROC khach_hang_thong_ke_ERROR @ma_kh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	SELECT 'total', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh;

	SELECT 'shipping', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) , SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh AND dh.TINH_TRANG_DH = N'Thành công';
COMMIT TRANSACTION;
GO


--Store procedure để khách hàng thống kê đơn hàng
CREATE PROC khach_hang_thong_ke @ma_kh INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;

	SELECT 'total', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh;

	SELECT 'shipping', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) , SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_KH = @ma_kh AND dh.TINH_TRANG_DH = N'Thành công';
COMMIT TRANSACTION;
GO

--Store procedure để tài xế thống kê đơn hàng
CREATE PROC tai_xe_thong_ke_ERROR @ma_tx INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	SELECT 'total', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx;

	SELECT 'shipping', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) , SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx AND dh.TINH_TRANG_DH = N'Thành công';
COMMIT TRANSACTION;
GO

--Store procedure để tài xế thống kê đơn hàng
CREATE PROC tai_xe_thong_ke @ma_tx INT, @delay DATETIME
AS
BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;

	SELECT 'total', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx;

	SELECT 'shipping', COUNT(dh.MA_DH), SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx AND dh.TINH_TRANG_DH = N'Đang giao';

	WAITFOR DELAY @delay;

	SELECT 'done', COUNT(dh.MA_DH) , SUM(dh.PHI_SP), SUM(dh.PHI_VC)
	FROM DON_HANG dh
	WHERE dh.MA_TX = @ma_tx AND dh.TINH_TRANG_DH = N'Thành công';
COMMIT TRANSACTION;
GO