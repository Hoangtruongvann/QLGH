create database QLGH
go
use QLGH
go
----CREATE TABLE
--NhanVien
--DonHang
--CTDonHang
--TaiXe
--QuanTriVien
--KhachHang
--SanPham
create table NhanVien
(
	MaNV varchar(10),
	TenNV nvarchar(30),
	SDT varchar(11),
	DiaChi nvarchar(50),
	UserName varchar(20) unique,
	primary key(MaNV)
)

create table KhachHang
(
	MaKH varchar(10),
	TenKH nvarchar(30),
	SDT varchar(11),
	DiaChi nvarchar(50),
	Email nvarchar(30),
	UserName varchar(20) unique,
	primary key(MaKH)
)

create table SanPham
(
	MaSP varchar(10) not null,
	MaDT varchar(10) not null,
	TenSP nvarchar(30) not null,
	DonGia int not null check(DonGia > 0),
	SL_ConLai int not null check(SL_ConLai > 0),
	primary key(MaSP)
)

create table DonHang
(
	MaDH varchar(10),
	HTThanhToan nvarchar(30),
	DiaChi_GH nvarchar(50),
	PhiVanChuyen int not null default 0 check(PhiVanChuyen >= 0),
	MaTX varchar(10),
	TinhTrang nvarchar(50),
	MaCN varchar(10),
	MaKH varchar(10),
	ThanhTien int not null  default 0 check(ThanhTien >= 0),
	primary key(MaDH)
)

create table CTDonHang
(
	MaDH varchar(10),
	MaSP varchar(10),
	SoLuong int not null check(SoLuong > 0),
	primary key(MaDH, MaSP)
)

create table TaiXe
(
	MaTX varchar(10),
	TenTX nvarchar(30),
	SDT varchar(11),
	DiaChi nvarchar(50),
	BienSoXe varchar(8),
	KhuVuc nvarchar(50),
	Email nvarchar(50),
	Bank varchar(10),
	CMND varchar(12),
	UserName varchar(20) unique,
	primary key(MaTX)
)

create table QuanTriVien
(
	MaAd varchar(10),
	TenAd varchar(10),
	DiaChi nvarchar(50),
	SDT varchar(11),
	Email varchar(30),
	UserName varchar(20) unique,
	primary key(MaAd)
)

--N_DaiDien
--DoiTac
--ChiNhanh
--Account
--HopDong
create table N_DaiDien
(
	MaNDD varchar(10),
	TenNDD nvarchar(50),
	DiaChi nvarchar(50),
	SDT varchar(11),
	Email varchar(30),
	primary key (MaNDD)
)

create table DoiTac
(
	MaDT varchar(10),
	TenDT nvarchar(50),
	DiaChi nvarchar(50),
	LoaiHang nvarchar(30),
	SoCN int,
	MSThue varchar(20),
	PhoneNumber varchar(11),
	DT_Email nvarchar(30),
	Username varchar(20) unique,
	MaNDD varchar(10),
	primary key (MaDT)
)

create table ChiNhanh
(
	MaCN varchar(10),
	DiaChi nvarchar(50),
	MaDT varchar(10),
	primary key (MaCN)
)

create table Account
(
	Username varchar(20),
	MatKhau varchar(10),
	VaiTro varchar(2),
	TrangThai bit not null default 1,
	primary key (Username),
	check(VaiTro in('ad', 'dt', 'kh', 'nv', 'tx'))
)

create table HopDong
(
	MaHD varchar(10),
	MaDT varchar(10),
	NgayBD date,
	NgayKT date,
	Pthh int,
	primary key (MaHD)
)

----Ràng buộc khóa ngoại
go
alter table SanPham add constraint FK_SP_DT foreign key(MaDT) references DoiTac(MaDT)
alter table DonHang add constraint FK_DH_KH foreign key(MaKH) references KhachHang(MaKH)
alter table CTDonHang add constraint FK_CT_SP foreign key(MaSP) references SanPham(MaSP) 
alter table CTDonHang add constraint FK_CT_DH foreign key(MaDH) references DonHang
alter table DonHang add constraint FK_DH_TX foreign key(MaTX) references TaiXe(MaTX)
alter table DonHang add constraint FK_DH_CN foreign key(MaCN) references ChiNhanh

alter table NhanVien add constraint FK_NV_AC foreign key(UserName) references Account(UserName)
alter table TaiXe add constraint FK_TX_AC foreign key(UserName) references Account(UserName)
alter table QuanTriVien add constraint FK_QTV_AC foreign key(UserName) references Account(UserName)

alter table DoiTac add constraint FK_DT_NDD foreign key(MaNDD) references N_DaiDien(MaNDD)
alter table DoiTac add constraint FK_DT_AC foreign key(Username) references Account(Username)
alter table ChiNhanh add constraint FK_CN_DT foreign key(MaDT) references DoiTac(MaDT)
alter table HopDong add constraint FK_HD_DT foreign key(MaDT) references DoiTac(MaDT)
go
----RBTV
Create trigger trg_I_HD On HopDong
For insert
As
Begin
	If exists(select * from Inserted Where NgayBD > NgayKT)
	Begin
		Rollback transaction
	End
End
go
Create trigger trg_U_HD On HopDong
For update
As
Begin
	If update(NgayBD) or update(NgayKT)
	Begin
		If exists(select * from Inserted Where NgayBD > NgayKT)
		Begin
			Rollback transaction 
		End
	End
End
go
Create proc sp_ThanhTienDonHang
			@MaDH char(10)
As
Begin
	declare @tt int
	set @tt = (select sum(sp.DonGia * ct.SoLuong)
				from SanPham sp, CTDonHang ct
				where sp.MaSP = ct.MaSP and ct.MaDH = @MaDH)
	update DonHang
	set ThanhTien = @tt
	where MaDH = @MaDH
End
go
Create trigger trg_IU_CTDH On CTDonHang
For insert, update
As
Begin
	declare @maDH varchar(10)
	set @maDH = (select MaDH from inserted)
	exec sp_ThanhTienDonHang @maDH
End
go
Create trigger trg_D_CTDH On CTDonHang
For delete
As
Begin
	declare @maDH varchar(10)
	set @maDH = (select MaDH from deleted)
	exec sp_ThanhTienDonHang @maDH
End