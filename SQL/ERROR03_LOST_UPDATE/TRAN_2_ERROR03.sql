USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @ma_dh CHAR(8);
	SET @ma_dh = 'DH000000';
	--Chỉ có thể hủy khi đơn hàng chưa được tiếp nhận bởi tài xế
	IF EXISTS (SELECT * 
				FROM DON_HANG
				WHERE MA_DH = @ma_dh AND TINH_TRANG_DH = N'Đang xử lý')
		BEGIN
			--Cập nhật tình trạng hủy của đơn hàng
			UPDATE DON_HANG
			SET TINH_TRANG_DH = N'Đã hủy'
			WHERE MA_DH = @ma_dh;

			PRINT N'Hủy đơn hàng thành công'
		END
	ELSE
		BEGIN
			PRINT N'Hủy đơn hàng thất bại'
		END
COMMIT