USE [OnlineShop]
GO

INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1001,'2018-02-03',1,'Approved',250);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1002,'2018-03-02',1,'Pending',150);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1003,'2018-02-10',1,'Approved',500);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1004,'2018-02-15',2,'Received',450);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1005,'2018-03-15',2,'Pending',200);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1006,'2018-03-03',2,'Received',70);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1007,'2018-03-25',3,'Approved',320);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1008,'2018-02-15',3,'Approved',105);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1009,'2018-03-24',3,'Received',40);
GO
INSERT INTO [dbo].[Order]
           ([OrderNumber]
           ,[OrderData]
           ,[CustomerId]
           ,[OrderStatus]
           ,[TotalPrice])
     VALUES
           (1010,'2018-03-15',4,'Approved',190);
GO

