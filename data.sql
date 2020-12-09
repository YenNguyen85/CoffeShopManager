CREATE Database QLCoffee
go
use QLCoffee
go

CREATE TABLE BANAN
(
	id INT IDENTITY PRIMARY KEY,
	TrangThaiBan bit NOT NULL DEFAULT 0 	--0: Trống || 1: Có người	
)
Go



CREATE TABLE LOAITK (
	idLoaiTK INT IDENTITY PRIMARY KEY, -- 1:admin, 2:user
	TenLoaiTK varchar(10),
)
GO

CREATE TABLE TAIKHOAN
(
	TenNguoiDung NVARCHAR(100) PRIMARY KEY,
	TenHienThi NVARCHAR(100) NOT NULL,
	MatKhau NVARCHAR(1000) NOT NULL DEFAULT 0,
	LoaiTK INT NOT NULL DEFAULT 0	--1: adim && 2: staff

	foreign key (LoaiTK) References LOAITK(idLoaiTK)
)
GO

CREATE TABLE LOAIMON
(
	id INT IDENTITY PRIMARY KEY,
	TenLoai NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',	
)
GO

CREATE TABLE MONAN
(
	id INT IDENTITY PRIMARY KEY,
	TenMon NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idLoaiMon INT NOT NULL, 
	GiaTien FLOAT NOT NULL

	FOREIGN KEY(idLoaiMon) REFERENCES LOAIMON(id)
)
GO

CREATE TABLE KHUYENMAI
(
	id INT IDENTITY PRIMARY KEY,
	TenKhuyenMai nvarchar(255) NOT NULL DEFAULT N'Chưa đặt tên',
	NgayBatDau DATE NOT NULL,
	NgayKetThuc DATE NOT NULL	
)
GO

CREATE TABLE MONKHUYENMAI
(
	id INT IDENTITY PRIMARY KEY,
	idMonAn INT NOT NULL,
	idKhuyenMai INT NOT NULL,
	HeSo INT NOT NULL DEFAULT 0

	FOREIGN KEY(idMonAn) REFERENCES MONAN(id),
	FOREIGN KEY(idKhuyenMai) REFERENCES KHUYENMAI(id)		
)
GO

CREATE TABLE CHUCVU
(
	id INT IDENTITY PRIMARY KEY,
	TenChucVu NVARCHAR(100),
	Luong INT NOT NULL	
)
GO

CREATE TABLE NHANVIEN
(
	id INT IDENTITY PRIMARY KEY,
	TenNhanVien NVARCHAR(100),
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	Sdt VARCHAR(10) NOT NULL,
	TenTaiKhoan NVARCHAR(100),
	idChucVu INT NOT NULL

	FOREIGN KEY(idChucVu) REFERENCES CHUCVU(id),
	FOREIGN KEY(TenTaiKhoan) REFERENCES TAIKHOAN(TenNguoiDung)
)
GO


CREATE TABLE HOADON
(
	id INT IDENTITY PRIMARY KEY,
	ThoiGianVao DATE NOT NULL,
	ThoiGianRa DATE NOT NULL,
	idTable INT NOT NULL,
	idKhuyenMai INT NULL,
	idNhanVien INT NOT NULL,
	TrangThaiHoaDon bit NOT NULL DEFAULT 0 --1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY(idTable) REFERENCES BANAN(id),
	FOREIGN KEY(idKhuyenMai) REFERENCES KHUYENMAI(id),
	FOREIGN KEY(idNhanVien) REFERENCES NHANVIEN(id)		
)
GO

CREATE TABLE CHAMCONG
(
	id INT IDENTITY PRIMARY KEY,
	Ngay DATE NOT NULL unique,  -- đảm bảo mỗi ngày chỉ có 1 bảng chấm công
)
GO

CREATE TABLE CHAMCONGNHANVIEN
(
	id INT IDENTITY PRIMARY KEY,
	idChamCong INT NOT NULL,
	idNhanVien INT NOT NULL,
	GioBatDau TIME NOT NULL,
	GioKetThuc TIME NOT NULL,

	FOREIGN KEY(idChamCong) REFERENCES CHAMCONG(id),
	FOREIGN KEY(idNhanVien) REFERENCES NHANVIEN(id)		
)
GO

CREATE TABLE CHITIETHOADON
(
	id INT IDENTITY PRIMARY KEY,
	idHoaDon INT NOT NULL,
	idMonAn INT NOT NULL,
	SoLuong INT NOT NULL DEFAULT 0

	FOREIGN KEY(idHoaDon) REFERENCES HOADON(id),
	FOREIGN KEY(idMonAn) REFERENCES MONAN(id)		
)
GO

Insert into CHUCVU(TenChucVu, Luong) Values (N'Phục vụ', 15000)
Insert into CHUCVU(TenChucVu, Luong) Values (N'Pha chế', 20000)
Insert into CHUCVU(TenChucVu, Luong) Values (N'Quản lý', 30000)

INSERT INTO LOAITK(TenLoaiTK) VALUES ('Admin')
INSERT INTO LOAITK(TenLoaiTK) VALUES ('User')

INSERT INTO TAIKHOAN (TenNguoiDung, TenHienThi, MatKhau, LoaiTK) VALUES ('Admin', N'Quản lý', N'1', 1 )
INSERT INTO TAIKHOAN (TenNguoiDung, TenHienThi, MatKhau, LoaiTK) VALUES ('Staff', N'Nhân viên', N'0', 2 )

INSERT INTO NHANVIEN (TenNhanVien, NgaySinh, DiaChi, Sdt, TenTaiKhoan, idChucVu) values (N'Yến', '2000-08-05', N'Nhà Lộc', '033333333', 'Admin', 3)
INSERT INTO NHANVIEN (TenNhanVien, NgaySinh, DiaChi, Sdt, TenTaiKhoan, idChucVu) values (N'Lộc', '2000-08-05', N'Nhà Lộc', '033333333', 'Staff', 3)

Insert into LOAIMON(TenLoai) Values (N'Coffee')
Insert into LOAIMON(TenLoai) Values (N'Macchiato')
Insert into LOAIMON(TenLoai) Values (N'Ice blended')
Insert into LOAIMON(TenLoai) Values (N'Milktea')
Insert into LOAIMON(TenLoai) Values (N'Cake')

Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Espresso', 1, 18000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Cà phê sữa', 1, 20000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Latte', 1, 27000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Cappuccino', 1, 30000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Chocolate Macchiato', 2, 32000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Matcha Macchiato', 2, 34000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Caramel Macchiato', 2, 30000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Trà xanh Macchiato', 2, 28000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Frappu', 3, 38000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Frappu Caramel', 3, 36000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Frappu Oreo', 3, 40000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Trà sữa truyền thống', 4, 22000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Hồng trà sữa', 4, 27000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Lục trà sữa', 4, 24000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Chesse Crepe', 5, 38000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Panna Cotta', 5, 50000)
Insert into MONAN(TenMon, idLoaiMon, GiaTien) Values (N'Chocolate Tiramisu', 5, 40000)

insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)
insert into BANAN(TrangThaiBan) Values (0)

use QLCoffee
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('1-12-2020', '1-12-2020', 1, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('2-12-2020', '2-12-2020', 3, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('3-12-2020', '3-12-2020', 3, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('4-12-2020', '4-12-2020', 3, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('5-12-2020', '5-12-2020', 2, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('6-12-2020', '6-12-2020', 2, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('7-12-2020', '7-12-2020', 5, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('8-12-2020', '8-12-2020', 6, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('9-12-2020', '9-12-2020', 7, null, 2, 1)
insert into HOADON(ThoiGianVao, ThoiGianRa, idTable, idKhuyenMai, idNhanVien, TrangThaiHoaDon) values ('10-12-2020','10-12-2020', 8, null, 2, 1)

insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('1', '1', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('1', '3', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('1', '2', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('2', '1', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('2', '2', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('2', '4', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('2', '3', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('2', '3', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('3', '1', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('3', '4', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('4', '2', '3')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('4', '1', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('5', '6', '3')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('5', '4', '4')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('5', '6', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('5', '3', '5')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('6', '4', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('6', '5', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('6', '4', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('6', '3', '5')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('7', '4', '7')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('8', '1', '2')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('9', '5', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('10', '1', '1')
insert into CHITIETHOADON(idHoaDon, idMonAn, SoLuong) values ('10', '1', '1')

insert into CHAMCONG(Ngay) values ('1-12-2020')
insert into CHAMCONG(Ngay) values ('2-12-2020')
insert into CHAMCONG(Ngay) values ('3-12-2020')
insert into CHAMCONG(Ngay) values ('4-12-2020')
insert into CHAMCONG(Ngay) values ('5-12-2020')
insert into CHAMCONG(Ngay) values ('6-12-2020')
insert into CHAMCONG(Ngay) values ('7-12-2020')
insert into CHAMCONG(Ngay) values ('8-12-2020')
insert into CHAMCONG(Ngay) values ('9-12-2020')
insert into CHAMCONG(Ngay) values ('10-12-2020')

insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (1, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (1, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (2, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (2, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (3, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (3, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (4, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (4, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (5, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (5, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (6, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (7, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (7, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (8, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (8, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (9, 2, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (9, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (10, 1, '15:00:00', '17:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (10, 1, '6:30:00', '11:30:00')
insert into CHAMCONGNHANVIEN(idChamCong, idNhanVien, GioBatDau, GioKetThuc) values (10, 2, '6:30:00', '11:30:00')
