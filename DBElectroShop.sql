USE [master]
GO
/****** Object:  Database [ElectroShop]    Script Date: 14.12.2022 0:04:45 ******/
CREATE DATABASE [ElectroShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ElectroShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ElectroShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ElectroShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ElectroShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ElectroShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ElectroShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ElectroShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ElectroShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ElectroShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ElectroShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ElectroShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [ElectroShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ElectroShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ElectroShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ElectroShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ElectroShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ElectroShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ElectroShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ElectroShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ElectroShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ElectroShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ElectroShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ElectroShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ElectroShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ElectroShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ElectroShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ElectroShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ElectroShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ElectroShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ElectroShop] SET  MULTI_USER 
GO
ALTER DATABASE [ElectroShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ElectroShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ElectroShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ElectroShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ElectroShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ElectroShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ElectroShop] SET QUERY_STORE = OFF
GO
USE [ElectroShop]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 14.12.2022 0:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPrices]    Script Date: 14.12.2022 0:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPrices](
	[ID] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_ProductPrices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Storage]    Script Date: 14.12.2022 0:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Count] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types]    Script Date: 14.12.2022 0:04:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (1, N'Acer', N'USA')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (2, N'ASUSs', N'USA')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (3, N'Dexp', N'China')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (4, N'Hunter', N'China')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (5, N'YourDad', N'Poland')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (6, N'Samsung', N'China')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (7, N'Grand', N'USA')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (8, N'Safaricus', N'UK')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (9, N'RealME', N'China')
INSERT [dbo].[Companies] ([ID], [Name], [Address]) VALUES (10, N'Xiaomi', N'China')
GO
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (1, 13000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (2, 190000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (3, 199999.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (4, 50000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (5, 50000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (6, 60000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (7, 20000.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (8, 500.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (9, 500.0000)
INSERT [dbo].[ProductPrices] ([ID], [Price]) VALUES (10, 500.0000)
GO
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (1, N'TravelMate B118-M', 3, 2, 1)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (2, N'TravelMate B117-M', 3, 2, 1)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (3, N'Aspire 8', 3, 2, 1)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (4, N'Aspire 87', 3, 2, 1)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (5, N'Hunter X', 3, 2, 1)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (6, N'Tolder', 3, 3, 2)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (7, N'Gordost', 25, 10, 2)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (8, N'Hunter', 114, 1, 5)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (9, N'Bullet', 166, 1, 7)
INSERT [dbo].[Storage] ([ID], [Name], [Count], [TypeID], [CompanyID]) VALUES (10, N'Manter', 117, 1, 8)
GO
INSERT [dbo].[Types] ([ID], [Name]) VALUES (1, N'Flash')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (2, N'Laptop')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (3, N'Phone')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (4, N'SSD')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (5, N'HDD')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (6, N'Watches')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (7, N'Стиральная машина')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (8, N'Charger')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (9, N'Display')
INSERT [dbo].[Types] ([ID], [Name]) VALUES (10, N'System Blockus')
GO
ALTER TABLE [dbo].[ProductPrices]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrices_Storage] FOREIGN KEY([ID])
REFERENCES [dbo].[Storage] ([ID])
GO
ALTER TABLE [dbo].[ProductPrices] CHECK CONSTRAINT [FK_ProductPrices_Storage]
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_Companies] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Companies] ([ID])
GO
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Storage_Companies]
GO
ALTER TABLE [dbo].[Storage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_Types] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Types] ([ID])
GO
ALTER TABLE [dbo].[Storage] CHECK CONSTRAINT [FK_Storage_Types]
GO
USE [master]
GO
ALTER DATABASE [ElectroShop] SET  READ_WRITE 
GO
