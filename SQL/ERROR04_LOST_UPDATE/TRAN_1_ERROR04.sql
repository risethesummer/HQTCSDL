USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @ngay_hien_tai DATE, @ma_hd CHAR(8), @so_ngay_them INT;
	SET @so_ngay_them = 100;
	SET @ma_hd = 'HD000000';
	--Chọn ngày cuối hợp đồng
	SET @ngay_hien_tai = (SELECT TOP 1 NGAY_KT_HD FROM HOP_DONG WHERE MA_HD = @ma_hd);
	IF @ngay_hien_tai IS NOT NULL
	BEGIN
		--Tăng ngày cuối hợp đồng
		SET @ngay_hien_tai = (SELECT DATEADD(DAY, @so_ngay_them, @ngay_hien_tai));

		WAITFOR DELAY '00:00:10';

		--Update lại ngày cuối của hợp đồng
		UPDATE HOP_DONG
		SET NGAY_KT_HD = @ngay_hien_tai
		WHERE MA_HD = @ma_hd;
	END
COMMIT TRANSACTION

SELECT NGAY_KT_HD
FROM HOP_DONG
WHERE MA_HD ='HD000000';