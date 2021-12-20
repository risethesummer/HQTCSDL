USE CHUYEN_HANG_ONLINE;

--Đơn hàng gồm 100 sản phẩm 2
DECLARE @spsl SAN_PHAM_SO_LUONG;
INSERT INTO @spsl
VALUES (2, 100);
--Tạo đơn hàng với 100 sản phẩm 2 (delay 0s)
EXEC tao_don_dat_hang_ERROR 2, 1, N'Vận chuyển nhanh', 'TPHCM', 30000, '00:00:00', @spsl