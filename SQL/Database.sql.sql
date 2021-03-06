--Tạo database
CREATE DATABASE CHUYEN_HANG_ONLINE
GO
USE CHUYEN_HANG_ONLINE
GO

--Tạo bảng tài khoản
CREATE TABLE TAI_KHOAN
(
	TEN_TK VARCHAR(20) PRIMARY KEY,
	MAT_KHAU VARCHAR(50) NOT NULL,
	NGAY_DK DATE DEFAULT GETDATE(),
	LOAI_TK CHAR(2),
	TRANG_THAI_KHOA BIT DEFAULT 0,
)
GO

--Tạo bảng đối tác
CREATE TABLE DOI_TAC
(
	MA_DT INT PRIMARY KEY IDENTITY(1, 1),
	TEN_TK VARCHAR(20) UNIQUE NOT NULL,
	TEN_DT NVARCHAR(20) NOT NULL,
	NGUOI_DAI_DIEN NVARCHAR(30) NOT NULL,
	THANH_PHO_DT NVARCHAR(15) NOT NULL,
	QUAN_DT NVARCHAR(15) NOT NULL,
	DIA_CHI_KINH_DOANH_DT NVARCHAR(30) UNIQUE NOT NULL,
	SO_CHI_NHANH_DT INT DEFAULT 0,
	LOAI_HANG_DT NVARCHAR(20),
	SO_DT_DT VARCHAR(10) UNIQUE NOT NULL,
	EMAIL_DT VARCHAR(30) UNIQUE NOT NULL,
	--Khóa ngoại tới tài khoản của đối tác
	CONSTRAINT FK_DT_TK FOREIGN KEY(TEN_TK) REFERENCES TAI_KHOAN(TEN_TK) ON DELETE CASCADE
)
GO

--Tạo bảng hợp đồng
CREATE TABLE HOP_DONG
(
	MA_HD INT PRIMARY KEY IDENTITY(1, 1),
	MA_DT INT NOT NULL,
	SO_CN INT NOT NULL,
	MA_THUE_DT VARCHAR(15) NOT NULL,
	NGUOI_DAI_DIEN_HD NVARCHAR(30) NOT NULL,
	NGAY_BD_HD DATE DEFAULT GETDATE(),
	NGAY_KT_HD DATE DEFAULT GETDATE(),
	XAC_NHAN_HD BIT DEFAULT 0,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_HD_DT FOREIGN KEY(MA_DT) REFERENCES DOI_TAC(MA_DT) ON DELETE CASCADE
)
GO

--Tạo bảng chi nhánh
CREATE TABLE CHI_NHANH
(
	MA_CN INT PRIMARY KEY IDENTITY(1, 1),
	MA_DT INT NOT NULL, 
	MA_HD INT,
	TEN_CN NVARCHAR(20) NOT NULL,
	DIA_CHI_CN NVARCHAR(30) UNIQUE NOT NULL,
	SO_DT_CN VARCHAR(10) UNIQUE NOT NULL,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_CN_DT FOREIGN KEY(MA_DT) REFERENCES DOI_TAC(MA_DT) ON DELETE CASCADE,
	--Khóa ngoại tới hợp đồng
	CONSTRAINT FK_CN_HD FOREIGN KEY(MA_HD) REFERENCES HOP_DONG(MA_HD)
)
GO

--Tạo bảng sản phẩm
CREATE TABLE SAN_PHAM
(
	MA_SP INT PRIMARY KEY IDENTITY(1, 1),
	MA_DT INT NOT NULL,
	TEN_SP NVARCHAR(20) NOT NULL,
	MO_TA_SP NVARCHAR(30) DEFAULT '',
	GIA_SP INT NOT NULL CONSTRAINT CHK_SP_GIA_SP CHECK (GIA_SP >= 0),
	CONSTRAINT FK_SP_DT FOREIGN KEY (MA_DT) REFERENCES DOI_TAC(MA_DT) ON DELETE CASCADE
)
GO

--Tạo bảng chi nhánh sản phẩm
CREATE TABLE CHI_NHANH_SP
(
	MA_SP INT NOT NULL,
	MA_CN INT NOT NULL,
	SO_LUONG_CNSP INT NOT NULL DEFAULT 0 CONSTRAINT CHK_CHI_NHANH_SP_SO_LUONG CHECK (SO_LUONG_CNSP >= 0),
	PRIMARY KEY (MA_SP, MA_CN),
	--Khóa ngoại tới sản phẩm
	CONSTRAINT FK_CNSP_SP FOREIGN KEY (MA_SP) REFERENCES SAN_PHAM(MA_SP) ON DELETE CASCADE,
	--Khóa ngoại tới chi nhánh chứa sản phẩm
	CONSTRAINT FK_CNSP_CN FOREIGN KEY (MA_CN) REFERENCES CHI_NHANH(MA_CN)
)
GO

--Tạo bảng khách hàng
CREATE TABLE KHACH_HANG
(
	MA_KH INT PRIMARY KEY IDENTITY(1, 1),
	TEN_TK VARCHAR(20) UNIQUE NOT NULL,
	HO_TEN_KH NVARCHAR(30) NOT NULL,
	DIA_CHI_KH NVARCHAR(30),
	SO_DT_KH VARCHAR(10) UNIQUE NOT NULL,
	EMAIL_KH VARCHAR(30) UNIQUE NOT NULL,
	--Khóa ngoại tới tài khoản khách hàng
	CONSTRAINT FK_KH_TK FOREIGN KEY (TEN_TK) REFERENCES TAI_KHOAN(TEN_TK) ON DELETE CASCADE
)
GO

--Tạo bảng tài xế
CREATE TABLE TAI_XE
(
	MA_TX INT PRIMARY KEY IDENTITY(1, 1),
	TEN_TK VARCHAR(20) UNIQUE NOT NULL,
	HO_TEN_TX NVARCHAR(30) NOT NULL,
	CMND_TX  CHAR(10) UNIQUE NOT NULL,
	SO_DT_TX VARCHAR(10) NOT NULL,
	BIEN_SO_TX CHAR(15) NOT NULL,
	KHU_VUC_HD_TX NVARCHAR(20) NOT NULL,
	EMAIL_TX VARCHAR(30) NOT NULL,
	TAI_KHOAN_NH VARCHAR(20) NOT NULL,
	--Khóa ngoại tới tài khoản tài xế
	CONSTRAINT FK_TX_TK FOREIGN KEY (TEN_TK) REFERENCES TAI_KHOAN(TEN_TK) ON DELETE CASCADE
)
GO

--Tạo bảng đơn hàng
CREATE TABLE DON_HANG
(
	MA_DH INT PRIMARY KEY IDENTITY(1, 1),
	MA_CN INT NOT NULL,
	MA_KH INT NOT NULL,
	MA_TX INT,
	HINH_THUC_TT NVARCHAR(30) NOT NULL,
	DIA_CHI_GH	NVARCHAR(30) NOT NULL,
	TINH_TRANG_DH NVARCHAR(15) NOT NULL DEFAULT N'Đang xử lý',
	PHI_SP INT NOT NULL CONSTRAINT CHK_DH_PHI_SP CHECK (PHI_SP >= 0),
	PHI_VC INT NOT NULL CONSTRAINT CHK_DH_PHI_VC CHECK (PHI_VC >= 0),
	--Khóa ngoại tới chi nhánh
	CONSTRAINT FK_DH_CN FOREIGN KEY(MA_CN) REFERENCES CHI_NHANH(MA_CN),
	--Khóa ngoại tới khách hàng
	CONSTRAINT FK_DH_KH FOREIGN KEY(MA_KH) REFERENCES KHACH_HANG(MA_KH) ON DELETE CASCADE,
	--Khóa ngoại tới tài xế
	CONSTRAINT FK_DH_TX FOREIGN KEY(MA_TX) REFERENCES TAI_XE(MA_TX)
)
GO


--Tạo bảng đơn hàng sản phẩm
CREATE TABLE DON_HANG_SP
(
	MA_DH INT NOT NULL,
	MA_SP INT NOT NULL,
	SO_LUONG_SP_DH INT NOT NULL CONSTRAINT CHK_DHSP_SL CHECK (SO_LUONG_SP_DH > 0),
	GIA_SP_DH INT NOT NULL CONSTRAINT CHK_DHSP_GIA CHECK (GIA_SP_DH >= 0),
	PRIMARY KEY(MA_DH, MA_SP),
	CONSTRAINT FK_DHSP_DH FOREIGN KEY(MA_DH) REFERENCES DON_HANG(MA_DH) ON DELETE CASCADE,
	CONSTRAINT FK_DHSP_SP FOREIGN KEY(MA_SP) REFERENCES SAN_PHAM(MA_SP)
)
GO

CREATE INDEX ID_DOI_TAC_TK ON DOI_TAC(TEN_TK);
CREATE INDEX ID_CHI_NHANH_DT ON CHI_NHANH(MA_DT);
CREATE INDEX ID_HOP_DONG_DT ON HOP_DONG(MA_DT);
CREATE INDEX ID_SAN_PHAM_MA_DT ON SAN_PHAM(MA_DT);
CREATE INDEX ID_CHI_NHANH_SP ON CHI_NHANH_SP(MA_CN);
CREATE INDEX ID_KHACH_HANG_TK ON KHACH_HANG(TEN_TK);
CREATE INDEX ID_TAI_XE_TK ON TAI_XE(TEN_TK);
CREATE INDEX ID_DON_HANG_CN ON DON_HANG(MA_CN);
CREATE INDEX ID_DON_HANG_KH ON DON_HANG(MA_KH);
CREATE INDEX ID_DON_HANG_TX ON DON_HANG(MA_TX);
CREATE INDEX ID_DHSP_DH ON DON_HANG_SP(MA_DH);