CREATE DATABASE QuanLyNhanSu
/****** Object:  Table [dbo].[BaoHiemNhanVien]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHiemNhanVien](
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaBaoHiem] [varchar](20) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayHetHan] [date] NULL,
	[SoTienDongMotThang] [int] NULL,
 CONSTRAINT [FK_BaoHiemNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC,
	[MaBaoHiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUCBAOHIEM]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCBAOHIEM](
	[MaBaoHiem] [varchar](20) NOT NULL,
	[Ten] [nvarchar](40) NULL,
	[TiLeBH] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoHiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucChucVu]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucChucVu](
	[MaChucVu] [varchar](20) NOT NULL,
	[Ten] [nvarchar](40) NULL,
	[PhuCap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUCHINHTHUCTUYENDUNG]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCHINHTHUCTUYENDUNG](
	[MaHinhThucTuyenDung] [varchar](20) NOT NULL,
	[Ten] [nvarchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHinhThucTuyenDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucNhanVien]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucNhanVien](
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaHinhThucTuyenDung] [varchar](20) NULL,
	[MaChucVu] [varchar](20) NULL,
	[MaPhongBan] [varchar](20) NULL,
	[NoiLamViec] [nvarchar](40) NULL,
	[HoTen] [nvarchar](40) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](40) NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[SoCMND] [varchar](40) NULL,
	[TrinhDo] [nvarchar](40) NULL,
	[SDT] [varchar](40) NULL,
	[Email] [nvarchar](40) NULL,
	[NoiO] [nvarchar](40) NULL,
	[NoiSinh] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachKTKL](
	[MaNhanVien] [varchar](20) NOT NULL,
	[MaKTKL] [varchar](20) NOT NULL,
	[Ngay] [date] NOT NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [varchar](10) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[LuongHD] [int] NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongNhanVien]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongNhanVien](
	[MaLuong] [varchar](20) NOT NULL,
	[MaNhanVien] [varchar](20) NOT NULL,
	[LuongHD] [int] NULL,
	[SoNgayCong] [int] NULL,
	[ThangNam] [varchar](10) NOT NULL,
	[TienBH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DienThoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinhKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhKTKL](
	[MaKTKL] [varchar](20) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[SoTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKTKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Ten] [varchar](10) NULL,
	[MK] [varchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'01', N'BH01', CAST(N'2019-05-06' AS Date), CAST(N'2024-05-29' AS Date), 560000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'01', N'BH02', CAST(N'2019-05-06' AS Date), CAST(N'2024-05-29' AS Date), 105000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'02', N'BH02', CAST(N'2020-01-06' AS Date), CAST(N'2025-02-06' AS Date), 135000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'03', N'BH02', CAST(N'2020-03-19' AS Date), CAST(N'2025-04-06' AS Date), 180000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'03', N'BH03', CAST(N'2019-12-06' AS Date), CAST(N'2024-02-17' AS Date), 120000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'04', N'BH02', CAST(N'2020-03-19' AS Date), CAST(N'2025-04-06' AS Date), 118500)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'05', N'BH02', CAST(N'2020-03-06' AS Date), CAST(N'2025-04-06' AS Date), 135000)
GO
INSERT [dbo].[BaoHiemNhanVien] ([MaNhanVien], [MaBaoHiem], [NgayBatDau], [NgayHetHan], [SoTienDongMotThang]) VALUES (N'06', N'BH02', CAST(N'2020-03-06' AS Date), CAST(N'2025-04-06' AS Date), 82500)
GO
INSERT [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem], [Ten], [TiLeBH]) VALUES (N'BH01', N'Bảo hiểm xã hội', 0.08)
GO
INSERT [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem], [Ten], [TiLeBH]) VALUES (N'BH02', N'Bảo hiểm y tế', 0.015)
GO
INSERT [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem], [Ten], [TiLeBH]) VALUES (N'BH03', N'Bảo hiểm thất nghiệp', 0.01)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV01', N'Trưởng phòng', 3000000)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV02', N'Tổ trưởng', 2000000)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV03', N'Nhân viên kinh doanh', 1000000)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV04', N'Nhân viên tài chính', 900000)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV05', N'Nhân viên hậu cần', 500000)
GO
INSERT [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES (N'CV06', N'Nhan vien bảo vệ', 500000)
GO
INSERT [dbo].[DANHMUCHINHTHUCTUYENDUNG] ([MaHinhThucTuyenDung], [Ten]) VALUES (N'TD01', N'Từ Website công ty')
GO
INSERT [dbo].[DANHMUCHINHTHUCTUYENDUNG] ([MaHinhThucTuyenDung], [Ten]) VALUES (N'TD02', N'Website khác')
GO
INSERT [dbo].[DANHMUCHINHTHUCTUYENDUNG] ([MaHinhThucTuyenDung], [Ten]) VALUES (N'TD03', N'Qua mạng xã hội')
GO
INSERT [dbo].[DANHMUCHINHTHUCTUYENDUNG] ([MaHinhThucTuyenDung], [Ten]) VALUES (N'TD04', N'Tuyển dụng trực tiếp qua các trường')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'01', N'TD01', N'CV01', N'PB01', N'Tầng 2 ', N'Nguyễn Mai Linh', CAST(N'1980-03-10' AS Date), N'Tây Hồ - Hà Nội', N'Nữ', N'187823193', N'Thac si', N'0685458206', N'nguyenmailinh@gmail.com', N'Tây Hồ - Hà Nội', N'Ba Đình - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'02', N'TD04', N'CV03', N'PB03', N'Tầng 3', N'Nguyễn Đình Huy', CAST(N'1972-02-13' AS Date), N'Đô Lương - Nghệ An', N'Nam', N'187598246', N'12/12', N'0985426525', N'nguyendinhhuy@gmail.com', N'Tây Hồ - Hà Nội', N'Bắc Từ Liêm - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'03', N'TD02', N'CV02', N'PB02', N'Tầng 4', N'Lê Huy Khải', CAST(N'1990-05-05' AS Date), N'Ba Đình - Hà Nội', N'Nam', N'185845962', N'12/12', N'0985745268', N'lehuykhai@gmail.com', N'Cầu Giấy - Hà Nội', N'Ba Đình - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'04', N'TD01', N'CV04', N'PB02', N'Tầng 4', N'Đinh Thu Hương', CAST(N'1985-03-10' AS Date), N'Tứ Kỳ - Hải Dương', N'Nữ', N'175935945', N'Thac si', N'0985553812', N'dinhthuhuong@gmail.com', N'Cầu Giấy - Hà Nội', N'Tứ Kỳ - Hải Dương')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'05', N'TD03', N'CV03', N'PB03', N'Tầng 3', N'Nguyễn Đình Hưng', CAST(N'1991-07-11' AS Date), N'Hà Đông - Hà Nội', N'Nam', N'188298462', N'12/12', N'0985426854', N'nguyendinhhung@gmail.com', N'Hà Đông - Hà Nội', N'Hà Đông - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'06', N'TD02', N'CV05', N'PB05', N'Tầng 1', N'Nguyễn Hương Linh', CAST(N'1980-03-10' AS Date), N'Hương Khê - Hà Tĩnh', N'Nữ', N'187395421', N'12/12', N'0985126853', N'nguyenhuonglinh@gmail.com', N'Đống Đa - Hà Nội', N'Hương Khê - Hà Tĩnh')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'07', N'TD04', N'CV02', N'PB03', N'Tầng 3', N'Nguyễn Đức Anh', CAST(N'1972-02-13' AS Date), N'Đông Hưng - Thái Bình', N'Nam', N'187598246', N'12/12', N'0985426525', N'nguyendinhhuy@gmail.com', N'Hai Bà Trưng - Hà Nội', N'Bắc Từ Liêm - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'08', N'TD02', N'CV04', N'PB02', N'Tầng 4', N'Lê Đức An', CAST(N'1990-05-05' AS Date), N'Ba Đình - Hà Nội', N'Nam', N'185845962', N'12/12', N'0985745268', N'leducbinh@gmail.com', N'Bắc Từ Liêm - Hà Nội', N'Ba Đình - Hà Nội')
GO
INSERT [dbo].[DanhMucNhanVien] ([MaNhanVien], [MaHinhThucTuyenDung], [MaChucVu], [MaPhongBan], [NoiLamViec], [HoTen], [NgaySinh], [QueQuan], [GioiTinh], [SoCMND], [TrinhDo], [SDT], [Email], [NoiO], [NoiSinh]) VALUES (N'09', N'TD02', N'CV05', N'PB02', N'Tầng 4', N'Lê Đức Bình', CAST(N'1990-05-05' AS Date), N'Phủ Lý - Hà Nam', N'Nam', N'185845962', N'12/12', N'0985745268', N'leducbinh@gmail.com', N'Nam Từ Liêm - Hà Nội', N'Ba Đình - Hà Nội')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'01', N'KTKL02', CAST(N'2020-05-06' AS Date), N'NULL')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'04', N'KTKL01', CAST(N'2019-10-07' AS Date), N'NULL')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'01', N'KTKL05', CAST(N'2020-08-03' AS Date), N'NULL')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'02', N'KTKL03', CAST(N'2019-09-04' AS Date), N'NULL')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'03', N'KTKL04', CAST(N'2020-05-07' AS Date), N'NULL')
GO
INSERT [dbo].[DanhSachKTKL] ([MaNhanVien], [MaKTKL], [Ngay], [GhiChu]) VALUES (N'04', N'KTKL04', CAST(N'2020-06-20' AS Date), N'NULL')
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD01', N'01', 3000000, CAST(N'2019-05-07' AS Date), CAST(N'2024-05-29' AS Date))
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD02', N'02', 8000000, CAST(N'2020-01-06' AS Date), CAST(N'2025-02-06' AS Date))
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD03', N'03', 10000000, CAST(N'2019-12-06' AS Date), CAST(N'2024-02-17' AS Date))
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD04', N'04', 7000000, CAST(N'2020-01-10' AS Date), CAST(N'2025-02-10' AS Date))
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD05', N'05', 8000000, CAST(N'2020-03-06' AS Date), CAST(N'2025-04-06' AS Date))
GO
INSERT [dbo].[HopDong] ([MaHD], [MaNhanVien], [LuongHD], [NgayBatDau], [NgayKetThuc]) VALUES (N'HD06', N'06', 5000000, CAST(N'2019-12-04' AS Date), CAST(N'2020-08-01' AS Date))
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L01', N'01', 5335000, 26, N'5/2018', 665000)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L02', N'02', 8518846, 25, N'4/2017', 135000)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L03', N'03', 10776923, 24, N'4/2017', 300000)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L04', N'04', 7781500, 26, N'5/2019', 118500)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L05', N'05', 8865000, 26, N'3/2020', 135000)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L06', N'06', 4782884, 23, N'5/2019', 82500)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L07', N'04', 7781500, 26, N'5/2019', 118500)
GO
INSERT [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES (N'L08', N'06', 4782884, 23, N'5/2019', 82500)
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES (N'PB01', N'Phòng kỹ thuật', N'0658523365')
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES (N'PB02', N'Phòng tài chính', N'0255448462')
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES (N'PB03', N'Phòng đào tạo', N'0958245856')
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES (N'PB04', N'Phòng quản lý', N'0859245325')
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES (N'PB05', N'Phòng thanh tra', N'0752692545')
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL01', N'Thưởng thâm niên', 1000000)
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL02', N'Thưởng tháng lương', 600000)
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL03', N'Thưởng lễ', 200000)
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL04', N'Thưởng thâm niên', 1000000)
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL05', N'Phạt đi muộn', 100000)
GO
INSERT [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES (N'KTKL06', N'Phạt vi phạm quy định', 500000)
GO
INSERT [dbo].[TaiKhoan] ([Ten], [MK]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[TaiKhoan] ([Ten], [MK]) VALUES (N'[MaNV]', N'[SDT]')
GO

ALTER TABLE [dbo].[BaoHiemNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__BaoHiemNh__MaBao__35BCFE0A] FOREIGN KEY([MaBaoHiem])
REFERENCES [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BaoHiemNhanVien] CHECK CONSTRAINT [FK__BaoHiemNh__MaBao__35BCFE0A]
GO
ALTER TABLE [dbo].[BaoHiemNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__BaoHiemNh__MaNha__36B12243] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[DanhMucNhanVien] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BaoHiemNhanVien] CHECK CONSTRAINT [FK__BaoHiemNh__MaNha__36B12243]
GO
ALTER TABLE [dbo].[DanhMucNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__DanhMucNh__MaChu__37A5467C] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[DanhMucChucVu] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhMucNhanVien] CHECK CONSTRAINT [FK__DanhMucNh__MaChu__37A5467C]
GO
ALTER TABLE [dbo].[DanhMucNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__DanhMucNh__MaHin__38996AB5] FOREIGN KEY([MaHinhThucTuyenDung])
REFERENCES [dbo].[DANHMUCHINHTHUCTUYENDUNG] ([MaHinhThucTuyenDung])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhMucNhanVien] CHECK CONSTRAINT [FK__DanhMucNh__MaHin__38996AB5]
GO
ALTER TABLE [dbo].[DanhMucNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__DanhMucNh__MaPho__398D8EEE] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhMucNhanVien] CHECK CONSTRAINT [FK__DanhMucNh__MaPho__398D8EEE]
GO
ALTER TABLE [dbo].[DanhSachKTKL]  WITH CHECK ADD  CONSTRAINT [FK__DanhSachK__MaKTK__3A81B327] FOREIGN KEY([MaKTKL])
REFERENCES [dbo].[QuyDinhKTKL] ([MaKTKL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhSachKTKL] CHECK CONSTRAINT [FK__DanhSachK__MaKTK__3A81B327]
GO
ALTER TABLE [dbo].[DanhSachKTKL]  WITH CHECK ADD  CONSTRAINT [FK__DanhSachK__MaNha__3B75D760] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[DanhMucNhanVien] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DanhSachKTKL] CHECK CONSTRAINT [FK__DanhSachK__MaNha__3B75D760]
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD  CONSTRAINT [FK__HopDong__MaNhanV__3C69FB99] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[DanhMucNhanVien] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HopDong] CHECK CONSTRAINT [FK__HopDong__MaNhanV__3C69FB99]
GO
ALTER TABLE [dbo].[LuongNhanVien]  WITH CHECK ADD  CONSTRAINT [FK__LuongNhan__MaNha__3D5E1FD2] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[DanhMucNhanVien] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LuongNhanVien] CHECK CONSTRAINT [FK__LuongNhan__MaNha__3D5E1FD2]
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BaoCaoKTKL] 
as
begin
	select DanhMucNhanVien.MaNhanVien, HoTen, NgaySinh, 
	DanhMucNhanVien.MaPhongBan, PhongBan.Ten 'TenPhongBan', DanhMucNhanVien.MaChucVu, DanhMucChucVu.Ten 'ChucVu', 
	count (danhsachktkl.MaKTKL) 'SoHinhThucKTKL'
	from DanhMucNhanVien join DanhMucChucVu on DanhMucNhanVien.MaChucVu = DanhMucChucVu.MaChucVu join PhongBan on DanhMucNhanVien.MaPhongBan = PhongBan.MaPhongBan
	join DanhSachKTKL on DanhMucNhanVien.MaNhanVien = DanhSachKTKL.MaNhanVien
	join QuyDinhKTKL on DanhSachKTKL.MaKTKL = QuyDinhKTKL.MaKTKL
	group by DanhMucNhanVien.MaNhanVien, HoTen, NgaySinh, 
	DanhMucNhanVien.MaPhongBan, PhongBan.Ten, DanhMucNhanVien.MaChucVu, DanhMucChucVu.Ten
end
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BaoCaoLuong]
as
begin
	select DanhMucNhanVien.MaNhanVien, HoTen, NgaySinh, 
	DanhMucNhanVien.MaPhongBan, PhongBan.Ten 'TenPhongBan', DanhMucNhanVien.MaChucVu, DanhMucChucVu.Ten 'ChucVu', 
	LuongNhanVien.MaLuong, LuongHD, SoNgayCong, ThangNam
	from DanhMucNhanVien join DanhMucChucVu on DanhMucNhanVien.MaChucVu = DanhMucChucVu.MaChucVu join PhongBan on DanhMucNhanVien.MaPhongBan = PhongBan.MaPhongBan
	join LuongNhanVien on DanhMucNhanVien.MaNhanVien = LuongNhanVien.MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[BaoCaoNhanSu]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BaoCaoNhanSu] 
as
begin
	select PhongBan.MaPhongBan, PhongBan.Ten 'TenPhongBan',count(danhmucnhanvien.MaNhanVien) 'SoNhanVien'
	from DanhMucNhanVien join PhongBan on DanhMucNhanVien.MaPhongBan = PhongBan.MaPhongBan
	group by phongban.MaPhongBan, PhongBan.Ten
end
GO
/****** Object:  StoredProcedure [dbo].[BaoHiemDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BaoHiemDK]
(
	@MaBH varchar(20)
)
AS
BEGIN
	SELECT *FROM DANHMUCBAOHIEM WHERE MaBaoHiem = @MaBH
END
GO
/****** Object:  StoredProcedure [dbo].[BHNhanVien]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BHNhanVien]
AS
BEGIN
SELECT Ten, HoTen, NgayBatDau, NgayHetHan, SoTienDongMotThang FROM BaoHiemNhanVien, DANHMUCBAOHIEM, DanhMucNhanVien
Where BaoHiemNhanVien.MaBaoHiem = DANHMUCBAOHIEM.MaBaoHiem and BaoHiemNhanVien.MaNhanVien = DanhMucNhanVien.MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[ChucVuDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ChucVuDK](@MaCV varchar(20))
AS
BEGIN
	SELECT *FROM DanhMucChucVu WHERE MaChucVu = @MaCV
END
GO
/****** Object:  StoredProcedure [dbo].[dangnhap1]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[dangnhap1] as 
begin select MaNhanVien,sdt
from DanhMucNhanVien 
end
GO
/****** Object:  StoredProcedure [dbo].[DangNhapDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangNhapDK](
@Ten varchar(10),
@MK varchar(10)
)
AS
BEGIN
	SELECT *FROM TaiKhoan WHERE Ten = @Ten AND MK = @MK
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachBH]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachBH]
AS
BEGIN
SELECT *FROM DANHMUCBAOHIEM
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachBHNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachBHNV](
@MaBH varchar(20),
@MaNV varchar(20))
AS
BEGIN
	SELECT *FROM BaoHiemNhanVien WHERE MaBaoHiem = @MaBH AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachHD]
AS
BEGIN
SELECT *FROM HopDong
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKhenThuongKiLuat]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachKhenThuongKiLuat]
AS
BEGIN
SELECT *FROM DanhSachKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKTKLDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachKTKLDK](
@MaKTKL varchar(20),
@MaNV varchar(20))
AS
BEGIN
	SELECT *FROM DanhSachKTKL WHERE MaKTKL = @MaKTKL AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachLuong]
AS
BEGIN
SELECT MaLuong, MaNhanVien,LuongHD,SoNgayCong, ThangNam  FROM LuongNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMaBH]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhSachMaBH]
AS
begin
	select MaBaoHiem FROM DANHMUCBAOHIEM
end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMaCV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DanhSachMaCV]
AS
BEGIN
	SELECT MaChucVu FROM DanhMucChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMaPB]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhSachMaPB]
AS
begin
	select MaPhongBan FROM PhongBan
end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMaTD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DanhSachMaTD]
AS
begin
	select MaHinhThucTuyenDung FROM DANHMUCHINHTHUCTUYENDUNG
end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachNV]
AS
BEGIN
SELECT *FROM DanhMucNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[DSChucVu]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSChucVu]
AS
BEGIN
SELECT *FROM DanhMucChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[DsHopDongConHan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DsHopDongConHan]
AS
BEGIN
	SELECT *FROM HopDong WHERE NgayKetThuc > GETDATE()
END
GO
/****** Object:  StoredProcedure [dbo].[DsHopDongHetHan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DsHopDongHetHan]
AS
BEGIN
	SELECT *FROM HopDong WHERE NgayKetThuc < GETDATE()
END
GO
/****** Object:  StoredProcedure [dbo].[DSLuongTheoThang]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSLuongTheoThang]
(@Thang varchar(20))
AS
BEGIN
	SELECT MaLuong, MaNhanVien, LuongHD, SoNgayCong, ThangNam FROM LuongNhanVien WHERE ThangNam = @Thang
END
GO
/****** Object:  StoredProcedure [dbo].[DSPhongBan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSPhongBan]
AS
BEGIN
SELECT *FROM PhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[HopDongDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HopDongDK](
@MaHD varchar(20))
AS
BEGIN
	SELECT *FROM HopDong WHERE MaHD = @MaHD
END
GO
/****** Object:  StoredProcedure [dbo].[LoadLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadLuong]
AS
BEGIN
DECLARE tro_Luong CURSOR FORWARD_ONLY
FOR SELECT MaLuong, MaNhanVien
FROM LuongNhanVien

OPEN tro_Luong
DECLARE @MaLuong varchar(20),@MaNV varchar(20)
FETCH NEXT FROM tro_Luong INTO @MaLuong,@MaNV
WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE @TienBH int = (SELECT SUM(SoTienDongMoTThang) FROM BaoHiemNhanVien WHERE MaNhanVien = @MaNV)
	UPDATE LuongNhanVien SET TienBH = @TienBH WHERE MaNhanVien = @MaNV
	DECLARE @LuongCB FLOAT = (SELECT LuongHD FROM HopDong WHERE MaNhanVien = @MaNV)
	
	DECLARE @MaCV VARCHAR(20) = (SELECT MaChucVu FROM DanhMucNhanVien WHERE MaNhanVien = @MaNV)
	DECLARE @PhuCap int = (SELECT PhuCap FROM DanhMucChucVu WHERE MaChucVu = @MaCV)
	DECLARE @SoNgayCong int = (SELECT SoNgayCong FROM LuongNhanVien WHERE MaNhanVien = @MaNV AND MaLuong = @MaLuong)
	UPDATE LuongNhanVien SET LuongHD = ((@LuongCB + @PhuCap)/26)*@SoNgayCong - @TienBH WHERE MaNhanVien = @MaNV AND MaLuong = @MaLuong
FETCH NEXT FROM tro_Luong INTO @MaLuong, @MaNV
END
CLOSE tro_Luong
DEALLOCATE tro_Luong
END
GO
/****** Object:  StoredProcedure [dbo].[LuongDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LuongDK](
@MaLuong varchar(20))
AS
BEGIN
	SELECT *FROM LuongNhanVien WHERE MaLuong = @MaLuong
END
GO
/****** Object:  StoredProcedure [dbo].[NhanVienChuaCoHD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NhanVienChuaCoHD]
AS
BEGIN
	SELECT MaNhanVien From DanhMucNhanVien EXCEPT SELECT MaNhanVien From HopDong
END
GO
/****** Object:  StoredProcedure [dbo].[NhanVienDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NhanVienDK](
@MaNV varchar(20))
AS
BEGIN
	SELECT *FROM DanhMucNhanVien WHERE MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[PhongBanDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PhongBanDK]
(
	@MaPB varchar(20)
)
AS
BEGIN
	SELECT *FROM PhongBan WHERE MaPhongBan = @MaPB
END
GO
/****** Object:  StoredProcedure [dbo].[QuyDinhKTKLDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[QuyDinhKTKLDK](@MaKTKL varchar(20))
AS
BEGIN
	SELECT *FROM QuyDinhKTKL WHERE MaKTKL = @MaKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[QuyetDinhKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[QuyetDinhKTKL]
AS
BEGIN
SELECT *FROM QuyDinhKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[SuaBaoHiemNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaBaoHiemNV](
@MaBH varchar(20),
@MaNV varchar(20),
@NgayBatDau Date,
@NgayKetThuc Date,
@SoTien int)
AS
BEGIN
	UPDATE BaoHiemNhanVien SET NgayBatDau = @NgayBatDau,@NgayKetThuc = @NgayKetThuc, SoTienDongMotThang = @SoTien 
	WHERE MaBaoHiem = @MaBH AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaBH]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaBH]
(@MaBH varchar(20),
@Ten nvarchar(40),
@TiLeBH float
)
AS
BEGIN
	UPDATE DANHMUCBAOHIEM SET Ten = @Ten, TiLeBH = @TiLeBH WHERE MaBaoHiem = @MaBH
END
GO
/****** Object:  StoredProcedure [dbo].[SUABH_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SUABH_ADMIN]
(
  @MaBaoHiem varchar(20),
  @Ten nvarchar(50),
  @TiLeBH float
)as
begin
 UPDATE DANHMUCBAOHIEM SET Ten = @Ten, TiLeBH = @TiLeBH
						WHERE MaBaoHiem = @MaBaoHiem
end
GO
/****** Object:  StoredProcedure [dbo].[SuaCV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaCV]
(@MaChucVu varchar(20),
@Ten nvarchar(40),
@PhuCap int
)
AS
BEGIN
	UPDATE DanhMucChucVu SET Ten = @Ten, PhuCap = @PhuCap WHERE MaChucVu = @MaChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[SUACV_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SUACV_ADMIN]
(
  @MaChucVu varchar(20),
  @Ten nvarchar(30),
  @PhuCap int
)as
begin
 UPDATE DanhMucChucVu SET MaChucVu = @MaChucVu , Ten = @Ten, PhuCap = @PhuCap
						WHERE MaChucVu = @MaChucVu
end
GO
/****** Object:  StoredProcedure [dbo].[SuaDanhSachKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDanhSachKTKL](
@MaKTKL varchar(20),
@MaNV varchar(20),
@Ngay Date,
@GhiChu nvarchar(50))
AS
BEGIN
	UPDATE DanhSachKTKL SET Ngay = @Ngay,GhiChu = @GhiChu WHERE MaKTKL = @MaKTKL AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaHD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaHD](
@MaHD varchar(20),
@MaNV varchar(20),
@Luong int,
@NgayBatDau date,
@NgayKetThuc date)
AS
BEGIN
	UPDATE HopDong SET MaNhanVien = @MaNV,LuongHD = @Luong, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc 
	WHERE MaHD = @MaHD
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKTKL](
@MaKTKL varchar(20),
@Ten nvarchar(50),
@SoTien int)
AS
BEGIN
	UPDATE QuyDinhKTKL SET Ten = @Ten,SoTien = SoTien WHERE MaKTKL = @MaKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[SUAKTKL_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SUAKTKL_ADMIN]
(
  @MaKTKL varchar(20),
  @Ten nvarchar(50),
  @SoTien int
)as
begin
 UPDATE QuyDinhKTKL SET MaKTKL = @MaKTKL , Ten = @Ten, SoTien = @SoTien
						WHERE MaKTKL = @MaKTKL
end
GO
/****** Object:  StoredProcedure [dbo].[SuaLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLuong](
@MaLuong varchar(20),
@MaNV varchar(20),
@Luong int,
@SoNgayCong int,
@ThangNam varchar(10))
AS
BEGIN
	UPDATE LuongNhanVien SET MaNhanVien = @MaNV,LuongHD = @Luong, SoNgayCong = @SoNgayCong, ThangNam = @ThangNam
	WHERE MaLuong = @MaLuong
END
GO
/****** Object:  StoredProcedure [dbo].[SUALUONG_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[SUALUONG_ADMIN] 
 (
  @Maluong varchar(20),
  @Manhanvien varchar (20),
  @LuongHD int,
  @Songaycong int,
  @Thangnam varchar (10),
  @TienBH int 
 ) as
 begin 
  UPDATE LuongNhanVien SET MaLuong = @Maluong , MaNhanVien = @Manhanvien,LuongHD = @LuongHD , SoNgayCong = @Songaycong,
                           ThangNam = @Thangnam , TienBH = @TienBH
						WHERE MaLuong = @Maluong
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNV](
@MaNV varchar(20),
@MaTD varchar(20),
@MaCV varchar(20),
@MaPB varchar(20),
@NoiLV nvarchar(40),
@HoTen nvarchar(40),
@NgaySinh Date,
@QueQuan nvarchar(40),
@GioiTinh nvarchar(4),
@CMND varchar(40),
@TrinhDo nvarchar(40),
@SDT varchar(40),
@Email nvarchar(40),
@NoiO nvarchar(40),
@NoiSinh nvarchar(40)
)
AS
BEGIN
	UPDATE DanhMucNhanVien SET MaHinhThucTuyenDung = @MaTD,MaChucVu = @MaCV, MaPhongBan = @MaPB, 
	NoiLamViec = @NoiLV, HoTen = @HoTen, QueQuan = @QueQuan,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh, SoCMND = @CMND,TrinhDo = @TrinhDo,
	SDT = @SDT, Email = @Email, NoiO = @NoiO, NoiSinh = @NoiSinh
	WHERE MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPB]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPB]
(@MaPhongBan varchar(20),
@Ten nvarchar(50),
@DienThoai varchar(15)
)
AS
BEGIN
	UPDATE PhongBan SET Ten = @Ten, DienThoai = @DienThoai WHERE MaPhongBan = @MaPhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[SUAPB_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SUAPB_ADMIN]
(
  @MaPhongBan varchar(20),
  @Ten nvarchar(50),
  @DienThoai int
)as
begin
 UPDATE PhongBan SET MaPhongBan = @MaPhongBan , Ten = @Ten, DienThoai = @DienThoai
						WHERE MaPhongBan = @MaPhongBan
end
GO
/****** Object:  StoredProcedure [dbo].[SuaTD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaTD](
@MaTD varchar(20),
@Ten nvarchar(40))
AS
BEGIN
	UPDATE DANHMUCHINHTHUCTUYENDUNG SET Ten = @Ten WHERE  MaHinhThucTuyenDung = @MaTD
END
GO
/****** Object:  StoredProcedure [dbo].[ThangNam]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThangNam]
AS
BEGIN
	SELECT DISTINCT ThangNam FROM LuongNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[THEM_DM_PB_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Danh mục phòng ban*/
CREATE PROC [dbo].[THEM_DM_PB_ADMIN]
(
  @MaPhongBan varchar(20),
  @Ten nvarchar(50),
  @DienThoai int
)as
begin
 INSERT INTO  [dbo].[PhongBan] ([MaPhongBan], [Ten], [DienThoai]) VALUES ( @MaPhongBan, @Ten, @DienThoai )
 end
GO
/****** Object:  StoredProcedure [dbo].[ThemBaoHiemNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemBaoHiemNV](
@MaBH varchar(20),
@MaNV varchar(20),
@NgayBatDau Date,
@NgayKetThuc Date,
@SoTien int)
AS
BEGIN
	INSERT INTO BaoHiemNhanVien VALUES(@MaNV,@MaBH,@NgayBatDau,@NgayKetThuc,@SoTien)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemBH]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemBH]
(
@MaBH varchar(20),
@Ten nvarchar(50),
@TiLeBH float
)
AS
BEGIN
	Insert Into DANHMUCBAOHIEM(MaBaoHiem,Ten,TiLeBH) Values(@MaBH,@Ten,@TiLeBH)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMBH_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Danh mục bảo hiểm*/

CREATE PROC [dbo].[THEMBH_ADMIN]
(
  @MaBaoHiem varchar(20),
  @Ten nvarchar(40),
  @TiLeBH float
)as
begin
 INSERT INTO  [dbo].[DANHMUCBAOHIEM] ([MaBaoHiem], [Ten], [TiLeBH]) VALUES ( @MaBaoHiem, @Ten, @TiLeBH )
 end
GO
/****** Object:  StoredProcedure [dbo].[ThemCV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemCV]
(
@MaChucVu varchar(20),
@Ten nvarchar(40),
@PhuCap int
)
AS
BEGIN
	Insert Into DanhMucChucVu(MaChucVu,Ten,PhuCap) Values(@MaChucVu,@Ten,@PhuCap)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMCV_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* DanhMucChucVu */
CREATE PROC [dbo].[THEMCV_ADMIN]
(
  @MaChucVu varchar(20),
  @Ten nvarchar(40),
  @PhuCap int
)as
begin
 INSERT INTO  [dbo].[DanhMucChucVu] ([MaChucVu], [Ten], [PhuCap]) VALUES ( @MaChucVu, @Ten, @PhuCap )
 end
GO
/****** Object:  StoredProcedure [dbo].[ThemDanhSachKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemDanhSachKTKL](
@MaKTKL varchar(20),
@MaNV varchar(20),
@Ngay Date,
@GhiChu nvarchar(50))
AS
BEGIN
	INSERT INTO DanhSachKTKL VALUES(@MaNV,@MaKTKL,@Ngay,@GhiChu)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHD](
@MaHD varchar(20),
@MaNV varchar(20),
@Luong int,
@NgayBatDau date,
@NgayKetThuc date)
AS
BEGIN
	INSERT INTO HopDong VALUES(@MaHD,@MaNV,@Luong,@NgayBatDau,@NgayKetThuc)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKTKL](
@MaKTKL varchar(20),
@Ten nvarchar(50),
@SoTien int)
AS
BEGIN
	INSERT INTO QuyDinhKTKL VALUES(@MaKTKL,@Ten,@SoTien)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMKTKL_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*Danh mục KTKL*/

CREATE PROC [dbo].[THEMKTKL_ADMIN]
(
  @MaKTKL varchar(20),
  @Ten nvarchar(40),
  @SoTien int
)as
begin
 INSERT INTO  [dbo].[QuyDinhKTKL] ([MaKTKL], [Ten], [SoTien]) VALUES ( @MaKTKL, @Ten, @SoTien )
 end
GO
/****** Object:  StoredProcedure [dbo].[ThemLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLuong](
@MaLuong varchar(20),
@MaNV varchar(20),
@Luong int,
@SoNgayCong int,
@ThangNam varchar(10))
AS
BEGIN
	INSERT INTO LuongNhanVien(MaLuong,MaNhanVien,LuongHD,SoNgayCong,ThangNam) VALUES(@MaLuong,@MaNV,@Luong,@SoNgayCong,@ThangNam)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMLUONG_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[THEMLUONG_ADMIN] 
 (
  @Maluong varchar(20),
  @Manhanvien varchar (20),
  @LuongHD int,
  @Songaycong int,
  @Thangnam varchar (10),
  @TienBH int 
 ) as
 begin 
 INSERT INTO  [dbo].[LuongNhanVien] ([MaLuong], [MaNhanVien], [LuongHD], [SoNgayCong], [ThangNam], [TienBH]) VALUES ( @Maluong,@Manhanvien, @LuongHD, @Songaycong,  @Thangnam, @TienBH )
 end
GO
/****** Object:  StoredProcedure [dbo].[ThemNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNV](
@MaNV varchar(20),
@MaTD varchar(20),
@MaCV varchar(20),
@MaPB varchar(20),
@NoiLV nvarchar(40),
@HoTen nvarchar(40),
@NgaySinh Date,
@QueQuan nvarchar(40),
@GioiTinh varchar(4),
@CMND varchar(40),
@TrinhDo nvarchar(40),
@SDT varchar(40),
@Email nvarchar(40),
@NoiO nvarchar(40),
@NoiSinh nvarchar(40)
)
AS
BEGIN
	INSERT INTO DanhMucNhanVien VALUES(@MaNV,@MaTD,@MaCV,@MaPB,@NoiLV,@HoTen,@NgaySinh,@QueQuan,@GioiTinh,@CMND,@TrinhDo,@SDT,@Email,@NoiO,@NoiSinh)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemPB]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPB]
(
@MaPhongBan varchar(20),
@Ten nvarchar(50),
@DienThoai varchar(15)
)
AS
BEGIN
	Insert Into PhongBan(MaPhongBan,Ten,DienThoai) Values(@MaPhongBan,@Ten,@DienThoai)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemTD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTD](
@MaTD varchar(20),
@Ten nvarchar(40))
AS
BEGIN
	INSERT INTO DANHMUCHINHTHUCTUYENDUNG VALUES(@MaTD,@Ten)
END
GO
/****** Object:  StoredProcedure [dbo].[TiLeBaoHiem]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TiLeBaoHiem]
as
begin
	declare @Tong float
	select @Tong = convert(float, count(manhanvien))
	from BaoHiemNhanVien
	select ten, round(count(BaoHiemNhanVien.manhanvien)/@Tong*100,2) as TiLe
	from danhmucnhanvien inner join BaoHiemNhanVien on DanhMucNhanVien.MaNhanVien = BaoHiemNhanVien.MaNhanVien
	join DANHMUCBAOHIEM on BaoHiemNhanVien.MaBaoHiem = DANHMUCBAOHIEM.MaBaoHiem
	group by ten
	order by round(count(BaoHiemNhanVien.manhanvien)/@Tong*100,2) desc
	end
GO
/****** Object:  StoredProcedure [dbo].[TiLeChucVu]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TiLeChucVu]
as
begin
	declare @Tong float
	select @Tong = convert(float, count(manhanvien))
	from DanhMucNhanVien
	select ten, round(count(DanhMucNhanVien.manhanvien)/@Tong*100,2) as TiLe
	from danhmucnhanvien inner join DanhMucChucVu on DanhMucNhanVien.MaChucVu = DanhMucChucVu.MaChucVu
	group by ten
	order by round(count(DanhMucNhanVien.manhanvien)/@Tong*100,2) desc
	end
GO
/****** Object:  StoredProcedure [dbo].[TiLePhongBan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TiLePhongBan]
as
begin
	declare @Tong float
	select @Tong = convert(float, count(manhanvien))
	from DanhMucNhanVien
	select ten, round(count(DanhMucNhanVien.manhanvien)/@Tong*100,2) as TiLe
	from danhmucnhanvien inner join PhongBan on DanhMucNhanVien.MaPhongBan = PhongBan.MaPhongBan
	group by ten
	order by round(count(DanhMucNhanVien.manhanvien)/@Tong*100,2) desc
	end
GO
/****** Object:  StoredProcedure [dbo].[TiLeTrinhDoNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TiLeTrinhDoNV]
as
begin
	declare @Tong float
	select @Tong = convert(float, count(manhanvien))
	from danhmucnhanvien
	select trinhdo, round(count(manhanvien)/@Tong*100,2) as TiLe
	from danhmucnhanvien
	group by trinhdo
	order by round(count(manhanvien)/@Tong*100,2) desc
	end
GO
/****** Object:  StoredProcedure [dbo].[TIMLUONG_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TIMLUONG_ADMIN](@THANG NVARCHAR(100))
AS
BEGIN
	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@THANG)+'%'

	SELECT * FROM LuongNhanVien
	WHERE ThangNam LIKE @pattern
END
GO
/****** Object:  StoredProcedure [dbo].[TIMLUONG_NV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TIMLUONG_NV] (@Manhanvien varchar(20),@thang varchar(20)) as
begin 
	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@THANG)+'%'
select l.MaLuong,l.MaNhanVien,nv.HoTen,l.LuongHD,l.SoNgayCong,l.ThangNam,l.TienBH from DanhMucNhanVien nv, LuongNhanVien l 
where l.MaNhanVien = nv.MaNhanVien and l.MaNhanVien = @Manhanvien and l.ThangNam like @pattern
end
 drop proc TIMLUONG_NV
GO
/****** Object:  StoredProcedure [dbo].[TIMNHANVIEN_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TIMNHANVIEN_ADMIN](@text NVARCHAR(100))
AS
BEGIN
	DECLARE @pattern NVARCHAR(100)
	SET @pattern = '%'+TRIM(@text)+'%'

	SELECT * FROM DanhMucNhanVien
	WHERE MaNhanVien LIKE @pattern OR MaHinhThucTuyenDung LIKE @pattern OR MaChucVu LIKE @pattern OR MaPhongBan LIKE @pattern OR 
			NoiLamViec LIKE @pattern OR HoTen LIKE @pattern OR NgaySinh LIKE @pattern OR QueQuan LIKE @pattern OR GioiTinh LIKE @pattern
			OR SoCMND LIKE @pattern OR TrinhDo LIKE @pattern OR SDT LIKE @pattern OR Email LIKE @pattern OR NoiO LIKE @pattern OR  NoiSinh LIKE @pattern 
END
GO
/****** Object:  StoredProcedure [dbo].[TKBaoHiem]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKBaoHiem]
as
begin
	select DanhMucNhanVien.MaNhanVien, MaHinhThucTuyenDung, MaChucVu, MaPhongBan, NoiLamViec, HoTen, NgaySinh, QueQuan, GioiTinh, SoCMND, TrinhDo, sdt, Email, NoiO, NoiSinh, BaoHiemNhanVien.MaBaoHiem, ten 
	from danhmucnhanvien inner join BaoHiemNhanVien on DanhMucNhanVien.MaNhanVien = BaoHiemNhanVien.MaNhanVien
	join DANHMUCBAOHIEM on BaoHiemNhanVien.MaBaoHiem = DANHMUCBAOHIEM.MaBaoHiem
	order by ten
end
GO
/****** Object:  StoredProcedure [dbo].[TKChucVu]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKChucVu]
as
begin
	select DanhMucNhanVien.MaNhanVien, MaHinhThucTuyenDung, danhmucnhanvien.MaChucVu, MaPhongBan, NoiLamViec, HoTen, NgaySinh, QueQuan, GioiTinh, SoCMND, TrinhDo, sdt, Email, NoiO, NoiSinh, ten
	from danhmucnhanvien inner join DanhMucChucVu on DanhMucNhanVien.MaChucVu = DanhMucChucVu.MaChucVu
	order by ten
end
GO
/****** Object:  StoredProcedure [dbo].[TKKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKKTKL]
as
begin
	select DanhSachKTKL.MaNhanVien, MaHinhThucTuyenDung, danhmucnhanvien.MaChucVu, danhmucnhanvien.MaPhongBan, NoiLamViec, HoTen, NgaySinh, QueQuan, GioiTinh, SoCMND, TrinhDo, sdt, Email, NoiO, NoiSinh, ten
	from danhmucnhanvien inner join DanhSachKTKL on DanhMucNhanVien.MaNhanVien = DanhSachKTKL.MaNhanVien join QuyDinhKTKL on DanhSachKTKL.MaKTKL = QuyDinhKTKL.MaKTKL
	order by ten
end
GO
/****** Object:  StoredProcedure [dbo].[TKPhongBan]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKPhongBan]
as
begin
	select DanhMucNhanVien.MaNhanVien, MaHinhThucTuyenDung, danhmucnhanvien.MaChucVu, danhmucnhanvien.MaPhongBan, NoiLamViec, HoTen, NgaySinh, QueQuan, GioiTinh, SoCMND, TrinhDo, sdt, Email, NoiO, NoiSinh, ten
	from danhmucnhanvien inner join PhongBan on DanhMucNhanVien.MaPhongBan = PhongBan.MaPhongBan
	order by Ten 
end
GO
/****** Object:  StoredProcedure [dbo].[TKTrinhDo]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKTrinhDo]
as
begin
	select * from danhmucnhanvien
	order by TrinhDo
end
GO
/****** Object:  StoredProcedure [dbo].[TongLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongLuong]
AS
BEGIN
SELECT Sum(LuongHD) FROM LuongNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[TongLuongTheoThang]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongLuongTheoThang]
(@Thang varchar(20))
AS
BEGIN
SELECT Sum(LuongHD) FROM LuongNhanVien Where ThangNam = @Thang 
END
GO
/****** Object:  StoredProcedure [dbo].[TuyenDung]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuyenDung]
AS
BEGIN
SELECT *FROM DANHMUCHINHTHUCTUYENDUNG
END
GO
/****** Object:  StoredProcedure [dbo].[TuyenDungDK]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuyenDungDK](@MaTD varchar(20))
AS
BEGIN
	SELECT *FROM DANHMUCHINHTHUCTUYENDUNG WHERE MaHinhThucTuyenDung = @MaTD
END
GO
/****** Object:  StoredProcedure [dbo].[TyLeKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TyLeKTKL]
as
begin
	declare @Tong float
	select @Tong = convert(float, count(manhanvien))
	from DanhSachKTKL
	select ten, round(count(DanhSachKTKL.manhanvien)/@Tong*100,2) as TiLe
	from danhmucnhanvien inner join danhsachktkl on danhmucnhanvien.manhanvien = danhsachktkl.manhanvien 
	inner join quydinhktkl on danhsachktkl.maktkl = quydinhktkl.maktkl
	group by ten
	order by round(count(DanhSachKTKL.manhanvien)/@Tong*100,2) desc
	end
GO
/****** Object:  StoredProcedure [dbo].[XEM_DM_BH_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* Xem danh mục bảo hiểm */
CREATE PROC [dbo].[XEM_DM_BH_ADMIN] AS
 BEGIN 
 SELECT * FROM DANHMUCBAOHIEM
 END 
GO
/****** Object:  StoredProcedure [dbo].[XEM_DM_CV_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Proc danh mục admin */

/* Xem danh mục chức vụ*/

CREATE PROC [dbo].[XEM_DM_CV_ADMIN] AS
 BEGIN 
 SELECT * FROM DanhMucChucVu
 END 
GO
/****** Object:  StoredProcedure [dbo].[XEM_DM_KTKL_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/* Xem danh mục Khen thưởng kỷ luật */
CREATE PROC [dbo].[XEM_DM_KTKL_ADMIN] AS
 BEGIN 
 SELECT * FROM QuyDinhKTKL
 END 
GO
/****** Object:  StoredProcedure [dbo].[XEMBH_NHANVIEN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[XEMBH_NHANVIEN] (@MaNhanVien varchar(20))
as
begin 
  select DANHMUCBAOHIEM.MaBaoHiem, DANHMUCBAOHIEM.Ten, DANHMUCBAOHIEM.TiLeBH
  from DANHMUCBAOHIEM, BaoHiemNhanVien
  where DANHMUCBAOHIEM.MaBaoHiem = BaoHiemNhanVien.MaBaoHiem
  and BaoHiemNhanVien.MaNhanVien = @MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[XEMCV_NHANVIEN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[XEMCV_NHANVIEN] (@MaNhanVien varchar(20))
as
begin 
  select DanhMucChucVu.MaChucVu, DanhMucChucVu.Ten, DanhMucChucVu.PhuCap
  from DanhMucChucVu, DanhMucNhanVien
  where DanhMucChucVu.MaChucVu = DanhMucNhanVien.MaChucVu
  and DanhMucNhanVien.MaNhanVien = @MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[XEMKTKL_NHANVIEN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[XEMKTKL_NHANVIEN] (@MaNhanVien varchar(20))
as
begin 
  select QuyDinhKTKL.MaKTKL, QuyDinhKTKL.Ten, QuyDinhKTKL.SoTien
  from QuyDinhKTKL, DanhSachKTKL
  where DanhSachKTKL.MaKTKL = QuyDinhKTKL.MaKTKL
  and DanhSachKTKL.MaNhanVien = @MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[XEMLUONG_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 /*proc xem lương của admin*/
 CREATE PROC [dbo].[XEMLUONG_ADMIN] AS
 BEGIN 
 SELECT * FROM LuongNhanVien
 END 
GO
/****** Object:  StoredProcedure [dbo].[XEMLUONG_NV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XEMLUONG_NV] (@Manhanvien varchar(20)) as
begin 
select l.MaLuong,l.MaNhanVien,nv.HoTen,l.LuongHD,l.SoNgayCong,l.ThangNam,l.TienBH from DanhMucNhanVien nv, LuongNhanVien l 
where l.MaNhanVien = nv.MaNhanVien and l.MaNhanVien = @Manhanvien
end
GO
/****** Object:  StoredProcedure [dbo].[XEMPB_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Xem danh mục phòng ban */
CREATE PROC [dbo].[XEMPB_ADMIN] AS
 BEGIN 
 SELECT * FROM PhongBan
 END 
GO
/****** Object:  StoredProcedure [dbo].[XEMPB_NHANVIEN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[XEMPB_NHANVIEN] (@MaNhanVien varchar(20))
as
begin 
  select PhongBan.MaPhongBan,PhongBan.Ten, PhongBan.DienThoai
  from PhongBan, DanhMucNhanVien
  where PhongBan.MaPhongBan = DanhMucNhanVien.MaPhongBan
  and DanhMucNhanVien.MaNhanVien = @MaNhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[XoaBaoHiemNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaBaoHiemNV](
@MaBH varchar(20),
@MaNV varchar(20)
)
AS
BEGIN
	DELETE FROM BaoHiemNhanVien WHERE MaBaoHiem = @MaBH AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[XoaBH]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaBH]
(
@MaBH varchar(20)
)
AS
BEGIN
	DELETE FROM DANHMUCBAOHIEM WHERE MaBaoHiem = @MaBH
END
GO
/****** Object:  StoredProcedure [dbo].[XOABH_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[XOABH_ADMIN] (@MaBaoHiem VARCHAR (20) )
AS
BEGIN 
DELETE DANHMUCBAOHIEM WHERE MaBaoHiem = @MaBaoHiem
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaCV]
(
@MaChucVu varchar(20)
)
AS
BEGIN
	DELETE FROM DanhMucChucVu WHERE MaChucVu = @MaChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[XOACV_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[XOACV_ADMIN] (@MaChucVu VARCHAR (20) )
AS
BEGIN 
DELETE DanhMucChucVu WHERE MaChucVu = @MaChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[XoaDanhSachKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDanhSachKTKL](
@MaKTKL varchar(20),
@MaNV varchar(20)
)
AS
BEGIN
	DELETE FROM DanhSachKTKL WHERE MaKTKL = @MaKTKL AND MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[XoaHD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHD](
@MaHD varchar(20)
)
AS
BEGIN
	DELETE FROM HopDong WHERE MaHD = @MaHD
END
GO
/****** Object:  StoredProcedure [dbo].[XoaKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaKTKL](
@MaKTKL varchar(20)
)
AS
BEGIN
	DELETE FROM QuyDinhKTKL WHERE MaKTKL = @MaKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[XOAKTKL_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[XOAKTKL_ADMIN] (@MaKTKL VARCHAR (20) )
AS
BEGIN 
DELETE QuyDinhKTKL WHERE MaKTKL = @MaKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[XoaLuong]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLuong](
@MaLuong varchar(20)
)
AS
BEGIN
	DELETE FROM LuongNhanVien WHERE MaLuong = @MaLuong
END
GO
/****** Object:  StoredProcedure [dbo].[XOALUONG_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*proc XÓA lương của admin*/
CREATE proc [dbo].[XOALUONG_ADMIN] (@MALUONG VARCHAR (20) )
AS
BEGIN 
DELETE LuongNhanVien WHERE MALUONG = @MALUONG
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaNV](
@MaNV varchar(20)
)
AS
BEGIN
	DELETE FROM DanhMucNhanVien WHERE MaNhanVien = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[XoaPB]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPB]
(
@MaPB varchar(20)
)
AS
BEGIN
	DELETE FROM PhongBan WHERE MaPhongBan = @MaPB
END
GO
/****** Object:  StoredProcedure [dbo].[XOAPB_ADMIN]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[XOAPB_ADMIN] (@MaPhongBan VARCHAR (20) )
AS
BEGIN 
DELETE PhongBan WHERE MaPhongBan = @MaPhongBan
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTD]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaTD](
@MaTD varchar(20)
)
AS
BEGIN
	DELETE FROM DANHMUCHINHTHUCTUYENDUNG WHERE MaHinhThucTuyenDung = @MaTD
END
GO
/****** Object:  StoredProcedure [dbo].[XuatDanhSachKTKL]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XuatDanhSachKTKL]
AS
BEGIN
SELECT MaNhanVien as 'Mã nhân viên', MaKTKL 'Mã khen thưởng, kỉ luật', Ngay as 'Ngày', GhiChu as 'Ghi Chú' FROM DanhSachKTKL
END
GO
/****** Object:  StoredProcedure [dbo].[XuatDanhSachLuongNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XuatDanhSachLuongNV]
AS
BEGIN
SELECT MaLuong as 'Mã lương', MaNhanVien 'Mã nhân viên', LuongHD as 'Lương', SoNgayCong as 'Số ngày làm', ThangNam as 'Tháng/năm', TienBH as 'Tiền Bảo hiểm' FROM LuongNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[XuatDanhSachNV]    Script Date: 9/8/2021 9:07:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XuatDanhSachNV]
AS
BEGIN
SELECT MaNhanVien as 'Mã nhân viên', MaHinhThucTuyenDung 'Mã tuyển dụng', MaChucVu 'Mã chức vụ', MaPhongBan 'Mã phòng ban',NoiLamViec 'Nơi làm việc',
HoTen 'Họ tên', NgaySinh 'Ngày sinh',QueQuan 'Quê quán', GioiTinh 'Giới tính', SoCMND 'CMND', TrinhDo 'Trình độ', SDT 'Số điện thoại',
Email 'Email', NoiO 'Nơi ở', NoiSinh 'Nơi sinh' FROM DanhMucNhanVien
END
GO
