USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @ma_dh CHAR(8), @ma_tx CHAR(8);

	SET @ma_dh = 'DH000000';
	SET @ma_tx = 'TX000001';

	--Nếu đơn hàng đã có tài xế khác tiếp nhận
	IF EXISTS (SELECT * 
				FROM DON_HANG 
				WHERE MA_DH = @ma_dh AND MA_TX IS NOT NULL AND TINH_TRANG_DH = N'Đang xử lý')
	BEGIN	
		PRINT N'Nhận đơn hàng thất bại';
		RETURN;
	END

	UPDATE DON_HANG
	SET MA_TX = @ma_tx, TINH_TRANG_DH = N'Đang giao'
	WHERE MA_DH = @ma_dh;

	PRINT N'Nhận đơn hàng thành công';

COMMIT TRANSACTION