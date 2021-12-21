--Set đơn hàng 8 về tình trạng chưa xử lý
USE CHUYEN_HANG_ONLINE;
UPDATE DON_HANG
SET TINH_TRANG_DH = N'Đang xử lý', MA_TX = NULL
WHERE MA_DH = 25;