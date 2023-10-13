
go	-- Creating 'Shop' Database
IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'Shop') 
	CREATE DATABASE Shop

go -- using Database
use shop; 

		--Creating Tables
		
go--Creating products Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'products')
create table products
(
	ProID int identity(1,1) primary key,
	Name varchar(50) not null,
	UPrice decimal(7,2) not null,
	Catagory varchar(50) not null default 'Others',
	ProStatus int not null default 1 
)

go--Creating Products_Stock Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'Product_Stock')
create table Product_Stock
(
	ProID int primary Key References Products(ProID) ON Delete Cascade,
	Stock int default 0
)

go--Creating Transaction_Details Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'Transaction_Details')
create table Transaction_Details
(
	TicketID int,
	ProID int References Products(ProID) ON Delete Cascade,
	UPrice decimal(7,2) not null,
	Qty int  default 1,
	Product_Total decimal(7,2) not null,
	primary key(TicketID,ProID) --composite primary key
)


go--Creating Staff Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'Staff')
create table Staff
(
	EmpID int primary key identity(1,1),
	Fname VarChar(20) not null,
	Lname VarChar(20),
	DOB	Date,
	Salary	Decimal(10,2),
	Positon	varchar(20),
	sex varchar(1),
	phoneNo varchar(20),
	StartDate Date default getDate(),
	EmpStatus int not null default 1
)

go--Creating Ticket Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'Ticket')
create table Ticket
(
	TicketID int primary key,
	Total decimal(7,2) not null,
	_date Date default getDate(),
	EmpID int references Staff(EmpID)
)

go--Creating Price_Update_Log Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'Price_Update_Log')
create table Price_Update_Log
(
	ProID int References Products(ProID) ON Delete Cascade,
	OldPrice decimal(7,2) not null,
	NewPrice decimal(7,2) not null,
	_date Date default getDate(),
)

go--Creating Stock_Update_Log Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'stock_Update_Log')
create table stock_Update_Log
(
	ProID int References Products(ProID) ON Delete Cascade,
	ProName varchar(25) not null,
	stockAdded int not null,
	_date Date default getDate(),
)

go--Creating Emp Event Log Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES  WHERE TABLE_SCHEMA = 'dbo'  AND TABLE_NAME = 'emp_event_log')
create table emp_event_log
(
	EventID int primary key identity(1,1),
	[Description] varchar(100) not null,
	_date Date default getDate(),
)