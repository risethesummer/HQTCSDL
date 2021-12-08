USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @chi_nhanh CHI_NHANH, @ma_hd CHAR(8), @ma_dt CHAR(8), @ma_thue VARCHAR(15), @nguoi_dai_dien NVARCHAR(30);
	INSERT INTO @chi_nhanh (MA_CN)
		VALUES ('CN000000'), ('CN000001');
	SET @ma_dt = 'DT000000';
	SET @ma_hd = 'HD000000';
	SET @ma_thue = '340797177600137';
	SET @nguoi_dai_dien = 'Ho Linh';

	--KIểm tra chi nhánh đã có hợp đồng chưa
	IF EXISTS (SELECT *
				FROM CHI_NHANH
				WHERE MA_CN IN (SELECT cn.MA_CN FROM @chi_nhanh cn) 
						AND MA_HD IS NOT NULL)
		BEGIN
			ROLLBACK TRANSACTION;
		END
	
	--Thêm vào bảng hợp đồng
	INSERT INTO HOP_DONG (MA_HD, MA_DT, MA_THUE_DT, NGUOI_DAI_DIEN_HD, SO_CN)
	SELECT @ma_hd, @ma_dt, @ma_thue, @nguoi_dai_dien, COUNT(DISTINCT MA_CN) FROM @chi_nhanh;

	--Đợi để tạo ta tình huống lỗi
	WAITFOR DELAY '00:00:10';

	--Update khóa ngoại các chi nhánh vào hợp đồng
	UPDATE CHI_NHANH
	SET MA_HD = @ma_hd
	WHERE MA_CN IN (SELECT cn.MA_CN FROM @chi_nhanh cn);
COMMIT
GO

--Lấy số chi nhánh trong hợp đồng
SELECT hd.SO_CN AS N'Thuộc tính số chi nhánh trong hợp đồng HD000000'
FROM HOP_DONG hd 
WHERE hd.MA_HD = 'HD000000';

--Lấy số chi nhánh thật sự có khóa ngoại đến hợp đồng
SELECT COUNT(*) AS N'Đếm số chi nhánh từ bảng chi nhánh HD000000'
FROM CHI_NHANH cn
WHERE cn.MA_HD = 'HD000000';

--Lấy số chi nhánh trong hợp đồng
SELECT hd.SO_CN AS N'Thuộc tính số chi nhánh trong hợp đồng HD000001'
FROM HOP_DONG hd 
WHERE hd.MA_HD = 'HD000001';

--Lấy số chi nhánh thật sự có khóa ngoại đến hợp đồng
SELECT COUNT(*) AS N'Đếm số chi nhánh từ bảng chi nhánh HD000001'
FROM CHI_NHANH cn
WHERE cn.MA_HD = 'HD000001';