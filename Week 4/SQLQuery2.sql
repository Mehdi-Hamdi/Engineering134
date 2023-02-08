SELECT s.CompanyName AS "Company Name", 
AVG(p.UnitsOnOrder) AS "Average of units on order"
FROM Products p
INNER JOIN Suppliers s
ON p.SupplierID = s.SupplierID
GROUP BY s.CompanyName
