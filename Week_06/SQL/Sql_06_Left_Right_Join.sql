USE Northwind

--SELECT C.CompanyName
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID



--al��veri� yapmayan m��teriler
--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--SELECT C.CompanyName
--FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--hen�z hi� sat�lmam�� �r�nler
--SELECT P.ProductName, OD.ProductID --OD.ProductID'yi g�stermek i�in koyduk gerek yok.
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE OD.ProductID IS NULL

--hen�z sat�� yapamam�� �al��anlar� listeleyin
SELECT E.FirstName + ' ' + E.LastName as 'Ad Soyad', O.EmployeeID
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID = O.EmployeeID
WHERE O.EmployeeID IS NULL