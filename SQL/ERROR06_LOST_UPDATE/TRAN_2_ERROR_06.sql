USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @ma_dh CHAR(8);
	SET @ma_dh = 'DH000000';
	--Chỉ có thể hủy khi đơn hàng chưa được tiếp nhận bởi tài xế
	IF EXISTS (SELECT * 
				FROM DON_HANG
				WHERE MA_DH = @ma_dh AND TINH_TRANG_DH = N'Đang xử lý')
		BEGIN
			UPDATE DON_HANG
			SET TINH_TRANG_DH = N'Đã hủy'
			WHERE MA_DH = @ma_dh;

			--Cộng lại sản phẩm trong chi nhánh sản phẩm
			UPDATE CHI_NHANH_SP
			SET SO_LUONG_CNSP = SO_LUONG_CNSP + (SELECT TOP 1 dhsp.SO_LUONG_SP_DH
												FROM DON_HANG_SP dhsp
												WHERE dhsp.MA_SP = MA_SP AND dhsp.MA_DH = MA_DH)
			WHERE MA_CN = (SELECT TOP 1 dh.MA_CN 
							FROM DON_HANG dh
							WHERE dh.MA_DH = @ma_dh)
				AND MA_SP IN (SELECT dhsp.MA_SP 
								FROM DON_HANG_SP dhsp
								WHERE dhsp.MA_DH = @ma_dh);
		END
COMMIT

SELECT *
FROM CHI_NHANH_SP
WHERE MA_CN = 'CN000000';