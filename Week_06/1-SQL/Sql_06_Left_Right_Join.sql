USE Northwind

--SELECT C.CompanyName
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID



--alýþveriþ yapmayan müþteriler
--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--SELECT C.CompanyName
--FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--henüz hiç satýlmamýþ ürünler
--SELECT P.ProductName, OD.ProductID --OD.ProductID'yi göstermek için koyduk gerek yok.
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE OD.ProductID IS NULL

--henüz satýþ yapamamýþ çalýþanlarý listeleyin
SELECT E.FirstName + ' ' + E.LastName as 'Ad Soyad', O.EmployeeID
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID = O.EmployeeID
WHERE O.EmployeeID IS NULL