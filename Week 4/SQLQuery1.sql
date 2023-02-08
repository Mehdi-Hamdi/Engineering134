SELECT CustomerID, CompanyName,
Address, city, PostalCode, Country
FROM Customers
WHERE city = 'Paris' OR city = 'London'