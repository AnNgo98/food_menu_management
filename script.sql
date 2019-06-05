USE [master]
GO
/****** Object:  Database [food_menu_managerment]    Script Date: 6/4/2019 7:17:21 PM ******/
CREATE DATABASE [food_menu_managerment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'food_menu_managerment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\food_menu_managerment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'food_menu_managerment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\food_menu_managerment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [food_menu_managerment] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [food_menu_managerment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [food_menu_managerment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [food_menu_managerment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [food_menu_managerment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [food_menu_managerment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [food_menu_managerment] SET ARITHABORT OFF 
GO
ALTER DATABASE [food_menu_managerment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [food_menu_managerment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [food_menu_managerment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [food_menu_managerment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [food_menu_managerment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [food_menu_managerment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [food_menu_managerment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [food_menu_managerment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [food_menu_managerment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [food_menu_managerment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [food_menu_managerment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [food_menu_managerment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [food_menu_managerment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [food_menu_managerment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [food_menu_managerment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [food_menu_managerment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [food_menu_managerment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [food_menu_managerment] SET RECOVERY FULL 
GO
ALTER DATABASE [food_menu_managerment] SET  MULTI_USER 
GO
ALTER DATABASE [food_menu_managerment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [food_menu_managerment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [food_menu_managerment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [food_menu_managerment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [food_menu_managerment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [food_menu_managerment] SET QUERY_STORE = OFF
GO
USE [food_menu_managerment]
GO
/****** Object:  Table [dbo].[BuaAn]    Script Date: 6/4/2019 7:17:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuaAn](
	[IDBua] [int] IDENTITY(1,1) NOT NULL,
	[Bua] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_BuaAn] PRIMARY KEY CLUSTERED 
(
	[IDBua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongThucMonAn]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThucMonAn](
	[IDNguyenLieu] [int] NOT NULL,
	[IDMonAn] [int] NOT NULL,
	[KhoiLuong] [float] NOT NULL,
 CONSTRAINT [PK_CongThucMonAn] PRIMARY KEY CLUSTERED 
(
	[IDNguyenLieu] ASC,
	[IDMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DinhMucDinhDuong]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DinhMucDinhDuong](
	[IDDinhMuc] [int] NOT NULL,
	[IDBua] [int] NULL,
	[Lipit] [float] NULL,
	[Glucid] [float] NULL,
	[Protid] [float] NULL,
	[Kcal] [float] NULL,
 CONSTRAINT [PK_DinhMucDinhDuong] PRIMARY KEY CLUSTERED 
(
	[IDDinhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[IDDonViTinh] [int] IDENTITY(1,1) NOT NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[IDDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiKhoan]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiKhoan](
	[IDLoaiUser] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_LoaiUser] PRIMARY KEY CLUSTERED 
(
	[IDLoaiUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[IDMonAn] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](30) NOT NULL,
	[IDNhomMonAn] [int] NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[IDMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonTrongThucDon]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonTrongThucDon](
	[IDMonAn] [int] NOT NULL,
	[IDThucDon] [int] NOT NULL,
	[IDBua] [int] NOT NULL,
 CONSTRAINT [PK_MonTrongThucDon] PRIMARY KEY CLUSTERED 
(
	[IDMonAn] ASC,
	[IDThucDon] ASC,
	[IDBua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[IDNguyenLieu] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](20) NULL,
	[GiaThanh] [float] NULL,
	[Lipid] [float] NULL,
	[Protid] [float] NULL,
	[Kcal] [float] NULL,
	[Glucid] [float] NULL,
	[IDNhomNguyenLieu] [int] NULL,
	[IDDonViTinh] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[IDNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomMonAn]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomMonAn](
	[IDNhomMonAn] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_NhomMonAn] PRIMARY KEY CLUSTERED 
(
	[IDNhomMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNguyenLieu]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguyenLieu](
	[IDNhomNguyenLieu] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_NhomNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[IDNhomNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[IDUser] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[IDLoaiUser] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 6/4/2019 7:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[IDThucDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayThucHienThucDon] [date] NOT NULL,
	[NgayLap] [date] NOT NULL,
	[SoKhauPhan] [int] NOT NULL,
	[IDUser] [int] NULL,
 CONSTRAINT [PK_ThucDon] PRIMARY KEY CLUSTERED 
(
	[IDThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BuaAn] ON 

INSERT [dbo].[BuaAn] ([IDBua], [Bua]) VALUES (1, N'Sáng')
INSERT [dbo].[BuaAn] ([IDBua], [Bua]) VALUES (2, N'Xế Sáng')
INSERT [dbo].[BuaAn] ([IDBua], [Bua]) VALUES (3, N'Trưa')
INSERT [dbo].[BuaAn] ([IDBua], [Bua]) VALUES (4, N'Xế Chiều')
SET IDENTITY_INSERT [dbo].[BuaAn] OFF
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (6, 119, 2)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (7, 117, 2.2000000476837158)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (7, 119, 2.0999999046325684)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (7, 120, 2.0999999046325684)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (7, 122, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 21, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 22, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 23, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 24, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 25, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 26, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 27, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 28, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 117, 2.1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 121, 43)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (9, 124, 12)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (10, 3, 12)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 11, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 12, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 13, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 14, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 15, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 16, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 17, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 18, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 19, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 20, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 120, 20.100000381469727)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 121, 21)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (11, 123, 12)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (12, 121, 12)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (13, 116, 12.3)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (16, 120, 1.6000000238418579)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (18, 1, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (18, 123, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (18, 124, 12)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (37, 29, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 1, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 2, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 3, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 4, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 5, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 6, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 7, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 8, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 9, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 10, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (70, 30, 1)
INSERT [dbo].[CongThucMonAn] ([IDNguyenLieu], [IDMonAn], [KhoiLuong]) VALUES (71, 3, 1)
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (1, N'1 Kilogam')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (2, N'100 Gam')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (3, N'1 Quả')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (4, N'1 Bó')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (5, N'100 ml')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (6, N'1 miếng')
INSERT [dbo].[DonViTinh] ([IDDonViTinh], [DonViTinh]) VALUES (7, N'1 hộp')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] ON 

INSERT [dbo].[LoaiTaiKhoan] ([IDLoaiUser], [TenLoai]) VALUES (1, N'Admin')
INSERT [dbo].[LoaiTaiKhoan] ([IDLoaiUser], [TenLoai]) VALUES (2, N'Người Tạo Thực Đơn')
INSERT [dbo].[LoaiTaiKhoan] ([IDLoaiUser], [TenLoai]) VALUES (3, N'Quản Lý Bếp')
SET IDENTITY_INSERT [dbo].[LoaiTaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[MonAn] ON 

INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (1, N'Thịt heo hầm cà rốt', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (2, N'Thịt heo kho tàu', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (3, N'Thịt heo kho củ cải trắng', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (4, N'Thịt heo xào chua ngọt', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (5, N'Thịt heo xào hành tây', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (6, N' Thịt heo xá xíu', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (7, N'Sườn non xào chua ngọt', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (8, N'Sườn nướng', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (9, N'Thịt heo kho thơm', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (10, N'Thit ba chỉ luộc', 1)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (11, N'Bò hầm cà chua', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (12, N'Thịt bò xào măng tây', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (13, N'Bí đỏ hấp thịt bò', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (14, N'Bò xào xốt chua ngọt', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (15, N'Bò xào hành tây', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (16, N'Bò lúc lắc', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (17, N'Bò cuốn lá lốt', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (18, N'Bò xào ớt chuông', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (19, N'Bò hầm ngủ quả', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (20, N'Bò xào khoai tây', 2)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (21, N'Gà kho gừng', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (22, N'Ức gà luộc', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (23, N'Cà ri gà', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (24, N'Cánh gà chiên nước mắm', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (25, N'Cánh gà chiên bơ', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (26, N'Gà nướng mật ong', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (27, N'Gà kho xả ớt', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (28, N'Gà xào mướp', 3)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (29, N'Cá thu chiên sốt cà chua', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (30, N'Xíu mại cá với đậu Hà Lan', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (31, N'Cá viên chiên', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (32, N'Cá basa kho', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (33, N'Cá thu rán rim
', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (34, N'File cá thu chiên bơ', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (35, N'Cá lóc hấp', 4)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (36, N'Tôm rim', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (37, N'Tôm hấp nước dừa', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (38, N'Mướp nhồi tôm hấp xốt hải sản', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (39, N'Tôm xào bắp non', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (40, N'Tôm rang bơ', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (41, N'Nem tôm và bắp cải', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (42, N'Tôm lăn bột chiên', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (43, N'Ruốc tôm', 5)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (44, N'Canh cua mồng tơi', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (45, N'Canh chua thịt băm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (46, N'Canh gà lá giang', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (47, N'Canh chua cá lóc', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (48, N'Canh sườn non nấu dưa chua', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (49, N'Canh dưa cải chua thịt bò', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (50, N'Canh cải xanh thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (51, N'Canh bí đỏ thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (52, N'Canh bí xanh nấu tôm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (53, N'Canh khoai tây cà rốt thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (54, N'Canh bí tôm tươi', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (55, N'Canh mướp Nhật nấu thịt băm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (56, N'Canh trứng cà chua', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (57, N'Canh tôm rau dền', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (58, N'Canh tôm mồng tơi', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (59, N'Canh cá rô phi với rau ngót', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (60, N'Canh gà nấu nấm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (61, N'Canh bắp cải thịt viên', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (62, N'Canh rong biển đậu hũ thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (63, N'Canh bắp cải thảo thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (64, N'Canh khoai sọ với thịt bằm', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (65, N'Canh mọc cà chua', 6)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (66, N'Mỳ ý sốt cà chua bò bằm', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (68, N'Mỳ xào bò với rau củ', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (69, N'Mỳ xào tôm bằm', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (70, N'Mỳ xào thịt heo rau cải', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (72, N'Nui xào bò', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (73, N'Nui sườn non', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (74, N'Nui xào thịt heo bằm', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (75, N'Nui xào tôm chua ngọt', 7)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (76, N'Cháo lươn cà rốt', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (77, N'Cháo thịt cóc củ mài', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (78, N'Cháo thịt gà nấu bí đỏ', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (81, N'Cháo thịt bằm đậu cô ve', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (82, N'Cháo cua', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (83, N'Cháo tôm cải thảo', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (84, N'Cháo tôm bí đỏ', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (85, N'Cháo bồ câu bằm', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (86, N'Cháo cá lóc', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (87, N'Cháo bò bằm', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (88, N'Cháo ếch', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (89, N'Cháo thịt heo rau ngót', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (90, N'Cháo thịt heo bí đỏ', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (91, N'Cháo tôm súp lơ', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (92, N'Cháo cua bí đỏ', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (93, N'Cháo trứng với đậu hũ non', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (94, N'Cháo gà nấm rơm', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (95, N'Cháo thịt heo hạt sen', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (97, N'Cháo thịt heo cà rốt', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (98, N'Cháo sườn non khoai tây', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (99, N'Cháo cá rô rau cải', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (100, N'Cháo lươn', 8)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (101, N'Dưa hấu', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (102, N'Xoài', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (103, N'Đu đủ', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (104, N'Vú sữa', 9)
GO
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (105, N'Cam vắt', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (106, N'Ổi', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (107, N'Mận', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (108, N'Lê', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (109, N'Táo', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (110, N'Mít', 9)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (111, N'Sữa hộp TH TrueMilk', 10)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (112, N'Sữa đậu nành', 10)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (113, N'Sữa bắp', 10)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (114, N'Sữa gạo lứt', 10)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (115, N'Sữa chua', 10)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (116, N'Nước cam', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (117, N'Bánh canh cua', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (118, N'Banh cánh canh bột lọc', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (119, N'Bánh canh gạo', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (120, N'Thịt thỏ chiên mắm', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (121, N'Bánh mỳ kẹp thịt', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (122, N'Bánh mỳ bơ sữa', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (123, N'Bò xào cà rốt', NULL)
INSERT [dbo].[MonAn] ([IDMonAn], [TenMonAn], [IDNhomMonAn]) VALUES (124, N'Thịt gà xào cà rốt', NULL)
SET IDENTITY_INSERT [dbo].[MonAn] OFF
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (4, N'Nui', 10000, 0.4, 6.6, 359, 82.2, 3, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (6, N'Gạo', 13000, 0.3, 2.7, 130, 0, 3, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (7, N'Bánh canh', 7000, 0, 2, 110, 26, 3, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (8, N'Bánh phở', 10000, 1, 3, 143, 32, 3, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (9, N'Thịt gà', 22000, 29.6, 45.9, 449.3, 0, 4, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (10, N'Thịt vịt', 20000, 21.8, 17.8, 267, 0, 4, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (11, N'Thịt bò', 23000, 3.8, 21, 118, 0, 4, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (12, N'Thịt ếch', 9000, 1.1, 20, 90, 0, 4, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (13, N'Bầu', 4000, 0, 0.6, 14, 2.9, 7, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (15, N'Bí đao', 5000, 0, 0.6, 12, 2.4, 7, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (16, N'Bí đỏ', 6000, 0, 0.3, 24, 5.6, 7, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (17, N'Cà chua', 4000, 0, 0.6, 19, 4.2, 7, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (18, N'Cà rốt', 5000, 0, 1.5, 38, 8, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (19, N'Dưa leo', 5000, 0, 0.8, 15, 0, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (20, N'Đậu cô ve', 6000, 0, 5, 73, 13.3, 8, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (21, N'Đậu đũa', 6000, 0, 6, 57, 8.3, 8, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (22, N'Rau má', 5000, 0, 3.2, 20, 1.8, 5, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (23, N'Rau mồng tơi', 4000, 0, 2, 14, 1.4, 5, 4)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (24, N'Rau muống', 5000, 0, 3.2, 23, 2.5, 5, 4)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (25, N'Rau bồ ngót', 5000, 0, 5.3, 35, 3.4, 5, 4)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (26, N'Nấm rơm', 12000, 3.2, 3.6, 57, 3.4, 13, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (27, N'Củ dền', 10000, 0.2, 2, 43, 6.8, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (28, N'Củ từ', 9000, 0, 1.5, 92, 21.5, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (29, N'Khoai lang', 5000, 0.2, 0.8, 119, 28.5, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (30, N'Khoai môn', 7000, 0.2, 1.5, 109, 25.2, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (31, N'Khoai tây', 8000, 0, 2, 92, 21, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (32, N'Đậu phụ', 1000, 5.4, 10.9, 95, 0.7, 8, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (33, N'Sữa đậu nành', 4000, 1.6, 3.1, 28, 0.4, 11, 5)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (34, N'Chả cá', 13000, 0, 15, 280, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (35, N'Cá ngừ', 12000, 0.3, 21, 87, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (36, N'Cá nục', 7000, 3.3, 20.2, 111, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (37, N'Cá thu', 13000, 10.3, 18.2, 166, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (38, N'Cua', 30000, 0.6, 17.5, 103, 7, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (39, N'Ghẹ', 25000, 0.7, 11.9, 54, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (40, N'Lươn', 11000, 1.5, 20, 94, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (41, N'Mực', 9000, 0.9, 16.3, 73, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (42, N'Tôm', 10000, 1.8, 18.4, 90, 0, 9, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (43, N'Trứng gà', 3500, 11.6, 14.8, 166, 0.5, 10, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (45, N'Trứng vịt', 4000, 14.2, 13, 484, 1, 10, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (46, N'Trứng cút', 1000, 7.3, 13, 158, 0, 10, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (47, N'Phô mai con bò cười', 4000, 30.9, 25.5, 380, 0, 11, 6)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (49, N'Sữa chua Mộc Châu', 7000, 3.2, 3.1, 107.2, 16.5, 11, 7)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (50, N'Sữa hộp True Milk', 8000, 3.3, 3, 60, 4.6, 11, 7)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (52, N'Bưởi', 7000, 0, 0.2, 30, 7.3, 12, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (53, N'Chuối', 4000, 0.2, 1.5, 97, 22.2, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (54, N'Dưa hấu', 4000, 0.2, 1.2, 16, 2.3, 12, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (58, N'Đu đủ', 4000, 0, 1, 35, 7.7, 12, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (59, N'Hồng', 8000, 0, 0.7, 28, 6.2, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (60, N'Lê', 8000, 0.2, 0.7, 45, 10.2, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (62, N'Mận ', 6000, 0.2, 0.6, 20, 3.9, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (63, N'Na', 9000, 0, 1.6, 64, 14.5, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (64, N'Ổi', 4000, 0, 0.6, 33, 7.7, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (65, N'Quít', 4000, 0, 0.8, 38, 8.6, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (66, N'Thanh long', 15000, 0, 1.3, 40, 8.7, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (67, N'Xoài chín', 13000, 0.3, 0.6, 69, 15.9, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (68, N'Vú sữa', 11000, 0, 1, 42, 9.4, 12, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (69, N'Vải', 3000, 0, 0.7, 43, 10, 12, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (70, N'Thịt heo', 17000, 7, 19, 139, 0, 4, 2)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (71, N'Củ cái trắng', 10000, 0, 1.5, 21, 3.7, 6, 3)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (72, N'Gà công nghiệp', NULL, 20, 1, 2.5, 40, 4, NULL)
INSERT [dbo].[NguyenLieu] ([IDNguyenLieu], [Ten], [GiaThanh], [Lipid], [Protid], [Kcal], [Glucid], [IDNhomNguyenLieu], [IDDonViTinh]) VALUES (76, N'Xoài', NULL, 121, 2, 2, 2, 7, NULL)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
SET IDENTITY_INSERT [dbo].[NhomMonAn] ON 

INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (1, N'Heo')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (2, N'Bò')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (3, N'Gà/vịt')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (4, N'Cá')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (5, N'Hải sản')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (6, N'Canh')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (7, N'Mỳ/nui')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (8, N'Cháo')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (9, N'Tráng miệng')
INSERT [dbo].[NhomMonAn] ([IDNhomMonAn], [TenNhom]) VALUES (10, N'Sữa')
SET IDENTITY_INSERT [dbo].[NhomMonAn] OFF
SET IDENTITY_INSERT [dbo].[NhomNguyenLieu] ON 

INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (3, N'Ngũ Cốc')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (4, N'Thịt')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (5, N'Rau')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (6, N'Củ')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (7, N'Quả')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (8, N'Đậu')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (9, N'Hải Sản')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (10, N'Trứng')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (11, N'Sữa')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (12, N'Quả Chín')
INSERT [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu], [TenNhom]) VALUES (13, N'Nấm')
SET IDENTITY_INSERT [dbo].[NhomNguyenLieu] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([IDUser], [Ten], [MatKhau], [IDLoaiUser]) VALUES (1, N'HieuTruong', N'12345', 1)
INSERT [dbo].[TaiKhoan] ([IDUser], [Ten], [MatKhau], [IDLoaiUser]) VALUES (2, N'QuanLy', N'12345', 2)
INSERT [dbo].[TaiKhoan] ([IDUser], [Ten], [MatKhau], [IDLoaiUser]) VALUES (3, N'DauBepTruong', N'12345', 3)
INSERT [dbo].[TaiKhoan] ([IDUser], [Ten], [MatKhau], [IDLoaiUser]) VALUES (4, N'ad', N'123', 1)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([IDThucDon], [NgayThucHienThucDon], [NgayLap], [SoKhauPhan], [IDUser]) VALUES (2, CAST(N'2019-05-26' AS Date), CAST(N'2019-05-25' AS Date), 70, 1)
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
ALTER TABLE [dbo].[CongThucMonAn]  WITH CHECK ADD  CONSTRAINT [FK_CongThucMonAn_MonAn] FOREIGN KEY([IDMonAn])
REFERENCES [dbo].[MonAn] ([IDMonAn])
GO
ALTER TABLE [dbo].[CongThucMonAn] CHECK CONSTRAINT [FK_CongThucMonAn_MonAn]
GO
ALTER TABLE [dbo].[CongThucMonAn]  WITH CHECK ADD  CONSTRAINT [FK_CongThucMonAn_NguyenLieu] FOREIGN KEY([IDNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([IDNguyenLieu])
GO
ALTER TABLE [dbo].[CongThucMonAn] CHECK CONSTRAINT [FK_CongThucMonAn_NguyenLieu]
GO
ALTER TABLE [dbo].[DinhMucDinhDuong]  WITH CHECK ADD  CONSTRAINT [FK_DinhMucDinhDuong_BuaAn] FOREIGN KEY([IDBua])
REFERENCES [dbo].[BuaAn] ([IDBua])
GO
ALTER TABLE [dbo].[DinhMucDinhDuong] CHECK CONSTRAINT [FK_DinhMucDinhDuong_BuaAn]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_NhomMonAn] FOREIGN KEY([IDNhomMonAn])
REFERENCES [dbo].[NhomMonAn] ([IDNhomMonAn])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_NhomMonAn]
GO
ALTER TABLE [dbo].[MonTrongThucDon]  WITH CHECK ADD  CONSTRAINT [FK_MonTrongThucDon_BuaAn] FOREIGN KEY([IDBua])
REFERENCES [dbo].[BuaAn] ([IDBua])
GO
ALTER TABLE [dbo].[MonTrongThucDon] CHECK CONSTRAINT [FK_MonTrongThucDon_BuaAn]
GO
ALTER TABLE [dbo].[MonTrongThucDon]  WITH CHECK ADD  CONSTRAINT [FK_MonTrongThucDon_MonAn] FOREIGN KEY([IDMonAn])
REFERENCES [dbo].[MonAn] ([IDMonAn])
GO
ALTER TABLE [dbo].[MonTrongThucDon] CHECK CONSTRAINT [FK_MonTrongThucDon_MonAn]
GO
ALTER TABLE [dbo].[MonTrongThucDon]  WITH CHECK ADD  CONSTRAINT [FK_MonTrongThucDon_ThucDon] FOREIGN KEY([IDThucDon])
REFERENCES [dbo].[ThucDon] ([IDThucDon])
GO
ALTER TABLE [dbo].[MonTrongThucDon] CHECK CONSTRAINT [FK_MonTrongThucDon_ThucDon]
GO
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_DonViTinh] FOREIGN KEY([IDDonViTinh])
REFERENCES [dbo].[DonViTinh] ([IDDonViTinh])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_DonViTinh]
GO
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhomNguyenLieu] FOREIGN KEY([IDNhomNguyenLieu])
REFERENCES [dbo].[NhomNguyenLieu] ([IDNhomNguyenLieu])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhomNguyenLieu]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_User_LoaiUser] FOREIGN KEY([IDLoaiUser])
REFERENCES [dbo].[LoaiTaiKhoan] ([IDLoaiUser])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_User_LoaiUser]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_User] FOREIGN KEY([IDUser])
REFERENCES [dbo].[TaiKhoan] ([IDUser])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_User]
GO
/****** Object:  StoredProcedure [dbo].[LayBuaAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayBuaAn]
AS
BEGIN
	Select * From BuaAn
END
GO
/****** Object:  StoredProcedure [dbo].[LayDinhMucDinhDuong]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayDinhMucDinhDuong]
AS
BEGIN
	Select * From DinhMucDinhDuong
END
GO
/****** Object:  StoredProcedure [dbo].[LayMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayMonAn]
AS
BEGIN
	Select * From MonAn
END
GO
/****** Object:  StoredProcedure [dbo].[LayMonTrongThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayMonTrongThucDon]
AS
BEGIN
	Select * From MonTrongThucDon
END
GO
/****** Object:  StoredProcedure [dbo].[LayNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayNguyenLieu]
AS
BEGIN
	Select * From NguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[LayNhomMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayNhomMonAn]
@IDNguyenLieu int,
@IDMonAn int,
@KhoiLuong float
AS
BEGIN
	Select * From NhomMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[LayNhomNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayNhomNguyenLieu]
@IDNguyenLieu int,
@IDMonAn int,
@KhoiLuong float
AS
BEGIN
	Select * From NhomNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[LayThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[LayThucDon]
@IDNguyenLieu int,
@IDMonAn int,
@KhoiLuong float
AS
BEGIN
	Select * From ThucDon
END
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Login]
(
@username NVARCHAR(50),  @pass NVARCHAR(50),
@true int
)
AS
set
@true = (select count(*) from [dbo].[User] where @username=Ten And @pass=MatKhau)
	select case @true
when 1 then 1 --Login is Correctelse0 --Bad login
else
0
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteNguyenLieu]
@MaNguyenLieu int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	Delete from NguyenLieu where IDNguyenLieu=@MaNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spInsertNguyenLieu]
	@TenNguyenLieu nvarchar(20),
	@Kcal float,
	@Protid float,
	@IDNhomNguyenLieu int,
	@Lipid float,
	@Glucid float
as
BEGIN
INSERT INTO NguyenLieu values (@TenNguyenLieu, null, @Lipid, @Protid, @Kcal, @Glucid, @IDNhomNguyenLieu, null)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spThemMonAn]
@TenMonAn nvarchar(30),
@IDNguyenLieu int,
@KhoiLuong float
AS
BEGIN
	declare @idMonAn int
	select @idMonAn = IDMonAn from MonAn where TenMonAn = @TenMonAn
	IF @idMonAn is null
		BEGIN
			INSERT INTO MonAn values (@TenMonAn, null)			
			set @idMonAn = SCOPE_IDENTITY()
			INSERT INTO CongThucMonAn values (@IDNguyenLieu, @idMonAn, @KhoiLuong)
		END
	ELSE
		BEGIN
			INSERT INTO CongThucMonAn values (@IDNguyenLieu, @idMonAn, @KhoiLuong)
		END
END
GO
/****** Object:  StoredProcedure [dbo].[spThemThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemThucDon]
	@NgayLap date,
	@NgayThucHien date,
	@SoPhanAn int,
	@IDMonAn int
AS
BEGIN
	declare @idThucDon int
	select @idThucDon = IDThucDon from ThucDon where NgayLap = GetDate()
	IF @idThucDon is null
		BEGIN
			Insert into ThucDon values(@NgayThucHien, @NgayLap, @SoPhanAn, null)
			set @idThucDon = SCOPE_IDENTITY()
			Insert into MonTrongThucDon values (@IDMonAn, @idThucDon, null)
		END
	ELSE
		BEGIN
			INSERT INTO MonTrongThucDon values(@IDMonAn, @idThucDon, null)
		END
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spUpdateNguyenLieu]
	@IDNguyenLieu int,
	@TenNguyenLieu nvarchar(20),
	@IDNhomNguyenLieu int,
	@Kcal float,
	@Protid float,
	@Lipid float,
	@Glucid float
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	Update NguyenLieu set Ten=@TenNguyenLieu, Kcal = @Kcal, Lipid=@Lipid, Glucid = @Glucid , Protid = @Protid, IDNhomNguyenLieu = @IDNhomNguyenLieu where IDNguyenLieu=@IDNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[SuaMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaMonAn]
@IDMonAn int,
@TenMonAn nvarchar(30),
@IDNhomMonAn int
AS
BEGIN
	Update MonAn
	set TenMonAn=@TenMonAn,IDNhomMonAn=@IDNhomMonAn
	where IDMonAn=@IDMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[SuaMonTrongThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaMonTrongThucDon]
@IDMonAn int,
@IDThucDon int,
@IDBua int
AS
BEGIN
	Update MonTrongThucDon set IDMonAn=@IDMonAn,IDBua=@IDBua
	where IDThucDon=@IDThucDon
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaNguyenLieu]
@IDNguyenLieu int,
@Ten nvarchar(20),
@GiaThanh float,
@Lipid float,
@Protid float,
@Kcal float,
@Glucid float,
@IDNhomNguyenLieu int,
@IDDonViTinh int
AS
BEGIN
	Update NguyenLieu set Ten=@Ten,GiaThanh=@GiaThanh,Lipid=@Lipid,Protid=@Protid,Kcal=@Kcal,Glucid=@Glucid,IDNhomNguyenLieu=@IDNhomNguyenLieu,IDDonViTinh=@IDDonViTinh
	where IDNguyenLieu=@IDNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNhomMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaNhomMonAn]
@IDNhomMonAn int,
@TenNhom nvarchar(30)
AS
BEGIN
	Update NhomMonAn
	set TenNhom=@TenNhom
	where IDNhomMonAn=@IDNhomMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNhomNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaNhomNguyenLieu]
@IDNhomNguyenLieu int,
@TenNhom nvarchar(30)
AS
BEGIN
	Update NhomNguyenLieu
	set TenNhom=@TenNhom
	where IDNhomNguyenLieu=@IDNhomNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[SuaThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuaThucDon]
@IDThucDon int,
@NgayThucHienThucDon date,
@NgayLap date,
@SoKhauPhan int,
@IDUser int
AS
BEGIN
	Update ThucDon set NgayThucHienThucDon=@NgayThucHienThucDon,NgayLap=@NgayLap,SoKhauPhan=@SoKhauPhan,IDUser=@IDUser
	where IDThucDon=@IDThucDon
END
GO
/****** Object:  StoredProcedure [dbo].[ThemCongThucMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[ThemCongThucMonAn]
@IDNguyenLieu int,
@IDMonAn int,
@KhoiLuong float
AS
BEGIN
	Insert into CongThucMonAn(IDNguyenLieu,IDMonAn,KhoiLuong) values(@IDNguyenLieu,@IDMonAn,@KhoiLuong)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemMonAn]
@IDMonAn int,
@TenMonAn nvarchar(30),
@IDNhomMonAn int
AS
BEGIN
	Insert into MonAn(IDMonAn,TenMonAn,IDNhomMonAn) values (@IDMonAn,@TenMonAn,@IDNhomMonAn)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemMonTrongThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemMonTrongThucDon]
@IDMonAn int,
@IDThucDon int,
@IDBua int
AS
BEGIN
	Insert into MonTrongThucDon(IDMonAn,IDThucDon,IDBua) values (@IDMonAn,@IDThucDon,@IDBua)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNguyenLieu]
@IDNguyenLieu int,
@Ten nvarchar(20),
@GiaThanh float,
@Lipid float,
@Protid float,
@Kcal float,
@Glucid float,
@IDNhomNguyenLieu int,
@IDDonViTinh int
AS
BEGIN
	Insert into NguyenLieu(IDNguyenLieu,Ten,GiaThanh,Lipid,Protid,Kcal,Glucid,IDNhomNguyenLieu,IDDonViTinh) values (@IDNguyenLieu,@Ten,@GiaThanh,@Lipid,@Protid,@Kcal,@Glucid,@IDNhomNguyenLieu,@IDDonViTinh)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhomMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhomMonAn]
@IDNhomMonAn int,
@TenNhom nvarchar(30)
AS
BEGIN
	Insert into NhomMonAn(IDNhomMonAn,TenNhom) values (@IDNhomMonAn,@TenNhom)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhomNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhomNguyenLieu]
@IDNhomNguyenLieu int,
@TenNhom nvarchar(30)
AS
BEGIN
	INSERT INTO NhomNguyenLieu(IDNhomNguyenLieu,TenNhom) VALUES (@IDNhomNguyenLieu, @TenNhom)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemThucDon]
@IDThucDon int,
@NgayThucHienThucDon date,
@NgayLap date,
@SoKhauPhan int,
@IDUser int
AS
BEGIN
	Insert into ThucDon(IDThucDon,NgayThucHienThucDon,NgayLap,SoKhauPhan,IDUser) values(@IDThucDon,@NgayThucHienThucDon,@NgayLap,@SoKhauPhan,@IDUser)
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCongThucMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[XoaCongThucMonAn]
@IDNguyenLieu int,
@IDMonAn int,
@KhoiLuong float
AS
BEGIN
	Delete From CongThucMonAn where IDNguyenLieu=@IDNguyenLieu and IDMonAn=@IDMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[XoaMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaMonAn]
@IDMonAn int
AS
BEGIN
	Delete From MonAn
	where IDMonAn=@IDMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[XoaMonTrongThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaMonTrongThucDon]
@IDMonAn int,
@IDThucDon int
AS
BEGIN
	Delete From MonTrongThucDon
	where IDBua=@IDMonAn and IDThucDon=@IDThucDon
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaNguyenLieu]
@IDNguyenLieu int
AS
BEGIN
	Delete From NguyenLieu where IDNguyenLieu=@IDNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNhomMonAn]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaNhomMonAn]
@IDNhomMonAn int
AS
BEGIN
	Delete From NhomMonAn where IDNhomMonAn=@IDNhomMonAn
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNhomNguyenLieu]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaNhomNguyenLieu]
@IDNhomNguyenLieu int
AS
BEGIN
	Delete From NhomNguyenLieu where IDNhomNguyenLieu=@IDNhomNguyenLieu
END
GO
/****** Object:  StoredProcedure [dbo].[XoaThucDon]    Script Date: 6/4/2019 7:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XoaThucDon]
@IDThucDon int
AS
BEGIN
	Delete From ThucDon
	where IDThucDon=@IDThucDon
END
GO
USE [master]
GO
ALTER DATABASE [food_menu_managerment] SET  READ_WRITE 
GO
