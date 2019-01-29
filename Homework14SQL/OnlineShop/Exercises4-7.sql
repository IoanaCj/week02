--4.Afisati toate produsele
SELECT * FROM Product;
GO

--5.Afisati toti clientii care au in continutul email-ului @wantsome.com
SELECT * FROM Customer WHERE CustomerEmail LIKE '%wantsome.com%';
GO

--6.Afisati suma preturilor pentru fiecare categorie in parte
SELECT p.CategoryId, CategoryName, SUM(ProductPrice) AS TotalPrice
FROM Product p
LEFT JOIN Category c ON p.CategoryId=p.ProductID
GROUP BY p.CategoryId, CategoryName;
GO 

--7.Afisati clientii care au mai mult de 2 comenzi
SELECT CustomerName, COUNT(OrderNumber) AS TotalComenzi
	FROM Customer c JOIN Orders o ON c.CustomerId=o.CustomerId
	GROUP BY CustomerName
	HAVING COUNT(o.OrderNumber)>2;
GO
