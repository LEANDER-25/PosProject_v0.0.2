USE [master]
GO
/****** Object:  Database [Project_1_Pos_FakeData]    Script Date: 2020-11-16 12:59:21 AM ******/
CREATE DATABASE [Project_1_Pos_FakeData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_1_Pos_FakeData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Project_1_Pos_FakeData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_1_Pos_FakeData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Project_1_Pos_FakeData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_1_Pos_FakeData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET RECOVERY FULL 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET  MULTI_USER 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Project_1_Pos_FakeData', N'ON'
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET QUERY_STORE = OFF
GO
USE [Project_1_Pos_FakeData]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[id] [int] NOT NULL,
	[ten_ban] [nvarchar](30) NULL,
	[isOrder] [bit] NULL,
	[id_khuVuc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CacBanCoDon]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CacBanCoDon](
	[id_dh] [int] IDENTITY(1,1) NOT NULL,
	[id_ban] [int] NOT NULL,
	[id_sp] [int] NOT NULL,
	[soLuongYeuCau] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBanHang]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBanHang](
	[id_hdBan] [int] NOT NULL,
	[id_sp] [int] NOT NULL,
	[soLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hdBan] ASC,
	[id_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhapHang]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhapHang](
	[id_hoaDonNhap] [int] NOT NULL,
	[id_nguyenLieu] [int] NOT NULL,
	[soLuongNhap] [int] NULL,
	[giaNhap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hoaDonNhap] ASC,
	[id_nguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[id_hd] [int] NOT NULL,
	[ngayBan] [datetime] NOT NULL,
	[id_nv] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhapHang]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhapHang](
	[id_hd] [int] NOT NULL,
	[ngayNhap] [date] NOT NULL,
	[id_nv] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[id] [int] NOT NULL,
	[ten_khuVuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lam]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lam](
	[id_sanPham] [int] NOT NULL,
	[id_nguyenLieu] [int] NOT NULL,
	[soLuongNL_1_SP] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sanPham] ASC,
	[id_nguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[id_loai] [int] IDENTITY(1,1) NOT NULL,
	[ten_loai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[id] [int] NOT NULL,
	[ten_nguyenLieu] [nvarchar](50) NULL,
	[soLuongNhap] [int] NULL,
	[donViTinh] [nvarchar](10) NULL,
	[soLuongLe_1_dvt] [int] NULL,
	[donViTinhLe] [nvarchar](10) NULL,
	[soLuongConLai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id_nhanVien] [int] IDENTITY(1,1) NOT NULL,
	[ten_nhanVien] [nvarchar](50) NULL,
	[ten_dangNhap] [varchar](50) NULL,
	[matKhau] [varchar](50) NULL,
	[chucVu] [nvarchar](30) NULL,
	[isOnline] [bit] NOT NULL,
	[SDT] [char](11) NULL,
	[stillWorking] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 2020-11-16 12:59:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id_sp] [int] NOT NULL,
	[ten_sp] [nvarchar](50) NULL,
	[giaBan] [int] NULL,
	[id_loai] [int] NULL,
	[donVi] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BanAn] ADD  DEFAULT ((0)) FOR [isOrder]
GO
ALTER TABLE [dbo].[ChiTietNhapHang] ADD  DEFAULT ((0)) FOR [soLuongNhap]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_isOnline]  DEFAULT ((0)) FOR [isOnline]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [stillWorking]
GO
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD FOREIGN KEY([id_khuVuc])
REFERENCES [dbo].[KhuVuc] ([id])
GO
ALTER TABLE [dbo].[CacBanCoDon]  WITH CHECK ADD  CONSTRAINT [fk_banAn_] FOREIGN KEY([id_ban])
REFERENCES [dbo].[BanAn] ([id])
GO
ALTER TABLE [dbo].[CacBanCoDon] CHECK CONSTRAINT [fk_banAn_]
GO
ALTER TABLE [dbo].[CacBanCoDon]  WITH NOCHECK ADD  CONSTRAINT [fk_sanPham_] FOREIGN KEY([id_sp])
REFERENCES [dbo].[SanPham] ([id_sp])
GO
ALTER TABLE [dbo].[CacBanCoDon] CHECK CONSTRAINT [fk_sanPham_]
GO
ALTER TABLE [dbo].[ChiTietBanHang]  WITH CHECK ADD  CONSTRAINT [fk_hdBan_] FOREIGN KEY([id_hdBan])
REFERENCES [dbo].[HoaDonBanHang] ([id_hd])
GO
ALTER TABLE [dbo].[ChiTietBanHang] CHECK CONSTRAINT [fk_hdBan_]
GO
ALTER TABLE [dbo].[ChiTietBanHang]  WITH NOCHECK ADD  CONSTRAINT [fk_spBan_] FOREIGN KEY([id_sp])
REFERENCES [dbo].[SanPham] ([id_sp])
GO
ALTER TABLE [dbo].[ChiTietBanHang] CHECK CONSTRAINT [fk_spBan_]
GO
ALTER TABLE [dbo].[ChiTietNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_hdNhap_] FOREIGN KEY([id_hoaDonNhap])
REFERENCES [dbo].[HoaDonNhapHang] ([id_hd])
GO
ALTER TABLE [dbo].[ChiTietNhapHang] CHECK CONSTRAINT [fk_hdNhap_]
GO
ALTER TABLE [dbo].[ChiTietNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_nLNhap_] FOREIGN KEY([id_nguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([id])
GO
ALTER TABLE [dbo].[ChiTietNhapHang] CHECK CONSTRAINT [fk_nLNhap_]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD FOREIGN KEY([id_nv])
REFERENCES [dbo].[NhanVien] ([id_nhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhapHang]  WITH CHECK ADD  CONSTRAINT [fk_nVienNhap_] FOREIGN KEY([id_nv])
REFERENCES [dbo].[NhanVien] ([id_nhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhapHang] CHECK CONSTRAINT [fk_nVienNhap_]
GO
ALTER TABLE [dbo].[Lam]  WITH CHECK ADD  CONSTRAINT [fk_nguyenLieu] FOREIGN KEY([id_nguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([id])
GO
ALTER TABLE [dbo].[Lam] CHECK CONSTRAINT [fk_nguyenLieu]
GO
ALTER TABLE [dbo].[Lam]  WITH NOCHECK ADD  CONSTRAINT [fk_sanPham] FOREIGN KEY([id_sanPham])
REFERENCES [dbo].[SanPham] ([id_sp])
GO
ALTER TABLE [dbo].[Lam] CHECK CONSTRAINT [fk_sanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_idLoai] FOREIGN KEY([id_loai])
REFERENCES [dbo].[LoaiSP] ([id_loai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_idLoai]
GO
USE [master]
GO
ALTER DATABASE [Project_1_Pos_FakeData] SET  READ_WRITE 
GO
