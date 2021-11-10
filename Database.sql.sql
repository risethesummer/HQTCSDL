﻿--Tạo database
CREATE DATABASE CHUYEN_HANG_ONLINE
GO
USE CHUYEN_HANG_ONLINE

--Tạo bảng tài khoản
GO
CREATE TABLE TAI_KHOAN
(
	TEN_TK VARCHAR(20) PRIMARY KEY,
	MAT_KHAU VARCHAR(50) NOT NULL,
	NGAY_DK DATE DEFAULT GETDATE(),
	TRANG_THAI_KHOA BIT DEFAULT 0,
	TRANG_THAI_KICH_HOAT BIT DEFAULT 0
)

--Tạo bảng đối tác
GO
CREATE TABLE DOI_TAC
(
	MA_DT CHAR(8) PRIMARY KEY,
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
	CONSTRAINT FK_DT_TK FOREIGN KEY(TEN_TK) REFERENCES TAI_KHOAN(TEN_TK)
)

--Tạo bảng hợp đồng
GO
CREATE TABLE HOP_DONG
(
	MA_HD CHAR(8) PRIMARY KEY,
	MA_DT CHAR(8),
	MA_THUE_DT VARCHAR(15) NOT NULL,
	NGUOI_DAI_DIEN_HD NVARCHAR(30) NOT NULL,
	NGAY_BD_HD DATE DEFAULT GETDATE(),
	NGAY_KT_HD DATE,
	XAC_NHAN_HD BIT DEFAULT 0,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_HD_DT FOREIGN KEY(MA_DT) REFERENCES DOI_TAC(MA_DT)
)

--Tạo bảng chi nhánh
GO
CREATE TABLE CHI_NHANH
(
	MA_CN CHAR(8) PRIMARY KEY,
	MA_DT CHAR(8) NOT NULL, 
	MA_HD CHAR(8),
	TEN_CN NVARCHAR(20) NOT NULL,
	DIA_CHI_CN NVARCHAR(30) UNIQUE NOT NULL,
	SO_DT_CN VARCHAR(10) UNIQUE NOT NULL,
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_CN_DT FOREIGN KEY(MA_DT) REFERENCES DOI_TAC(MA_DT),
	--Khóa ngoại tới hợp đồng
	CONSTRAINT FK_CN_HD FOREIGN KEY(MA_HD) REFERENCES HOP_DONG(MA_HD)
)

--Tạo bảng sản phẩm
GO
CREATE TABLE SAN_PHAM
(
	MA_SP CHAR(8) PRIMARY KEY,
	TEN_SP NVARCHAR(20) NOT NULL,
	MO_TA_SP NVARCHAR(30) DEFAULT '',
	GIA_SP INT NOT NULL CONSTRAINT CHK_SP_GIA_SP CHECK (GIA_SP > 0)
)

--Tạo bảng chi nhánh sản phẩm
GO
CREATE TABLE CHI_NHANH_SP
(
	MA_SP CHAR(8),
	MA_CN CHAR(8),
	SO_LUONG_CNSP INT NOT NULL DEFAULT 0 CONSTRAINT CHK_CHI_NHANH_SP_SO_LUONG CHECK (SO_LUONG_CNSP >= 0),
	GIA_CNSP INT,
	PRIMARY KEY (MA_SP, MA_CN),
	--Khóa ngoại tới sản phẩm
	CONSTRAINT FK_CNSP_SP FOREIGN KEY (MA_SP) REFERENCES SAN_PHAM(MA_SP),
	--Khóa ngoại tới chi nhánh chứa sản phẩm
	CONSTRAINT FK_CNSP_CN FOREIGN KEY (MA_CN) REFERENCES CHI_NHANH(MA_CN)
)

--Tạo bảng khách hàng
GO
CREATE TABLE KHACH_HANG
(
	MA_KH CHAR(8) PRIMARY KEY,
	TEN_TK VARCHAR(20) UNIQUE NOT NULL,
	HO_TEN_KH NVARCHAR(30) NOT NULL,
	DIA_CHI_KH NVARCHAR(30),
	SO_DT_KH VARCHAR(10) UNIQUE NOT NULL,
	EMAIL_KH VARCHAR(30) UNIQUE NOT NULL,
	--Khóa ngoại tới tài khoản khách hàng
	CONSTRAINT FK_KH_TK FOREIGN KEY (TEN_TK) REFERENCES TAI_KHOAN(TEN_TK)
)

--Tạo bảng tài xế
GO
CREATE TABLE TAI_XE
(
	MA_TX CHAR(8) PRIMARY KEY,
	TEN_TK VARCHAR(20) UNIQUE NOT NULL,
	HO_TEN_TX NVARCHAR(30) NOT NULL,
	CMND_TX  CHAR(10) UNIQUE NOT NULL,
	SO_DT_TX VARCHAR(10) NOT NULL,
	BIEN_SO_TX CHAR(15) NOT NULL,
	KHU_VUC_HD_TX NVARCHAR(20) NOT NULL,
	EMAIL_TX VARCHAR(30) NOT NULL,
	TAI_KHOAN_NH VARCHAR(20) NOT NULL,
	--Khóa ngoại tới tài khoản tài xế
	CONSTRAINT FK_TX_TK FOREIGN KEY (TEN_TK) REFERENCES TAI_KHOAN(TEN_TK)
)

--Tạo bảng đơn hàng
GO
CREATE TABLE DON_HANG
(
	MA_DH CHAR(8) PRIMARY KEY,
	MA_DT CHAR(8),
	MA_KH CHAR(8),
	MA_TX CHAR(8),
	HINH_THUC_TT NVARCHAR(30) NOT NULL,
	DIA_CHI_GH	NVARCHAR(30) NOT NULL,
	TINH_TRANG_DH NVARCHAR(15) NOT NULL,
	PHI_SP INT,
	PHI_VC INT NOT NULL CONSTRAINT CHK_DH_PHI_VC CHECK (PHI_VC > 0),
	--Khóa ngoại tới đối tác
	CONSTRAINT FK_DH_DT FOREIGN KEY(MA_DT) REFERENCES DOI_TAC(MA_DT),
	--Khóa ngoại tới khách hàng
	CONSTRAINT FK_DH_KH FOREIGN KEY(MA_KH) REFERENCES KHACH_HANG(MA_KH),
	--Khóa ngoại tới tài xế
	CONSTRAINT FK_DH_TX FOREIGN KEY(MA_TX) REFERENCES TAI_XE(MA_TX)
)

--Tạo bảng đơn hàng sản phẩm
GO
CREATE TABLE DON_HANG_SP
(
	MA_DH CHAR(8),
	MA_SP CHAR(8),
	SO_LUONG_SP_DH INT NOT NULL CONSTRAINT CHK_DHSP_SL CHECK (SO_LUONG_SP_DH > 0),
	GIA_SP_DH INT NOT NULL CONSTRAINT CHK_DHSP_GIA CHECK (GIA_SP_DH > 0),
	PRIMARY KEY(MA_DH, MA_SP),
	CONSTRAINT FK_DHSP_DH FOREIGN KEY(MA_DH) REFERENCES DON_HANG(MA_DH),
	CONSTRAINT FK_DHSP_SP FOREIGN KEY(MA_SP) REFERENCES SAN_PHAM(MA_SP)
)