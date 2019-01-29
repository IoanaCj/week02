--8. Creati un view care va afisa toti clientii si produsele comandate de acestia
IF OBJECT_ID(N'TotalCustomersProducts', N'FN') IS NOT NULL
    DROP FUNCTION CustomersOrderedProducts;
GO

CREATE VIEW TotalCustomersProducts
AS  
SELECT CustomerName, p.ProductID, ProductName, COUNT(*) AS TotalProducts 
FROM Product p
INNER JOIN OrderProduct op ON p.ProductID=op.ProductID
INNER JOIN Orders o ON op.OrderID=o.OrderID
INNER JOIN Customer c ON o.CustomerID=c.CustomerID
GROUP BY CustomerName, p.ProductID, ProductName;
GO  

SELECT * FROM TotalCustomersProducts
