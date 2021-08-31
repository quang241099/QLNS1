/* Proc danh mục admin */

/* Xem danh mục chức vụ*/

CREATE PROC XEM_DM_CV_ADMIN AS
 BEGIN 
 SELECT * FROM DanhMucChucVu
 END 
 GO

/* DanhMucChucVu */
CREATE PROC THEMCV_ADMIN
(
  @MaChucVu varchar(20),
  @Ten nvarchar(40),
  @PhuCap int
)as
begin
 INSERT INTO  [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES ( @MaChucVu, @Ten, @PhuCap )
 end
go

CREATE PROC SUACV_ADMIN
(
  @MaChucVu varchar(20),
  @Ten varchar(30),
  @PhuCap int
)as
begin
 UPDATE DanhMucChucVu SET MaChucVu = @MaChucVu , Ten = @Ten, PhuCap = @PhuCap
						WHERE MaChucVu = @MaChucVu
end
go

DROP proc SUACV_ADMIN
go

CREATE proc XOACV_ADMIN (@MaChucVu VARCHAR (20) )
AS
BEGIN 
DELETE DanhMucChucVu WHERE MaChucVu = @MaChucVu
END
GO

/* Xem danh mục phòng ban */
CREATE PROC XEMPB_ADMIN AS
 BEGIN 
 SELECT * FROM PhongBan
 END 
 GO

/* Danh mục phòng ban*/
CREATE PROC THEM_DM_PB_ADMIN
(
  @MaPhongBan varchar(20),
  @Ten nvarchar(50),
  @DienThoai int
)as
begin
 INSERT INTO  [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES ( @MaPhongBan, @Ten, @DienThoai )
 end
go

CREATE PROC SUAPB_ADMIN
(
  @MaPhongBan varchar(20),
  @Ten nvarchar(50),
  @DienThoai int
)as
begin
 UPDATE PhongBan SET MaPhongBan = @MaPhongBan , Ten = @Ten, DienThoai = @DienThoai
						WHERE MaPhongBan = @MaPhongBan
end
go

Drop proc SUAPB_ADMIN
go

CREATE proc XOAPB_ADMIN (@MaPhongBan VARCHAR (20) )
AS
BEGIN 
DELETE PhongBan WHERE MaPhongBan = @MaPhongBan
END
GO


/* Xem danh mục bảo hiểm */
CREATE PROC XEM_DM_BH_ADMIN AS
 BEGIN 
 SELECT * FROM DANHMUCBAOHIEM
 END 
 GO

/* Danh mục bảo hiểm*/

CREATE PROC THEMBH_ADMIN
(
  @MaBaoHiem varchar(20),
  @Ten nvarchar(40),
  @TiLeBH float
)as
begin
 INSERT INTO  [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem], [Ten], [TiLeBH]) VALUES ( @MaBaoHiem, @Ten, @TiLeBH )
 end
go

CREATE PROC SUABH_ADMIN
(
  @MaBaoHiem varchar(20),
  @Ten nvarchar(50),
  @TiLeBH float
)as
begin
 UPDATE DANHMUCBAOHIEM SET MaBaoHiem = @MaBaoHiem , Ten = @Ten, TiLeBH = @TiLeBH
						WHERE MaBaoHiem = @MaBaoHiem
end
go

drop proc SUABH_ADMIN
go

CREATE proc XOABH_ADMIN (@MaBaoHiem VARCHAR (20) )
AS
BEGIN 
DELETE DANHMUCBAOHIEM WHERE MaBaoHiem = @MaBaoHiem
END
GO


/* Xem danh mục Khen thưởng kỷ luật */
CREATE PROC XEM_DM_KTKL_ADMIN AS
 BEGIN 
 SELECT * FROM QuyDinhKTKL
 END 
 GO

/*Danh mục KTKL*/

CREATE PROC THEMKTKL_ADMIN
(
  @MaKTKL varchar(20),
  @Ten nvarchar(40),
  @SoTien int
)as
begin
 INSERT INTO  [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES ( @MaKTKL, @Ten, @SoTien )
 end
go

CREATE PROC SUAKTKL_ADMIN
(
  @MaKTKL varchar(20),
  @Ten nvarchar(50),
  @SoTien int
)as
begin
 UPDATE QuyDinhKTKL SET MaKTKL = @MaKTKL , Ten = @Ten, SoTien = @SoTien
						WHERE MaKTKL = @MaKTKL
end
go

drop proc SUAKTKL_ADMIN
go

CREATE proc XOAKTKL_ADMIN (@MaKTKL VARCHAR (20) )
AS
BEGIN 
DELETE QuyDinhKTKL WHERE MaKTKL = @MaKTKL
END
GO

CREATE PROC XEMCV_NHANVIEN (@MaNhanVien varchar(20))
as
begin 
  select DanhMucChucVu.MaChucVu, DanhMucChucVu.Ten, DanhMucChucVu.PhuCap
  from DanhMucChucVu, DanhMucNhanVien
  where DanhMucChucVu.MaChucVu = DanhMucNhanVien.MaChucVu
  and DanhMucNhanVien.MaNhanVien = @MaNhanVien
end
go 

drop proc XEMCV_NHANVIEN 
go

exec XEMCV_NHANVIEN '01'
go

CREATE PROC XEMPB_NHANVIEN (@MaNhanVien varchar(20))
as
begin 
  select PhongBan.MaPhongBan,PhongBan.Ten, PhongBan.DienThoai
  from PhongBan, DanhMucNhanVien
  where PhongBan.MaPhongBan = DanhMucNhanVien.MaPhongBan
  and DanhMucNhanVien.MaNhanVien = @MaNhanVien
end
go 

exec XEMPB_NHANVIEN '02'
go

CREATE PROC XEMBH_NHANVIEN (@MaNhanVien varchar(20))
as
begin 
  select DANHMUCBAOHIEM.MaBaoHiem, DANHMUCBAOHIEM.Ten, DANHMUCBAOHIEM.TiLeBH
  from DANHMUCBAOHIEM, BaoHiemNhanVien
  where DANHMUCBAOHIEM.MaBaoHiem = BaoHiemNhanVien.MaBaoHiem
  and BaoHiemNhanVien.MaNhanVien = @MaNhanVien
end
go 

exec XEMBH_NHANVIEN '02'
go

CREATE PROC XEMKTKL_NHANVIEN (@MaNhanVien varchar(20))
as
begin 
  select QuyDinhKTKL.MaKTKL, QuyDinhKTKL.Ten, QuyDinhKTKL.SoTien
  from QuyDinhKTKL, DanhSachKTKL
  where DanhSachKTKL.MaKTKL = QuyDinhKTKL.MaKTKL
  and DanhSachKTKL.MaNhanVien = @MaNhanVien
end
go 

exec XEMKTKL_NHANVIEN '02'
go

create proc dangnhap1 as 
begin select MaNhanVien,sdt
from DanhMucNhanVien 
end
go

exec  dangnhap1
go