create database TestData
go

use TestData
go

create table dbo.Products
	(ProductID int primary key not null,
	ProductName varchar(25) not null,
	Price money null,
	ProductDescription varchar(max) null)
	go

insert dbo.Products (ProductID, ProductName, Price, ProductDescription)
values (1, 'clamp', 12.34, 'workbench clamp')
go

truncate table TestData.dbo.Products;
go

insert Products (ProductID, ProductName, Price)
values (3000, '3 mm bracket', 0.52)
go
INSERT dbo.Products (ProductName, ProductID, Price, ProductDescription)
    VALUES ('Screwdriver', 50, 3.17, 'Flat head')
GO
select * from Products
go

update dbo.Products
	set ProductName = 'flat head screwdriver'
	where ProductID = 50
	go

create view vw_Names
	as
	select ProductName, Price from Products;
	go

select * from vw_Names;
go

create procedure pr_Names @VarPrice money
	as
	begin
		print 'Products less than ' + cast(@VarPrice as varchar(10));
		select ProductName, Price from vw_Names
			where Price < @VarPrice;
			end
			go

execute pr_Names 3.00;
go
