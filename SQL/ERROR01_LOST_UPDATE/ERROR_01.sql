--DELETE all tai khoan, doi tac, chi nhanh, hop dong
DELETE FROM TAI_KHOAN;

INSERT dbo.TAI_KHOAN(TEN_TK, MAT_KHAU, TRANG_THAI_KHOA, TRANG_THAI_KICH_HOAT) VALUES ('ZVCGD8497Q', 'KJEHM4254G', 0, 0);

INSERT dbo.DOI_TAC(MA_DT, TEN_TK, TEN_DT, NGUOI_DAI_DIEN, THANH_PHO_DT, QUAN_DT, DIA_CHI_KINH_DOANH_DT, LOAI_HANG_DT, SO_DT_DT, EMAIL_DT) 
VALUES ('DT000000', 'ZVCGD8497Q', N'Smart Solar Power Co', N'Helias Landsberg', N'Horsham', N'Northern Territ', N'3-8 Perren Street', N'Health', '161-4624', 'Ligon@example.com');

INSERT dbo.CHI_NHANH(MA_CN, MA_DT, MA_HD, TEN_CN, DIA_CHI_CN, SO_DT_CN) 
VALUES ('CN000000', 'DT000000', NULL, N'J6', N'1 Churchill Place', '949-4981'),
		('CN000001', 'DT000000', NULL, N'N8G8H7', N'24-16 Magdalen Road', '710-8523');