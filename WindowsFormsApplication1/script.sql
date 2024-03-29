USE [master]
GO
/****** Object:  Database [PTUD]    Script Date: 12/11/2019 6:27:01 PM ******/
CREATE DATABASE [PTUD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PTUD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PTUD.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PTUD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PTUD_ldf.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PTUD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PTUD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PTUD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PTUD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PTUD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PTUD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PTUD] SET ARITHABORT OFF 
GO
ALTER DATABASE [PTUD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PTUD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PTUD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PTUD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PTUD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PTUD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PTUD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PTUD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PTUD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PTUD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PTUD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PTUD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PTUD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PTUD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PTUD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PTUD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PTUD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PTUD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PTUD] SET RECOVERY FULL 
GO
ALTER DATABASE [PTUD] SET  MULTI_USER 
GO
ALTER DATABASE [PTUD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PTUD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PTUD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PTUD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PTUD', N'ON'
GO
USE [PTUD]
GO
/****** Object:  Table [dbo].[NV]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NV](
	[userID] [int] NOT NULL,
	[userName] [nvarchar](40) NOT NULL,
	[userAccount] [nvarchar](40) NOT NULL,
	[userPassword] [nvarchar](18) NOT NULL,
	[userEmail] [nvarchar](60) NOT NULL,
	[userPhone] [nvarchar](15) NOT NULL,
	[role] [bit] NOT NULL,
	[activation] [bit] NOT NULL,
 CONSTRAINT [pk_userID] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[ProductID] [int] NOT NULL,
	[orderDetailID] [int] NOT NULL,
	[orderID] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[tax] [float] NOT NULL,
	[orderQuantity] [int] NOT NULL,
 CONSTRAINT [pk_OrderDetailID] PRIMARY KEY CLUSTERED 
(
	[orderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[orderID] [int] NOT NULL,
	[userID] [int] NOT NULL,
	[status] [int] NOT NULL,
	[orderDate] [datetime] NOT NULL,
	[VendorID] [int] NULL,
 CONSTRAINT [pk_OrderID] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[ProductType] [bit] NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[Manufacture] [nvarchar](30) NULL,
 CONSTRAINT [pk_ProductID] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ProductCategoryID] [int] NOT NULL,
	[ProductCategoryName] [nvarchar](30) NOT NULL,
 CONSTRAINT [pk_ProductCategoryID] PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorID] [int] NOT NULL,
	[VendorName] [nvarchar](60) NOT NULL,
	[VendorAddress] [nvarchar](60) NOT NULL,
	[VAT] [float] NOT NULL,
	[VendorEmail] [nvarchar](60) NOT NULL,
	[VendorPhone] [nvarchar](15) NOT NULL,
	[VendorAvailable] [bit] NOT NULL,
 CONSTRAINT [pk_VendorID] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorProduct]    Script Date: 12/11/2019 6:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorProduct](
	[VendorID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NV] ([userID], [userName], [userAccount], [userPassword], [userEmail], [userPhone], [role], [activation]) VALUES (1, N'Nguyễn Văn An', N'user1', N'-1623739142', N'nguyenvanan01@gmail.com', N'+84123456789', 1, 1)
INSERT [dbo].[NV] ([userID], [userName], [userAccount], [userPassword], [userEmail], [userPhone], [role], [activation]) VALUES (2, N'Nguyễn Thái Bảo', N'user2', N'-1623739142', N'ngvanbao21@gmail.com', N'+845123456789', 0, 1)
INSERT [dbo].[NV] ([userID], [userName], [userAccount], [userPassword], [userEmail], [userPhone], [role], [activation]) VALUES (3, N'Nguyễn Thị Hân', N'user3', N'-1623739142', N'han_nguyen212@gmail.com', N'+845123456789', 0, 1)
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductType], [ProductCategoryID], [Manufacture]) VALUES (1, N'Ghế DXRACER GAMING CHAIR - King GC-K06', 0, 1, N'DXRacer')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductType], [ProductCategoryID], [Manufacture]) VALUES (2, N'iMac 2019', 0, 5, N'Apple')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductType], [ProductCategoryID], [Manufacture]) VALUES (3, N'Nvidia Quadro P620', 1, 3, N'NVIDIA')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductType], [ProductCategoryID], [Manufacture]) VALUES (4, N'Iphone X', 0, 4, N'Apple')
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductType], [ProductCategoryID], [Manufacture]) VALUES (5, N'Đồng phục nhân viên', 0, 6, N'Công ty TNHH May Mặc Dony')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (1, N'Gaming gear')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (2, N'Đồ điện tử')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (3, N'Card Đồ Họa')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (4, N'Điện thoại')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (5, N'Laptop, PC')
INSERT [dbo].[ProductCategory] ([ProductCategoryID], [ProductCategoryName]) VALUES (6, N'Đồng phục')
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (1, N'Phong Vũ Computer', N'Số 2A Nguyễn Oanh, Phường 7, Gò Vấp, Hồ Chí Minh', 101248141, N'phongvu_govap@gmail.com', N'18006867', 1)
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (2, N'FPT Shop Nguyễn Kiệm', N' 804 Nguyễn Kiệm, Phường 3, Gò Vấp, Hồ Chí Minh', 101248231, N'fpt_shop@gmail.com', N'18006601', 1)
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (3, N'Tân Doanh Computer', N'592 Ba Tháng Hai, Phường 14, Quận 10, Hồ Chí Minh', 101248141, N'tandoanh_computer@gmail.com', N'1900966939', 1)
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (4, N'Công ty TNHH May Mặc Dony', N'142/4 Bàu Cát 2, Phường 12, Tân Bình, Hồ Chí Minh', 101241112, N'dony_clothing@gmail.com', N'0938508078', 0)
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (5, N'Shop giày 12h', N'310 Quang Trung, Phường 10, Gò Vấp, Hồ Chí Minh', 101123141, N'shopgiay12h@gmail.com', N'0779643464', 0)
INSERT [dbo].[Vendor] ([VendorID], [VendorName], [VendorAddress], [VAT], [VendorEmail], [VendorPhone], [VendorAvailable]) VALUES (6, N'Big C Gò Vấp', N'792 Nguyễn Kiệm, Phường 3, Gò Vấp, Hồ Chí Minh', 101248141, N'bigc_govap@gmail.com', N'02839897750', 0)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (1, 1)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (1, 2)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (1, 3)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (1, 4)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (2, 2)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (2, 4)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (3, 3)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (3, 4)
INSERT [dbo].[VendorProduct] ([VendorID], [ProductID]) VALUES (4, 5)
/****** Object:  Index [UQ__NV__CB9A1CDE6FD374C8]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[NV] ADD UNIQUE NONCLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__OrderDet__E4FEDE2BCA0C3902]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[OrderDetail] ADD UNIQUE NONCLUSTERED 
(
	[orderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__OrderTab__0809337CB230360A]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[OrderTable] ADD UNIQUE NONCLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Product__B40CC6ECFF5A341C]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[Product] ADD UNIQUE NONCLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__ProductC__3224ECEF173335E2]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[ProductCategory] ADD UNIQUE NONCLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Vendor__FC8618D282C0052F]    Script Date: 12/11/2019 6:27:01 PM ******/
ALTER TABLE [dbo].[Vendor] ADD UNIQUE NONCLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [fk_OrderID] FOREIGN KEY([orderID])
REFERENCES [dbo].[OrderTable] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [fk_OrderID]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [fk_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [fk_ProductID]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [fk_userID] FOREIGN KEY([userID])
REFERENCES [dbo].[NV] ([userID])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [fk_userID]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [fk_vendorID] FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [fk_vendorID]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_ProductCategoryID] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategory] ([ProductCategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_ProductCategoryID]
GO
ALTER TABLE [dbo].[VendorProduct]  WITH CHECK ADD  CONSTRAINT [fk_ProductID_VP] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[VendorProduct] CHECK CONSTRAINT [fk_ProductID_VP]
GO
ALTER TABLE [dbo].[VendorProduct]  WITH CHECK ADD  CONSTRAINT [fk_VendorID_VP] FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendor] ([VendorID])
GO
ALTER TABLE [dbo].[VendorProduct] CHECK CONSTRAINT [fk_VendorID_VP]
GO
USE [master]
GO
ALTER DATABASE [PTUD] SET  READ_WRITE 
GO
