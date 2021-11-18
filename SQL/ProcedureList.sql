USE CHUYEN_HANG_ONLINE;
GO

CREATE TYPE CHI_NHANH AS TABLE
(
	MA_CN CHAR(8)
);
GO

--Procedure lập hợp đồng
CREATE PROCEDURE lap_hop_dong @ma_hd CHAR(8), @ma_dt CHAR(8), @ma_thue VARCHAR(15), @nguoi_dai_dien NVARCHAR(30),
							@chi_nhanh CHI_NHANH READONLY
AS
BEGIN TRANSACTION
	
	--KIểm tra chi nhánh đã có hợp đồng chưa
	IF EXISTS (SELECT *
				FROM CHI_NHANH
				WHERE MA_CN IN (SELECT cn.MA_CN FROM @chi_nhanh cn) 
					AND MA_HD IS NOT NULL)
	BEGIN	
		ROLLBACK TRANSACTION;
	END;

	--Thêm vào bảng hợp đồng
	INSERT INTO HOP_DONG (MA_HD, MA_DT, MA_THUE_DT, NGUOI_DAI_DIEN_HD)
	VALUES (@ma_hd, @ma_dt, @ma_thue, @nguoi_dai_dien);


	--Update khóa ngoại các chi nhánh vào hợp đồng
	UPDATE CHI_NHANH
	SET MA_HD = @ma_hd
	WHERE MA_CN IN (SELECT cn.MA_CN FROM @chi_nhanh cn);
COMMIT TRANSACTION
GO

--Procedure tài xế tiếp nhận đơn hàng
CREATE PROCEDURE tiep_nhan_dh @ma_tx CHAR(8), @ma_dh CHAR(8)
AS
BEGIN TRANSACTION
	--Nếu đơn hàng đã có tài xế khác tiếp nhận
	IF EXISTS (SELECT * 
				FROM DON_HANG 
				WHERE MA_DH = @ma_dh AND MA_TX IS NOT NULL)
	BEGIN	
		ROLLBACK TRANSACTION;
	END

	UPDATE DON_HANG
	SET MA_TX = @ma_tx
	WHERE MA_DH = @ma_dh;
COMMIT TRANSACTION
GO

--Procedure gia hạn hợp đồng
CREATE PROCEDURE gia_han_hop_dong @ma_hd CHAR(8), @so_ngay_them INT
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

--Procedure tăng, giảm số lượng sản phẩm đang có
CREATE PROCEDURE cap_nhat_so_luong_cnsp @ma_sp CHAR(8), @ma_cn CHAR(8), @chenh_lech INT
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

CREATE TYPE SAN_PHAM_SO_LUONG AS TABLE
(
	MA_SP CHAR(8),
	SO_LUONG INT
);
GO

--Procedure tạo đơn hàng
CREATE PROCEDURE tao_don_dat_hang @ma_dh CHAR(8), @ma_dt CHAR(8), @ma_kh CHAR(8), @ma_tx CHAR(8), @hinh_thuc_tt NVARCHAR(30),
									@dia_chi_gh NVARCHAR(30), @tinh_trang_dh NVARCHAR(15), @phi_vc INT, @san_pham_so_luong SAN_PHAM_SO_LUONG READONLY
AS
BEGIN TRANSACTION

	BEGIN TRY
		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_DH, MA_DT, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, TINH_TRANG_DH, PHI_VC)
		VALUES (@ma_dh, @ma_dt, @ma_tx, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @tinh_trang_dh, @phi_vc);

		--Tạo chi tiết đơn hàng
		INSERT INTO DON_HANG_SP(MA_DH, MA_SP, SO_LUONG_SP_DH, GIA_SP_DH)
		SELECT @ma_dh, spsl.MA_SP, spsl.SO_LUONG, SP.GIA_SP
		FROM @san_pham_so_luong spsl JOIN SAN_PHAM SP
			ON SP.MA_SP = spsl.MA_SP;
		
		--Update phí sản phẩm của đơn hàng
		UPDATE DON_HANG
		SET PHI_SP = (SELECT SUM(SO_LUONG_SP_DH * GIA_SP_DH)
						FROM DON_HANG_SP
						WHERE MA_DH = @ma_dh)
		WHERE MA_DH = @ma_dh;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
	END CATCH
COMMIT TRANSACTION