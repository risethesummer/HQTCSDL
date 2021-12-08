USE CHUYEN_HANG_ONLINE;
BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @ma_dh CHAR(8), @ma_cn CHAR(8), @ma_kh CHAR(8), @ma_tx CHAR(8), @hinh_thuc_tt NVARCHAR(30),
				@dia_chi_gh NVARCHAR(30),  @phi_vc INT, @phi_sp INT, @san_pham_so_luong SAN_PHAM_SO_LUONG;
		INSERT INTO @san_pham_so_luong
		VALUES ('SP000000', 10);
		--Tính tổng giá sản phẩm của đơn hàng
		SET @phi_sp = (SELECT SUM(spsl.SO_LUONG * sp.GIA_SP)
						FROM SAN_PHAM sp JOIN @san_pham_so_luong spsl
								ON sp.MA_SP = spsl.MA_SP)
		SET @ma_dh = 'DH000000';
		SET @ma_cn = 'CN000000';
		SET @ma_kh = 'KH000000';
		SET @ma_tx = NULL;
		SET @hinh_thuc_tt = N'Tiền mặt';
		SET @dia_chi_gh = 'Bogenstraße 1, 99134, Seitenro';
		SET @phi_vc = 100000;
		--Tạo đơn hàng
		INSERT INTO DON_HANG(MA_DH, MA_CN, MA_TX, MA_KH, HINH_THUC_TT, DIA_CHI_GH, PHI_SP, PHI_VC)
		VALUES (@ma_dh, @ma_cn, @ma_tx, @ma_kh, @hinh_thuc_tt, @dia_chi_gh, @phi_sp, @phi_vc);

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

SELECT *
FROM CHI_NHANH_SP
WHERE MA_CN = 'CN000000';