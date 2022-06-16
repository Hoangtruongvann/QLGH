-- Unrepeatable Read - Thay đổi thông tin sản phẩm
create proc sp_updateProduct_Uread @MaSP char(10), @DonGia int
as
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
begin tran
	begin try
		if(not exists (select * from SanPham where MaSP = @MaSP	))
		begin
			print N'sản phẩm không tồn tại'
			rollback tran
			return 1
		end
		UPDATE SanPham
		SET DonGia = @DonGia
		WHERE MaSP = @MaSP
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
-- Unrepeatable Read - Thay đổi thông tin sản phẩm
create proc sp_updateProduct_Uread_fix @MaSP char(10), @DonGia int
as
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
begin tran
	begin try
		if(not exists (select * from SanPham where MaSP = @MaSP	))
		begin
			print N'sản phẩm không tồn tại'
			rollback tran
			return 1
		end
		UPDATE SanPham
		SET DonGia = @DonGia
		WHERE MaSP = @MaSP
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
--Phantom  - thêm 1 sản phẩm
create proc sp_createProduct @MaSP varchar(10),  @TenSP nvarchar(50),@MaDT char(10),@DonGia int, @SL_ConLai int
as
begin tran
	begin try
		if(exists (select * from SanPham where MaSP = @MaSP	))
		begin
			print N'sản phẩm đã tồn tại'
			rollback tran
			return 1
		end
		insert into SanPham values (@MaSP, @MaDT,@TenSP,@DonGia,@SL_ConLai)
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
--Phantom  - thêm 1 sản phẩm
create proc sp_createProduct_fix @MaSP varchar(10),  @TenSP nvarchar(50),@MaDT char(10),@DonGia int, @SL_ConLai int
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
	begin try
		if(exists (select * from SanPham where MaSP = @MaSP	))
		begin
			print N'sản phẩm đã tồn tại'
			rollback tran
			return 1
		end
		insert into SanPham values (@MaSP, @MaDT,@TenSP,@DonGia,@SL_ConLai)
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
-- Phantom - Đọc tổng tiền và danh sách sản phẩm
create proc sp_ThongKe @MaDT varchar(10), @DoanhThu int out
as
begin tran
	begin try
		if(not exists (select * from DoiTac where MaDT = @MaDT	))
		begin
			print N'Đối tác không tồn tại'
			rollback tran
			return 1
		end
	select DH.MaDH as N'Mã', DH.MaKH as N'Mã khách hàng', DH.DiaChi_GH as N'Địa chỉ giao', DH.PhiVanChuyen as N'Phí ship', DH.ThanhTien as N'Thành tiền', DH.HTThanhToan as N'Hình thức thanh toán',DH.TinhTrang as N'Tình trạng', DH.MaCN as N'Mã Chi Nhánh', DH.MaTX as N'Mã tài xế' from DonHang DH, ChiNhanh CN where CN.MaCN = DH.MaCN and CN.MaDT = @MaDT
	 
	WAITFOR DELAY '00:00:10'
	
	select @DoanhThu = SUM(DH.ThanhTien) from DonHang DH, ChiNhanh CN where DH.MaCN = CN.MaCN and CN.MaDT = @MaDT
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
-- Phantom - Đọc tổng tiền và danh sách sản phẩm
create proc sp_ThongKe_fix @MaDT varchar(10), @DoanhThu int out
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
	begin try
		if(not exists (select * from DoiTac where MaDT = @MaDT	))
		begin
			print N'Đối tác không tồn tại'
			rollback tran
			return 1
		end
	select DH.MaDH as N'Mã', DH.MaKH as N'Mã khách hàng', DH.DiaChi_GH as N'Địa chỉ giao', DH.PhiVanChuyen as N'Phí ship', DH.ThanhTien as N'Thành tiền', DH.HTThanhToan as N'Hình thức thanh toán',DH.TinhTrang as N'Tình trạng', DH.MaCN as N'Mã Chi Nhánh', DH.MaTX as N'Mã tài xế' from DonHang DH, ChiNhanh CN where CN.MaCN = DH.MaCN and CN.MaDT = @MaDT
	 
	WAITFOR DELAY '00:00:10'
	
	select @DoanhThu = SUM(DH.ThanhTien) from DonHang DH, ChiNhanh CN where DH.MaCN = CN.MaCN and CN.MaDT = @MaDT
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
--Lost update -- Thay đổi trạng thái đơn hàng
create proc sp_partner_updateOrder_lostUpdate @MaDH varchar(10), @TinhTrang nvarchar(50)
as
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
begin tran
	begin try
		if(not exists (select * from DonHang where MaDH = @MaDH))
		begin
			print N'đơn hàng không tồn tại'
			rollback tran
			return 1
		end
		select TinhTrang from DonHang where MaDH = @maDH
		WAITFOR DELAY '00:00:10'
		UPDATE DonHang
		SET TinhTrang = @TinhTrang
		WHERE MaDH = @MaDH
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
--Lost update -- Thay đổi trạng thái đơn hàng
create proc sp_partner_updateOrder_lostUpdate_fix @MaDH varchar(10), @TinhTrang nvarchar(50)
as
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
begin tran
	begin try
		if(not exists (select * from DonHang where MaDH = @MaDH))
		begin
			print N'đơn hàng không tồn tại'
			rollback tran
			return 1
		end
		select TinhTrang from DonHang where MaDH = @maDH
		WAITFOR DELAY '00:00:10'
		UPDATE DonHang
		SET TinhTrang = @TinhTrang
		WHERE MaDH = @MaDH
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
-- Conversion Deadlock -- Thay đổi trạng thái đơn hàng
create proc sp_partner_updateOrder_ConDeadlock @MaDH varchar(10), @TinhTrang nvarchar(50)
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
begin tran
	begin try
		if(not exists (select * from DonHang where MaDH = @MaDH))
		begin
			print N'đơn hàng không tồn tại'
			rollback tran
			return 1
		end
		select TinhTrang from DonHang where MaDH = @maDH
		WAITFOR DELAY '00:00:10'
		UPDATE DonHang
		SET TinhTrang = @TinhTrang
		WHERE MaDH = @MaDH
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go
--Lost update -- Thay đổi trạng thái đơn hàng
create proc sp_partner_updateOrder_ConDeadlock_fix @MaDH varchar(10), @TinhTrang nvarchar(50)
as
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
begin tran
	begin try
		if(not exists (select * from DonHang where MaDH = @MaDH))
		begin
			print N'đơn hàng không tồn tại'
			rollback tran
			return 1
		end
		select TinhTrang from DonHang where MaDH = @maDH
		WAITFOR DELAY '00:00:10'
		UPDATE DonHang
		SET TinhTrang = @TinhTrang
		WHERE MaDH = @MaDH
	end try
	begin catch
		print N'Lỗi hệ thống'
		rollback tran
	end catch
commit tran
return 0
go

