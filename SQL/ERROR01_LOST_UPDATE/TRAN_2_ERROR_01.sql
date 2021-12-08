USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @chi_nhanh CHI_NHANH, @ma_hd CHAR(8), @ma_dt CHAR(8), @ma_thue VARCHAR(15), @nguoi_dai_dien NVARCHAR(30);
	--Dùng chi nhánh CN000000 ở transaction 1 làm cho nó bị mất chi nhánh
	INSERT INTO @chi_nhanh (MA_CN)
		VALUES ('CN000000');
	SET @ma_dt = 'DT000000';
	SET @ma_hd = 'HD000001';
	SET @ma_thue = '30072308491664';
	SET @nguoi_dai_dien = 'Anh Khoa';

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

	--Update khóa ngoại các chi nhánh vào hợp đồng
	UPDATE CHI_NHANH
	SET MA_HD = @ma_hd
	WHERE MA_CN IN (SELECT cn.MA_CN FROM @chi_nhanh cn);
COMMIT