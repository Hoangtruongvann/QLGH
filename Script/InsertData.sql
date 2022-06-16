use QLGH
go
insert into Account values ('daoxt','12345','kh',1)
go
insert into KhachHang values('KH0001',N'Đào Xuân Trường','0982312332',N'Dĩ An, Bình Dương','DXT@gmail.com','daoxt')
go
insert into N_DaiDien values ('NDD001', 'Peter','Sài Gòn','0920219292','peter@cocacola.com')
go
insert into Account values ('cocacola','12345','kh',1)
go
insert into DoiTac values('DT001','Coca-Cola Corp',N'KCN Sóng thần,Dĩ An, Bình Dương', N'Nước có gas',30,'013819823170','0093183133','cocacola@corp.com','cocacola','NDD001' )
go
insert into Account values ('GiaoHangNhanh','12345','kh',1)
go
insert into TaiXe values('TX001',N'Nguyễn Văn A','0129318391',N'Thủ Đức, Tp.Hồ Chí Minh','51F97022',N'Thủ Đức, Tp.Hồ Chí Minh','hxh@gmail.com','999999990','829202011','GiaoHangNhanh')
go
insert into SanPham values ('SP0001','DT001',N'Cocacola Lon',100000,1000)
insert into SanPham values ('SP0002','DT001',N'fanta Lon',100000,1000)
insert into SanPham values ('SP0003','DT001',N'Nutri boost',100000,1000)
go
insert into ChiNhanh(MaCN,MaDT) values ('CN0001','DT001')
go
insert into DonHang values ('DH0001',N'Chuyển khoản', N'Thủ Đức, tpHCM', 0, 'TX001', N'Đang chuẩn bị hàng', 'CN0001', 'KH0001',0)
insert into DonHang values ('DH0002',N'Chuyển khoản', N'Quận 5, tpHCM', 0, 'TX001', N'Đang chuẩn bị hàng', 'CN0001', 'KH0001',0)
insert into DonHang values ('DH0003',N'Chuyển khoản', N'Quận 12, tpHCM', 0, 'TX001', N'Đang chuẩn bị hàng', 'CN0001', 'KH0001',0)
go
insert into CTDonHang values ('DH0001','SP0001',10)
insert into CTDonHang values ('DH0001','SP0003',5)
insert into CTDonHang values ('DH0001','SP0002',5)
go
insert into CTDonHang values ('DH0002','SP0001',10)
insert into CTDonHang values ('DH0002','SP0002',20)

insert into CTDonHang values ('DH0003','SP0002',30)
insert into CTDonHang values ('DH0003','SP0003',10)

insert into Account(Username, MatKhau, VaiTro, TrangThai) values
('admin1', '111', 'ad', 1),
('admin2', '222', 'ad', 1),
('khA', '333', 'kh', 1),
('txB', '444', 'tx', 1),
('dtC', '555', 'dt', 1),
('nvD', '111', 'nv', 1)


insert into Account(Username) values ('khachhang.01')
insert into Account(Username) values ('khachhang.02')
insert into Account(Username) values ('khachhang.03')


insert into KhachHang(MaKH,UserName) values ('KH001','khachhang.01')
insert into KhachHang(MaKH,UserName) values ('KH002','khachhang.02')
insert into KhachHang(MaKH,UserName) values ('KH003','khachhang.03')


insert into SanPham(MaSP, DonGia,SL_ConLai,MaDT,TenSP) values ('SP001',100000,100,'DT001','A')
insert into SanPham(MaSP, DonGia,SL_ConLai,MaDT,TenSP) values ('SP002',250000,100,'DT001','A')
insert into SanPham(MaSP, DonGia,SL_ConLai,MaDT,TenSP) values ('SP003',300000,100,'DT001','A')


insert into DonHang values ('DH001',N'Chuyển khoản', N'123 Hoa Lan, quận Phú Nhuận, tpHCM', 50000, 'TX001', N'Đang chuẩn bị hàng', 'CN0001', 'KH001',0)

insert into DonHang values ('DH002',N'COD', N'66 Trường Sa, quận Phú Nhuận, tpHCM', 50000, 'TX001', N'Đang giao hàng', 'CN0001', 'KH002',0)

insert into DonHang values ('DH003',N'COD', N'450 Kinh Dương Vương, quận Bình Tân, tpHCM', 700000, 'TX001', N'Đang giao hàng', 'CN0001', 'KH003',0)


insert into CTDonHang values ('DH001','SP001',10)
insert into CTDonHang values ('DH001','SP003',5)
insert into CTDonHang values ('DH001','SP002',5)

insert into CTDonHang values ('DH002','SP001',10)
insert into CTDonHang values ('DH002','SP002',20)

insert into CTDonHang values ('DH003','SP002',30)
insert into CTDonHang values ('DH003','SP003',10)