BEGIN TRANSACTION
	DECLARE @ma_dt CHAR(8);

	SET @ma_dt = 'DT000000';
	
	SELECT COUNT(dh.MA_DH) AS N'Tổng hóa đơn', SUM(dh.PHI_SP) AS N'Tổng thu nhập'
	FROM DON_HANG dh
		JOIN CHI_NHANH cn ON dh.MA_CN = cn.MA_CN
	WHERE cn.MA_DT = @ma_dt;

	WAITFOR DELAY '00:00:10';

	SELECT dhsp.MA_SP AS N'Mã sản phẩm bán chạy nhất'
	FROM DON_HANG_SP dhsp
		JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
		JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
		JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
	WHERE cn.MA_DT = @ma_dt
	GROUP BY dhsp.MA_SP
	HAVING SUM(dhsp.SO_LUONG_SP_DH) >= ALL (SELECT SUM(dhsp.SO_LUONG_SP_DH)
											FROM DON_HANG_SP dhsp
												JOIN DON_HANG dh ON dhsp.MA_DH = dh.MA_DH
												JOIN CHI_NHANH_SP cnsp ON cnsp.MA_CN = dh.MA_CN
												JOIN CHI_NHANH cn ON cn.MA_CN = cnsp.MA_CN
											WHERE cn.MA_DT = @ma_dt
											GROUP BY dhsp.MA_SP);
	RETURN;
COMMIT