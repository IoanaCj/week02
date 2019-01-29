CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[EmployeeId] [int] NOT NULL,
    )

 CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[CustomerEmail] [nvarchar](50) NOT NULL,
    )

 CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeEmail] [nvarchar](50) NOT NULL, 
    )

CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductDescription] [nvarchar](50) NULL,
	[ProductPrice] [decimal](18, 0) NOT NULL, 
    )

CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[OrderData] [datetime] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[OrderStatus] [nvarchar](50) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	)

CREATE TABLE [dbo].[OrderProduct](
	[OrderProductId] [int] IDENTITY(1,1) NOT NULL,
	[NumberOfProducts] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	)