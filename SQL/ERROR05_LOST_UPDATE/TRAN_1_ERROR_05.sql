USE CHUYEN_HANG_ONLINE;

BEGIN TRANSACTION
	DECLARE @ma_cn CHAR(8), @ma_sp CHAR(8), @chenh_lech INT;
	SET @ma_cn = 'CN000000';
	SET @ma_sp = 'SP000000';
	SET @chenh_lech = 5;

	--Lấy số lượng sản phảm hiện tại
	DECLARE @so_luong_hien_tai INT;
	SET @so_luong_hien_tai = (SELECT TOP 1 SO_LUONG_CNSP FROM CHI_NHANH_SP WHERE MA_SP = @ma_sp AND MA_CN = @ma_cn);
	--Tính số lượng mới
	SET @so_luong_hien_tai = @so_luong_hien_tai + @chenh_lech;

	WAITFOR DELAY '00:00:10';

	--Cập nhật lại số lượng
	UPDATE CHI_NHANH_SP
	SET SO_LUONG_CNSP = @so_luong_hien_tai
	WHERE MA_CN = @ma_cn AND MA_SP = @ma_sp;
COMMIT TRANSACTION

SELECT *
FROM CHI_NHANH_SP
WHERE MA_CN = 'CN000000';