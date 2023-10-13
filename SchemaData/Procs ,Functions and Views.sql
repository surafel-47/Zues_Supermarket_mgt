go
use Shop;


alter Proc USP_CreateRole
as
begin
	CREATE LOGIN cashier_login
	WITH PASSWORD = '1234', DEFAULT_DATABASE = shop

	CREATE USER cashier
	  FOR LOGIN cashier_login

	CREATE ROLE cashier_role;
	EXEC sp_addrolemember cashier_role , cashier;

	DENY DELETE ON dbo.Staff to cashier_role
	DENY DELETE,UPDATE ON dbo.products TO cashier_role
	DENY DELETE, UPDATE ON Staff TO cashier_role
	DENY DELETE ON Ticket to cashier_role
END

go -- UDF to get UnitPrice
Create function UDF_getUnitPrice(@ProID int)
returns decimal(7,2) As 
begin
  return (select UPrice from products where ProID=@ProID);
end

go -- UDF to Get Product Name
Create function UDF_getProductName(@ProID int)
returns varchar(50) As 
begin
  return (select Name from products where ProID=@ProID);
end

go -- UDF to Get Product Stock
Create function UDF_getProductStock(@ProID int)
returns int As 
begin
  return (select stock from Product_Stock where ProID=@ProID);
end


go -- USP to Add New Employee
create Proc USP_AddEmployee
(
	@Fname varchar(20), @Lname varchar(20), @DOB Date, @Salary decimal(10,2),@sex varchar(1), @phoneNo varchar(10), @Position varchar(20)  
)
as
begin
  Insert into Staff(Fname,Lname,DOB,Salary, sex, phoneNo,Positon,StartDate,EmpStatus)
		     values(@Fname,@Lname,@DOB,@Salary,@sex,@phoneNo,@Position,default,default)
	return 1;
end

go -- USP Get Next Ticket ID
create Proc USP_GetNextTicketID
as
begin
   select Max(TicketID)+1  as TicketID from Transaction_Details --Generating the Next Ticket ID + 1;
end

go -- USP to Remove Employee
Create Proc USP_RemoveEmployee( @EmpID int)
as
begin
  update Staff
  set EmpStatus=0
  where EmpID=@EmpID
  return 1;
end

go -- USP to Add New Product
Create Proc USP_AddProduct
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


go -- USP to Remove Product
Create Proc USP_RemoveProduct( @ProID int )
as
begin
	Update products  set	ProStatus=0  where ProID=@ProID; --setting status of product to Zero
	Update Product_Stock  set	Stock=0  where ProID=@ProID; --settting product stock to zero
	return 1;
end

go -- USP Add to Stock
Create Proc USP_AddToSTOCK(@ProID int,@Amount int)
as
begin
	Update Product_Stock  set	Stock= Stock + @Amount  where ProID=@ProID; --Updateing product stock by amount
	return 1;
end

go -- USP Update Product Price
create Proc USP_updatePrice(@ProID int,@newPrice decimal(7,2) )
as
begin
	Update Products set	UPrice=@newPrice where ProID=@ProID; --Updateing product Unit Price
	return 1;
end

go -- USP View Product & Stock
create Proc USP_ViewProductStock(@searchInput varchar(25) )
as
begin
	select  products.ProID as 'ProID', Name as 'Product Name', Catagory, Stock   
    from products,product_stock  
    Where ( products.ProStatus = 1 AND products.proID=product_stock.ProID ) 
      AND ( name like '%'+@searchInput+'%' OR products.ProID like '%'+@searchInput+'%') ;
end


go -- USP View Product details with Stock
alter Proc USP_ViewProductDetailsWithStock(@searchInput varchar(25),@catagory varchar(20))
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



go -- USP View Price Update Logs
create Proc USP_ViewPriceUpdateLogs 
as
begin
	select Products.ProID,Products.[Name],OldPrice,NewPrice,_date as 'Update Date' 
	from Price_Update_Log,products
	where Products.ProID=Price_Update_Log.ProID;
end

go -- USP View Tickets Table 
alter Proc USP_ViewTicketsTable
as
begin
	Select TicketID,Total,_date as 'Purchase Date',Staff.EmpID,Upper(Substring(Staff.Fname,0,2))+'.'+Staff.Lname as 'Cashier on Duty' 
	from Ticket,Staff
	where Ticket.EmpID=Staff.EmpID
end

go --USP View Specfic Ticket's Details From Transaction_Details Table 
create Proc USP_ViewTicketDetails(@TicketID int)
as
begin
	Select  Transaction_Details.ProID,products.Name,Transaction_Details.UPrice as 'Unit Price',Qty as 'Quantity',Product_Total as 'Product Total'
	from Transaction_Details,products
	where Transaction_Details.ProID=products.ProID AND TicketID=@TicketID
end

go -- USP Make Transaction
create Proc USP_Transaction(@ProID int, @Qty int,@TicketID int)
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

go -- USP Make Ticket
create Proc USP_Ticket(@EmpID int=1 )
as
begin
	Declare @TicketID int;
	Select  @TicketID=max(TicketID) from Transaction_Details;--Storing Value of Last Ticket Added

	Insert Ticket(TicketID,Total,_date,EmpID)  --inserting into Ticket table, The Transaction Details
	Select @TicketID,sum(Product_Total), getDate(), @EmpID
	From Transaction_Details
	Where TicketID=@TicketID;

	return 1;
end

go-- USP to View ALL Employees with search Param
create Proc USP_ViewAllEmployees(@searchInput varchar(20))
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,case when sex='M' OR sex='m' then 'Male'
																				 when sex='F' OR sex='f' then 'Female' end as Sex,			
																					PhoneNo,StartDate,
																			Case EmpStatus 
																				When 0 Then 'Removed' 
																				When 1 Then 'Active' end  as 'Status'
	FROM staff 
    where Fname like '%'+@searchInput+'%' OR Lname like '%'+@searchInput+'%' OR EmpID like '%'+@searchInput+'%'  
end


go-- USP to View ALL Employees
alter Proc USP_ViewAllEmployeesNoSearch
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


go-- USP to View ALL Active Employees/Not Fired Employees with search param
create Proc USP_ViewAllActiveEmployees(@searchInput varchar(20))
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,sex 
	FROM staff 
    where (EmpStatus = 1) AND  
	      (Fname like '%'+@searchInput+'%' OR Lname like '%'+@searchInput+'%' OR EmpID like '%'+@searchInput+'%') 
end


go-- USP to View ALL Active Employees/Not Fired Employees 
create Proc USP_ViewAllActiveEmployeesNoSearch
as
begin
	select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,sex 
	FROM staff 
    where (EmpStatus = 1)
end


go-- USP to View ALL Products
create Proc USP_ViewAllProducts(@searchInput varchar(20))
as
begin
	select ProID, [Name] as 'Product Name', UPrice as 'Unit Price',Catagory,Case ProStatus 
																				When 0 Then 'Removed' 
																				When 1 Then 'Active' 
																				end  as 'Status'
	FROM products 
    where [Name] like '%'+@searchInput+'%' OR ProID like '%'+@searchInput+'%'
end


go-- USP to View ALL Active Products
alter Proc USP_ViewAllActiveProducts(@searchInput varchar(20))
as
begin
	select ProID, [Name] as 'Product Name', UPrice 'Unit Price' 
	from Products 
    where (ProStatus = 1) AND  ([Name] like '%' + @searchInput+ '%' OR ProID like '%' + @searchInput+ '%')
end



go-- USP to View ALL Active Products for Removing with search param
create Proc USP_ViewActiveProductsForRemoving(@searchInput varchar(20))
as
begin
	select ProID, Name as 'Product Name', Catagory 
	FROM Products 
    where (ProStatus = 1) AND ([Name] like '%' + @searchInput+ '%' OR ProID like '%' + @searchInput+ '%')
end


go-- USP to View ALL Active Products for Removing
create Proc USP_ViewActiveProductsForRemovingNosearch
as
begin
	select ProID, Name as 'Product Name', Catagory 
	FROM Products 
    where (ProStatus = 1)
end


go-- USP to View Stock_Update Logs Table
create Proc USP_ViewStockUpdateLogs
as
begin
	select ProID, ProName as 'Product Name', stockAdded as 'Stock Added', _date as 'Date'
	FROM stock_Update_Log 
end

go  -- trigger to log price changes on Products
create trigger trgPriceUpdateLog
ON Products For Update
as 
begin
	insert into Price_Update_Log(ProID,OldPrice,NewPrice,_date)
	select I.ProID, D.UPrice, I.UPrice,getDate()
	from inserted I,deleted D
end

go  -- trigger to log price changes on Products
create trigger trgStockUpdateLog
ON Product_stock For Update
as 
begin
	insert into stock_Update_Log(ProID,ProName,stockAdded,_date)
	select I.ProID, P.Name ,I.Stock-D.Stock ,getDate()
	from inserted I,deleted D,products P
	Where I.ProID=P.ProID
end


go  -- trigger to log when new employee added 
create trigger trgSEmpAdded
ON staff For insert
as 
begin
	insert into emp_event_log([Description],_date)
	select 'New Employee Added|  Name:'+I.Fname+' '+I.Lname,GETDATE()	
	from Inserted as I
end


go  -- trigger to log when employee is removed 
create trigger trgSEmpRemoved
ON staff For update
as 
begin
	insert into emp_event_log([Description],_date)
	select 'Employee was Removed|  Name:'+I.Fname+' '+I.Lname,GETDATE()	
	from Inserted as I
end


go-- USP to back up database
alter Proc USP_backUpDataBase
as
begin
	declare @fileName varchar(50)='C:\shop '+convert(varchar(20),getDate())+'.bak'
	declare @dbname varchar(50)='shop'
	backup Database @dbname to disk = @fileName
end


	