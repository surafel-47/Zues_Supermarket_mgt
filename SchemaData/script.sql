USE [master]
GO
/****** Object:  Database [Shop]    Script Date: 31/01/2022 05:05:36 ******/
CREATE DATABASE [Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Shop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Shop] SET  MULTI_USER 
GO
ALTER DATABASE [Shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Shop] SET QUERY_STORE = OFF
GO
USE [Shop]
GO
/****** Object:  User [cashier]    Script Date: 31/01/2022 05:05:36 ******/
CREATE USER [cashier] FOR LOGIN [cashier_login] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [cashier_role]    Script Date: 31/01/2022 05:05:36 ******/
CREATE ROLE [cashier_role]
GO
ALTER ROLE [cashier_role] ADD MEMBER [cashier]
GO
/****** Object:  UserDefinedFunction [dbo].[UDF_getProductName]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[UDF_getProductName](@ProID int)
returns varchar(50) As 
begin
  return (select Name from products where ProID=@ProID);
end
GO
/****** Object:  UserDefinedFunction [dbo].[UDF_getProductStock]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[UDF_getProductStock](@ProID int)
returns int As 
begin
  return (select stock from Product_Stock where ProID=@ProID);
end
GO
/****** Object:  UserDefinedFunction [dbo].[UDF_getUnitPrice]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[UDF_getUnitPrice](@ProID int)
returns decimal(7,2) As 
begin
	Declare @UPrice decimal(7,2);  select @UPrice=UPrice from products where ProID=@ProID;
	return @UPrice;
end
GO
/****** Object:  Table [dbo].[emp_event_log]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emp_event_log](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[emp_id] [int] NOT NULL,
	[fname] [varchar](30) NULL,
	[lname] [varchar](30) NULL,
	[username] [varchar](30) NULL,
	[password] [varchar](30) NULL,
	[position] [varchar](30) NULL,
	[salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[menuid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NULL,
	[category] [varchar](30) NULL,
	[price] [money] NULL,
	[status] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[menuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[od_id] [int] IDENTITY(1,1) NOT NULL,
	[od_proid] [int] NOT NULL,
	[od_name] [varchar](30) NULL,
	[od_unitprice] [money] NOT NULL,
	[od_qty] [int] NOT NULL,
	[od_total] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[od_id] ASC,
	[od_proid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Price_Update_Log]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Price_Update_Log](
	[ProID] [int] NULL,
	[OldPrice] [decimal](7, 2) NOT NULL,
	[NewPrice] [decimal](7, 2) NOT NULL,
	[_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Stock]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Stock](
	[ProID] [int] NOT NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ProID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[UPrice] [decimal](7, 2) NOT NULL,
	[Catagory] [varchar](50) NOT NULL,
	[ProStatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recipt]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recipt](
	[bill_no] [int] IDENTITY(1,1) NOT NULL,
	[od_no] [int] NULL,
	[name] [varchar](30) NULL,
	[price] [money] NULL,
	[qty] [int] NULL,
	[total] [money] NULL,
	[dateof] [date] NULL,
	[paid] [money] NULL,
	[emp_name] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[bill_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](20) NOT NULL,
	[Lname] [varchar](20) NULL,
	[DOB] [date] NULL,
	[Salary] [decimal](10, 2) NULL,
	[Positon] [varchar](20) NULL,
	[sex] [varchar](1) NULL,
	[phoneNo] [varchar](20) NULL,
	[StartDate] [date] NULL,
	[EmpStatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_Update_Log]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_Update_Log](
	[ProID] [int] NULL,
	[ProName] [varchar](25) NOT NULL,
	[stockAdded] [int] NOT NULL,
	[_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketID] [int] NOT NULL,
	[Total] [decimal](7, 2) NOT NULL,
	[_date] [date] NULL,
	[EmpID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction_Details]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction_Details](
	[TicketID] [int] NOT NULL,
	[ProID] [int] NOT NULL,
	[UPrice] [decimal](7, 2) NOT NULL,
	[Qty] [int] NULL,
	[Product_Total] [decimal](7, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC,
	[ProID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (5, CAST(10.00 AS Decimal(7, 2)), CAST(12.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (8, CAST(70.00 AS Decimal(7, 2)), CAST(65.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (12, CAST(60.00 AS Decimal(7, 2)), CAST(80.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (9, CAST(80.00 AS Decimal(7, 2)), CAST(90.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (22, CAST(120.00 AS Decimal(7, 2)), CAST(40.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
INSERT [dbo].[Price_Update_Log] ([ProID], [OldPrice], [NewPrice], [_date]) VALUES (15, CAST(7000.00 AS Decimal(7, 2)), CAST(5500.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date))
GO
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (1, 100)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (2, 191)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (3, 0)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (4, 616)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (5, 387)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (6, 104)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (7, 282)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (8, 85)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (9, 139)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (10, 144)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (11, 230)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (12, 650)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (13, 14)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (14, 87)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (15, 14)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (16, 496)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (17, 20)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (18, 43)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (19, 370)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (20, 289)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (21, 143)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (22, 380)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (23, 446)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (24, 300)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (25, 297)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (26, 198)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (27, 0)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (28, 0)
INSERT [dbo].[Product_Stock] ([ProID], [Stock]) VALUES (29, 0)
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (1, N'Pepsi', CAST(10.00 AS Decimal(7, 2)), N'Beverages and Drinks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (2, N'Coca-Cola', CAST(12.00 AS Decimal(7, 2)), N'Beverages and Drinks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (3, N'Predator Drink', CAST(25.00 AS Decimal(7, 2)), N'Beverages and Drinks', 0)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (4, N'Bottled Water 500ml', CAST(10.00 AS Decimal(7, 2)), N'Beverages and Drinks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (5, N'Bottled Water 1L', CAST(12.00 AS Decimal(7, 2)), N'Beverages and Drinks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (6, N'Sun Chips', CAST(5.00 AS Decimal(7, 2)), N'Foods & Snacks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (7, N'Barber Biscut', CAST(15.00 AS Decimal(7, 2)), N'Foods & Snacks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (8, N'Coco Puff', CAST(65.00 AS Decimal(7, 2)), N'Foods & Snacks', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (9, N'Tuna Fish', CAST(90.00 AS Decimal(7, 2)), N'Canned Goods', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (10, N'Maple Surp', CAST(55.00 AS Decimal(7, 2)), N'Canned Goods', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (11, N'Popular Soap', CAST(25.00 AS Decimal(7, 2)), N'Cleaning Products ', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (12, N'Largo Detergent', CAST(80.00 AS Decimal(7, 2)), N'Cleaning Products ', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (13, N'Phlips Juicer', CAST(3500.00 AS Decimal(7, 2)), N'Home Appliances', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (14, N'Light Bulb', CAST(40.00 AS Decimal(7, 2)), N'Home Appliances', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (15, N'Xezon Micro-wave', CAST(5500.00 AS Decimal(7, 2)), N'Home Appliances', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (16, N'Shola Milk', CAST(22.00 AS Decimal(7, 2)), N'Dairy & Groceries', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (17, N'Sliced Bread', CAST(20.00 AS Decimal(7, 2)), N'Dairy & Groceries', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (18, N'Cocunt Oil', CAST(45.00 AS Decimal(7, 2)), N'Dairy & Groceries', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (19, N'Tooth-Brush', CAST(38.00 AS Decimal(7, 2)), N'Hygiene Products', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (20, N'Body wash', CAST(58.00 AS Decimal(7, 2)), N'Hygiene Products', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (21, N'Mouth wash', CAST(66.00 AS Decimal(7, 2)), N'Hygiene Products', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (22, N'Ink Pen', CAST(40.00 AS Decimal(7, 2)), N'Stationary Products', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (23, N'Small Excercise Book', CAST(60.00 AS Decimal(7, 2)), N'Stationary Products', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (24, N'1kg Avocado', CAST(45.00 AS Decimal(7, 2)), N'Others', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (25, N'1kg Banana', CAST(38.00 AS Decimal(7, 2)), N'Others', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (26, N'Fresh Salad -1kg', CAST(60.00 AS Decimal(7, 2)), N'Others', 1)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (27, N'Jolly Juice', CAST(4.00 AS Decimal(7, 2)), N'Beverages and Drinks', 0)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (28, N'Snap Juice', CAST(23.00 AS Decimal(7, 2)), N'Beverages and Drinks', 0)
INSERT [dbo].[products] ([ProID], [Name], [UPrice], [Catagory], [ProStatus]) VALUES (29, N'Body Scrub', CAST(25.00 AS Decimal(7, 2)), N'Hygiene Products', 0)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (1, N'Abel', N'Derbe', CAST(N'2000-01-01' AS Date), CAST(2500.00 AS Decimal(10, 2)), N'Cashier', N'M', N'0955114572', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (2, N'Biruck', N'Ayele', CAST(N'2003-05-13' AS Date), CAST(3000.00 AS Decimal(10, 2)), N'Cashier', N'M', N'09554376', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (3, N'Ruth', N'Bement', CAST(N'1999-08-10' AS Date), CAST(4000.00 AS Decimal(10, 2)), N'Bagger', N'F', N'096544214', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (4, N'Nati ', N'Tesfaye', CAST(N'2002-10-06' AS Date), CAST(5000.00 AS Decimal(10, 2)), N'Bagger', N'M', N'0977641341', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (5, N'Mikiyas', N'Amlaku', CAST(N'1999-01-21' AS Date), CAST(3500.00 AS Decimal(10, 2)), N'Janitor', N'M', N'0977541133', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (6, N'Lucy', N'Mulgeta', CAST(N'2000-01-01' AS Date), CAST(4000.00 AS Decimal(10, 2)), N'Sales Assistant', N'F', N'0987123423', CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (7, N'Luel', N'Naod', CAST(N'2000-01-01' AS Date), CAST(9000.00 AS Decimal(10, 2)), N'Sales Assistant', N'M', N'0931231341', CAST(N'2022-01-30' AS Date), 0)
INSERT [dbo].[Staff] ([EmpID], [Fname], [Lname], [DOB], [Salary], [Positon], [sex], [phoneNo], [StartDate], [EmpStatus]) VALUES (8, N'Amen', N'Amlacku', CAST(N'2000-06-15' AS Date), CAST(4000.00 AS Decimal(10, 2)), N'Sales Assistant', N'M', N'0931235421', CAST(N'2022-01-30' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (4, N'Bottled Water 500ml', 220, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (8, N'Coco Puff', 44, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (15, N'Xezon Micro-wave', 5, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (16, N'Shola Milk', 200, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (19, N'Tooth-Brush', 230, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (7, N'Barber Biscut', -4, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (6, N'Sun Chips', -3, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (25, N'1kg Banana', -3, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (23, N'Small Excercise Book', -4, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (7, N'Barber Biscut', -3, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (9, N'Tuna Fish', -8, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (6, N'Sun Chips', -10, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (5, N'Bottled Water 1L', -13, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (18, N'Cocunt Oil', -2, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (21, N'Mouth wash', -2, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (16, N'Shola Milk', -4, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (17, N'Sliced Bread', -10, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (20, N'Body wash', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (9, N'Tuna Fish', -3, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (26, N'Fresh Salad -1kg', -2, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (14, N'Light Bulb', -3, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (15, N'Xezon Micro-wave', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (13, N'Phlips Juicer', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (7, N'Barber Biscut', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (8, N'Coco Puff', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (10, N'Maple Surp', -1, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (4, N'Bottled Water 500ml', -4, CAST(N'2022-01-30' AS Date))
INSERT [dbo].[stock_Update_Log] ([ProID], [ProName], [stockAdded], [_date]) VALUES (2, N'Coca-Cola', -9, CAST(N'2022-01-30' AS Date))
GO
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (1, CAST(971.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (2, CAST(958.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (3, CAST(75.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 1)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (4, CAST(163.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 2)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (5, CAST(9120.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 2)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (6, CAST(354.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 2)
INSERT [dbo].[Ticket] ([TicketID], [Total], [_date], [EmpID]) VALUES (7, CAST(135.00 AS Decimal(7, 2)), CAST(N'2022-01-30' AS Date), 1)
GO
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (1, 5, CAST(12.00 AS Decimal(7, 2)), 13, CAST(156.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (1, 6, CAST(5.00 AS Decimal(7, 2)), 10, CAST(50.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (1, 7, CAST(15.00 AS Decimal(7, 2)), 3, CAST(45.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (1, 9, CAST(90.00 AS Decimal(7, 2)), 8, CAST(720.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 9, CAST(90.00 AS Decimal(7, 2)), 3, CAST(270.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 16, CAST(22.00 AS Decimal(7, 2)), 4, CAST(88.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 17, CAST(20.00 AS Decimal(7, 2)), 10, CAST(200.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 18, CAST(45.00 AS Decimal(7, 2)), 2, CAST(90.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 20, CAST(58.00 AS Decimal(7, 2)), 1, CAST(58.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 21, CAST(66.00 AS Decimal(7, 2)), 2, CAST(132.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (2, 26, CAST(60.00 AS Decimal(7, 2)), 2, CAST(120.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (3, 6, CAST(5.00 AS Decimal(7, 2)), 3, CAST(15.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (3, 7, CAST(15.00 AS Decimal(7, 2)), 4, CAST(60.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (4, 2, CAST(12.00 AS Decimal(7, 2)), 9, CAST(108.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (4, 4, CAST(10.00 AS Decimal(7, 2)), 4, CAST(40.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (4, 6, CAST(5.00 AS Decimal(7, 2)), 3, CAST(15.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (5, 13, CAST(3500.00 AS Decimal(7, 2)), 1, CAST(3500.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (5, 14, CAST(40.00 AS Decimal(7, 2)), 3, CAST(120.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (5, 15, CAST(5500.00 AS Decimal(7, 2)), 1, CAST(5500.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (6, 23, CAST(60.00 AS Decimal(7, 2)), 4, CAST(240.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (6, 25, CAST(38.00 AS Decimal(7, 2)), 3, CAST(114.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (7, 7, CAST(15.00 AS Decimal(7, 2)), 1, CAST(15.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (7, 8, CAST(65.00 AS Decimal(7, 2)), 1, CAST(65.00 AS Decimal(7, 2)))
INSERT [dbo].[Transaction_Details] ([TicketID], [ProID], [UPrice], [Qty], [Product_Total]) VALUES (7, 10, CAST(55.00 AS Decimal(7, 2)), 1, CAST(55.00 AS Decimal(7, 2)))
GO
ALTER TABLE [dbo].[emp_event_log] ADD  DEFAULT (getdate()) FOR [_date]
GO
ALTER TABLE [dbo].[Price_Update_Log] ADD  DEFAULT (getdate()) FOR [_date]
GO
ALTER TABLE [dbo].[Product_Stock] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ('Others') FOR [Catagory]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ((1)) FOR [ProStatus]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[Staff] ADD  DEFAULT ((1)) FOR [EmpStatus]
GO
ALTER TABLE [dbo].[stock_Update_Log] ADD  DEFAULT (getdate()) FOR [_date]
GO
ALTER TABLE [dbo].[Ticket] ADD  DEFAULT (getdate()) FOR [_date]
GO
ALTER TABLE [dbo].[Transaction_Details] ADD  DEFAULT ((1)) FOR [Qty]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([od_proid])
REFERENCES [dbo].[menu] ([menuid])
GO
ALTER TABLE [dbo].[Price_Update_Log]  WITH CHECK ADD FOREIGN KEY([ProID])
REFERENCES [dbo].[products] ([ProID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Stock]  WITH CHECK ADD FOREIGN KEY([ProID])
REFERENCES [dbo].[products] ([ProID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock_Update_Log]  WITH CHECK ADD FOREIGN KEY([ProID])
REFERENCES [dbo].[products] ([ProID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD FOREIGN KEY([EmpID])
REFERENCES [dbo].[Staff] ([EmpID])
GO
ALTER TABLE [dbo].[Transaction_Details]  WITH CHECK ADD FOREIGN KEY([ProID])
REFERENCES [dbo].[products] ([ProID])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[USP_AddEmployee]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_AddEmployee]
(
	@Fname varchar(20), @Lname varchar(20), @DOB Date, @Salary decimal(10,2),@sex varchar(1), @phoneNo varchar(10), @Position varchar(20)  
)
as
begin
  Insert into Staff(Fname,Lname,DOB,Salary, sex, phoneNo,Positon,StartDate,EmpStatus)
		     values(@Fname,@Lname,@DOB,@Salary,@sex,@phoneNo,@Position,default,default)
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddProduct]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_AddProduct]
(
	@Name varchar(20), @UPrice decimal(7,2), @catagory varchar(20), @Initial_Stock int 
)
as
begin
	Insert into products(Name,UPrice,Catagory,ProStatus)
		          values(@name,@UPrice,@catagory,default)

	Insert into Product_Stock(ProID,Stock)
					   values((select max(ProID) from products),@Initial_Stock) 
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_AddToSTOCK]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_AddToSTOCK](@ProID int,@Amount int)
as
begin
	Update Product_Stock  set	Stock= Stock + @Amount  where ProID=@ProID; --Updateing product stock by amount
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_backUpDataBase]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_backUpDataBase]
as
begin
	declare @fileName varchar(50)='C:\shop '+convert(varchar(10),getDate())+'.bak'
	declare @dbname varchar(50)='shop'
	backup Database @dbname to disk = @fileName
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNextTicketID]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_GetNextTicketID]
as
begin
   select Max(TicketID)+1  as TicketID from Transaction_Details --Generating the Next Ticket ID + 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_RemoveEmployee]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_RemoveEmployee]( @EmpID int)
as
begin
  update Staff
  set EmpStatus=0
  where @EmpID=EmpID;
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_RemoveProduct]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_RemoveProduct]( @ProID int )
as
begin
	Update products  set	ProStatus=0  where ProID=@ProID; --setting status of product to Zero
	Update Product_Stock  set	Stock=0  where ProID=@ProID; --settting product stock to zero
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Ticket]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_Ticket](@EmpID int=1 )
as
begin
	Declare @TicketID int;
	Select  @TicketID=max(TicketID)from Transaction_Details;--Storing Value of Last Ticket Added

	Insert Ticket(TicketID,Total,_date,EmpID)  --inserting into Ticket table, The Transaction Details
	Select @TicketID,sum(Product_Total), getDate(), @EmpID
	From Transaction_Details
	Where TicketID=@TicketID;

	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Transaction]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_Transaction](@ProID int, @Qty int,@TicketID int)
as
begin
	if(@Qty>dbo.UDF_getProductStock(@ProID)) --Chechking if Qty Reqested is greater than What is in Stock
		SET @Qty=(dbo.UDF_getProductStock(@ProID)) -- If Qty Requested id greater, set Qty Requested to all in Stock, so that Maxium is Sold
	
	SET @TicketID=ISNULL(@TicketID,1)-- Setting Ticket ID to One Just Incase it's Null

	Update Product_Stock set Stock=Stock - @Qty where ProID=@ProID;  --Reducing Product Stock
	
	Insert into Transaction_Details(TicketID,ProID,UPrice,Qty,Product_Total)  --inserting into Transaction_Details Table
	values(@TicketID,@ProID,dbo.UDF_getUnitPrice(@ProID),@Qty, Convert(Decimal(7,2),dbo.UDF_getUnitPrice(@ProID)*@Qty))
	
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_updatePrice]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_updatePrice](@ProID int,@newPrice decimal(7,2) )
as
begin
	Update Products set	UPrice=@newPrice where ProID=@ProID; --Updateing product Unit Price
	return 1;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewActiveProductsForRemoving]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewActiveProductsForRemoving](@searchInput varchar(20))
as
begin
	select ProID, Name as 'Product Name', Catagory 
	FROM Products 
     where (ProStatus = 1) AND ([Name] like '%' + @searchInput+ '%' OR ProID like '%' + @searchInput+ '%')
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewActiveProductsForRemovingNosearch]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewActiveProductsForRemovingNosearch]
as
begin
	select ProID, Name as 'Product Name', Catagory 
	FROM Products 
    where (ProStatus = 1)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllActiveEmployees]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewAllActiveEmployees](@searchInput varchar(20))
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,sex 
	FROM staff 
    where (EmpStatus = 1) AND  
	      (Fname like '%'+@searchInput+'%' OR Lname like '%'+@searchInput+'%' OR EmpID like '%'+@searchInput+'%') 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllActiveEmployeesNoSearch]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewAllActiveEmployeesNoSearch]
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,sex 
	FROM staff 
    where (EmpStatus = 1)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllActiveProducts]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewAllActiveProducts](@searchInput varchar(20))
as
begin
	select ProID, [Name] as 'Product Name', UPrice 'Unit Price' 
	from Products 
    where (ProStatus = 1) AND  ([Name] like '%' + @searchInput+ '%' OR ProID like '%' + @searchInput+ '%')
end



GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllEmployees]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewAllEmployees](@searchInput varchar(20))
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,case when sex='M' OR sex='m' then 'Male'
																				 when sex='F' OR sex='f' then 'Female' end as Sex,			
																					PhoneNo,StartDate,Case EmpStatus 
																										When 0 Then 'Removed' 
																										When 1 Then 'Active' 
																										end  as 'Status'
	FROM staff 
    where Fname like '%'+@searchInput+'%' OR Lname like '%'+@searchInput+'%' OR EmpID like '%'+@searchInput+'%'  
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllEmployeesNoSearch]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewAllEmployeesNoSearch]
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,case when sex='M' OR sex='m' then 'Male'
																				 when sex='F' OR sex='f' then 'Female' end as Sex,			
																					PhoneNo,StartDate,
																			Case EmpStatus 
																				When 0 Then 'Removed' 
																				When 1 Then 'Active' end  as 'Status'
	FROM staff 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewAllProducts]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewAllProducts](@searchInput varchar(20))
as
begin
	select ProID, [Name] as 'Product Name', UPrice as 'Unit Price',Catagory,Case ProStatus 
																				When 0 Then 'Removed' 
																				When 1 Then 'Active' 
																				end  as 'Status'
	FROM products 
    where [Name] like '%'+@searchInput+'%' OR ProID like '%'+@searchInput+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewPriceUpdateLogs]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewPriceUpdateLogs] 
as
begin
	select Products.ProID,Products.[Name],OldPrice,NewPrice,_date as 'Update Date' 
	from Price_Update_Log,products
	where Products.ProID=Price_Update_Log.ProID;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewProductDetailsWithStock]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewProductDetailsWithStock](@searchInput varchar(25),@catagory varchar(20))
as
begin

	if(@catagory='All')
	begin
		select  products.ProID as 'Product ID', Name as 'Product Name', UPrice as 'Unit Price', Catagory, Stock  
		from products,product_stock
		Where (products.ProStatus = 1 AND products.proID=product_stock.ProID ) AND
          (name like '%' +@searchInput +'%' OR products.ProID like '%' +@searchInput +'%')  AND 
		  Product_Stock.stock>0;
	end
	else
	begin
		select  products.ProID as 'Product ID', Name as 'Product Name', UPrice as 'Unit Price', Catagory, Stock  
		from products,product_stock
		Where (products.ProStatus = 1 AND products.proID=product_stock.ProID ) AND
          (name like '%' +@searchInput +'%' OR products.ProID like '%' +@searchInput +'%')  AND 
		  Product_Stock.stock>0 AND Catagory like '%' + @catagory + '%'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewProductStock]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewProductStock](@searchInput varchar(25) )
as
begin
	select  products.ProID as 'ProID', Name as 'Product Name', Catagory, Stock   
    from products,product_stock  
    Where ( products.ProStatus = 1 AND products.proID=product_stock.ProID ) 
      AND ( name like '%'+@searchInput+'%' OR products.ProID like '%'+@searchInput+'%') ;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewStockUpdateLogs]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewStockUpdateLogs]
as
begin
	select ProID, ProName as 'Product Name', stockAdded as 'Stock Added', _date as 'Date'
	FROM stock_Update_Log 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ViewTicketDetails]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_ViewTicketDetails](@TicketID int)
as
begin
	Select  Transaction_Details.ProID,products.Name,Transaction_Details.UPrice as 'Unit Price',Qty as 'Quantity',Product_Total as 'Product Total'
	from Transaction_Details,products
	where Transaction_Details.ProID=products.ProID AND TicketID=@TicketID
end


GO
/****** Object:  StoredProcedure [dbo].[USP_ViewTicketsTable]    Script Date: 31/01/2022 05:05:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_ViewTicketsTable]
as
begin
	Select TicketID,Total,_date as 'Purchase Date',Staff.EmpID,Upper(Substring(Staff.Fname,0,2))+'.'+Staff.Lname as 'Cashier on Duty' 
	from Ticket,Staff
	where Ticket.EmpID=Staff.EmpID
end

GO
USE [master]
GO
ALTER DATABASE [Shop] SET  READ_WRITE 
GO
