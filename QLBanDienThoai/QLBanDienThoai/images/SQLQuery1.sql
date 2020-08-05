/*
Thanh vien: Ngo Hieu
			Le Thanh Thien
Đo an mon: ASP.Net
Đe: Thiet ke CSDL cho 1 trang web QL BAn DT
*/
CREATE DATABASE QLBanDienThoai
GO
USE QLBanDienThoai
GO
-- Tao bang Tai khoan Dang nhap cho admin
CREATE TABLE TKADMIN
(
	MaTK INT PRIMARY KEY IDENTITY(1,1), -- Khoa chinh, ma tai khoan tu dong tang (1, 1): bat dau tu 1, va moi lan tang len 1
	TenTK NVARCHAR(40) NOT NULL,
	MatKhau NVARCHAR(20) NOT NULL, 
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko ton tai nua
)
GO
--Tao bang table nha SX
CREATE TABLE NHASX (
  MaSX varchar(10)  PRIMARY KEY NOT NULL, -- khoa chinh
  TenSX nvarchar(100)  NOT NULL,
)
--Tao bang table san pham 
CREATE TABLE SANPHAM (
  MaSP INT PRIMARY KEY IDENTITY(1, 1), -- khoa chinh
  TenSP nvarchar(100)  NOT NULL,
  GiaCu MONEY,
  GiaMoi MONEY,
  ThongSoSP nvarchar(MAX) NOT NULL,
  ImgSP NVARCHAR(MAX) NOT NULL,
  MaSX varchar(10),--khoa phu
  --MaTK INT,--khoa phu
  constraint FK_SP_SX	Foreign Key(MaSX) References NHASX(MaSX), 
  --constraint FK_SP_AD	Foreign Key(MaTK) References TKADMIN(MaTK),
)
--Tao bang  table khac hang
CREATE TABLE TKKHACHHANG
(
	MaUser INT PRIMARY KEY IDENTITY(1,1), -- Khoa chinh, ma tai khoan tu dong tang (1, 1): bat dau tu 1, va moi lan tang len 1
	TenUser NVARCHAR(40) NOT NULL,
	SDTUser INT NOT NULL,
	NgaySinh NVARCHAR(30) NOT NULL,
	MKUser NVARCHAR(20) NOT NULL, 
	Email nvarchar(50) NOT NULL,
	DiaChi NVARCHAR(200)NOT NULL,
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko ton tai nua
)
-- TAO BANG DON HANG
CREATE TABLE DONHANG (
  MaDH varchar(10)  PRIMARY KEY NOT NULL, -- khoa chinh
  NgayGiao NVARCHAR(30) NOT NULL,
  NgayDat NVARCHAR(30) NOT NULL,
  ThanhToan NVARCHAR(20) NOT NULL,
  MaUser INT, -- KHOA PHU
  MaSP int, --KHOA PHU
  constraint FK_HD_SP	Foreign Key(MaSP) References SANPHAM(MaSP), 
  constraint FK_HD_KH	Foreign Key(MaUser) References TKKHACHHANG(MaUser),
)
--INSERT DL ADMIN
INSERT INTO TKADMIN(TenTK, MatKhau)
VALUES (N'admin1', '123')
GO
INSERT INTO TKADMIN(TenTK, MatKhau)
VALUES (N'admin2', '123')
GO
INSERT INTO TKADMIN(TenTK, MatKhau)
VALUES (N'admin3', '123')
GO
--INSERT DL Nha SX
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('IP', N'Iphone')
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('OP', N'Oppo')
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('SS', N'SamSung')
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('NK', N'Nokia')
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('AS', N'Asus')
INSERT INTO NHASX(MaSX, TenSX)
VALUES ('VI', N'Vivo')
--INSERT DL SAN PHAM
--SAN PHAM DT VIVO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y91C', 4600000, 4500000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 8.1 (Oreo)
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek MT6762R 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy91c.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y11', 4900000, 5100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.35", HD+
•Hệ điều hành: Android 9.0 (Pie)
•Camera sau: Chính 13 MP & Phụ 2 MP
•Camera trước: 8 MP
•CPU: Snapdragon 439 8 nhân
•RAM:3 GB
•Bộ nhớ trong:32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy11.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo U10', 4950000, 5100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.35", HD+
•Hệ điều hành: Android 9.0 (Pie)
•Camera sau: Chính 13 MP & Phụ 8 MP, 2 MP
•CPU: Snapdragon 665 8 nhân
•RAM: 4 GB
•Bộ nhớ trong: 64 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivou10.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y19', 4950000, 3100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.53", Full HD+
•Hệ điều hành: Android 9.0 (Pie)
•Camera sau: Chính 16 MP & Phụ 8 MP, 2 MP
•Camera trước: 16 MP
•CPU: MediaTek MT6768 8 nhân (Helio P65)
•RAM: 6 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy19.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y30', 4950000, 3100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.47", HD+
•Hệ điều hành: Android 10
•Camera sau: Chính 13 MP & Phụ 8 MP, 2 MP, 2 MP
•Camera trước: 8 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 4 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy30.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y50', 4950000, 3120000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.53", Full HD+
•Hệ điều hành: Android 10
•Camera sau: Chính 13 MP & Phụ 8 MP, 2 MP, 2 MP
•Camera trước: 16 MP
•CPU: Snapdragon 665 8 nhân
•RAM: 8 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy50.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo S1 Pro', 9500000, 8100000,N'Thông số kỹ thuật
•Màn hình: Super AMOLED, 6.38", Full HD+
•Hệ điều hành: Android 9.0 (Pie)
•Camera sau: Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP
•Camera trước: 32 MP
•CPU: Snapdragon 665 8 nhân
•RAM: 8 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivos1pro.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo V19', 4950000, 3100000,N'Thông số kỹ thuật
•Màn hình: Super AMOLED, 6.44", Full HD+
•Hệ điều hành: Android 10
•Camera sau: Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP
•Camera trước: Chính 32 MP & Phụ 8 MP
•CPU: Snapdragon 712 8 nhân
•RAM: 8 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivov19.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo V19 Neo', 3500000, 3100000,N'Thông số kỹ thuật
•Màn hình: Super AMOLED, 6.44", Full HD+
•Hệ điều hành: Android 10
•Camera sau: Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP
•Camera trước: Chính 32 MP & Phụ 8 MP
•CPU: Snapdragon 712 8 nhân
•RAM: 8 GB
•Bộ nhớ trong: 128 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivov19neo.png','VI')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Vivo Y1s', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'vivoy1s.png','VI')
GO
--SAN PHAM DT SAMSUNG
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A80', 14950000, 9100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya80.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy S10 Lite', 7950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxys10lite.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A71', 8950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya71.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A70', 4950000, 9100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya70.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A51', 4950000, 7100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya51.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A50s', 4950000, 8100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya50s.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A31', 4950000, 7100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya31.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A30s', 4950000, 9100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya30s.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A21s', 6950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya21s.png','SS')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Samsung Galaxy A20s', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'samsunggalaxya20s.png','SS')
GO
--DL OPPO


INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO A31', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'oppoa31.png','OP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO Reno3', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'opporeno3.png','OP')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO Reno2 F', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'opporeno2f.png','OP')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO A92', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'oppoa92.png','OP')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO A52', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'oppoa52.png','OP')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'OPPO Find X2', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: IPS LCD, 6.22", HD+
•Hệ điều hành: Android 10
•Camera sau: 13 MP
•Camera trước: 5 MP
•CPU: MediaTek Helio P35 8 nhân
•RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ nhớ: MicroSD, hỗ trợ tối đa 256 GB
•Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G',N'oppofindx2.png','OP')
GO

--DL NOKIA


INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia 110', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokia110.png','NK')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia C2', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokiac2.png','NK')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia 105', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokia105.png','NK')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia 5310', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokia5310.png','NK')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia 150 ', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokia150.png','NK')
GO

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'Nokia 5.3', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: TFT, 1.77", 65.536 màu
•Danh bạ: 500 số
•Thẻ nhớ ngoài: MicroSD, hỗ trợ tối đa 32 GB
•Camera: QVGA 320x240
•Jack cắm tai nghe: 3.5 mm
•Radio FM: Có
•Dung lượng pin:800 mAh',N'nokia53.png','NK')
GO

--DL IPHONE

INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone 7', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphone7.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone 11', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphone11.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone Xs', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphonexs.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone SE', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphonese.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone 8 Plus', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphone8plus.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone SE 128GB', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphonese128gb.png','IP')
GO
INSERT INTO SANPHAM(TenSP, GiaCu, GiaMoi, ThongSoSP, ImgSP, MaSX)
VALUES (N'iPhone 7 Plus', 4950000, 6100000,N'Thông số kỹ thuật
•Màn hình: LED-backlit IPS LCD, 4.7", Retina HD
•Hệ điều hành: iOS 13
•	Camera sau: 12 MP
•Camera trước: 7 MP
•CPU: Apple A10 Fusion 4 nhân
•	=RAM: 2 GB
•Bộ nhớ trong: 32 GB
•Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G
•Dung lượng pin: 1960 mAh',N'iphone7plus.png','IP')
GO
--DL KHACH HANG
INSERT INTO TKKHACHHANG(TenUser ,SDTUser ,NgaySinh, MKUser , Email,DiaChi)
VALUES (N'NgoHieu',0977904529,N'05/12/1996',123456,N'NGOHIEU@GMAIL.COM',N'DAK LAK')
GO
INSERT INTO TKKHACHHANG(TenUser ,SDTUser ,NgaySinh, MKUser , Email,DiaChi)
VALUES (N'LeThanhThien',0985642515,N'20/4/1998',123456,N'lethanhthien@gmail.com',N'QANG NGAI')
GO

--DL DON HANG
INSERT INTO DONHANG(MaDH, NgayGiao,NgayDat,ThanhToan,MaUser , MaSP)
VALUES (N'DH001',N'20/4/2020',N'20/3/2020',N'DA THANH TOAN',1,20)
GO
INSERT INTO DONHANG(MaDH, NgayGiao,NgayDat,ThanhToan,MaUser , MaSP)
VALUES (N'DH002',N'DANG VAN CHUEYN',N'10/6/2020',N'CHUA THANH TOAN',2,15)
GO

INSERT INTO DONHANG(MaDH, NgayGiao,NgayDat,ThanhToan,MaUser , MaSP)
VALUES (N'DH003',N'DANG VAN CHUEYN',N'10/6/2020',N'CHUA THANH TOAN',2,15)
GO
















--Load dl
SELECT * FROM SANPHAM
GO
SELECT * FROM TKADMIN
GO
SELECT * FROM TKKHACHHANG
GO
SELECT * FROM NHASX
GO
SELECT * FROM DONHANG
GO