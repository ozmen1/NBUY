USE Northwind

--products tablosunda defalarca ge�en categoryid'yi teke d���rd�.
--SELECT DISTINCT CategoryId FROM Products

--bu g�ne kadar hangi �lkere kargolama yap�lm��
--�lke ad�na g�re s�rala
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--DISTINCT hesaplama i�lemi yapmaz
--hangi �lkeye ne kadar sat�� yapm���z. bu i�lemi DISTINCT yapamaz.
--SELECT O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam TUTAR' 
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam TUTAR' DESC

--en �ok sat�� yap�lan 3 �lke
--SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam TUTAR' 
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam TUTAR' DESC


--elimizde en �ok sto�u bulunan ilk 3 �r�n
--SELECT TOP(3) P.ProductName, P.UnitsInStock AS 'STOK ADED�'
--FROM Products P
--ORDER BY P.UnitsInStock DESC


--hangi kategoride ka� adet product var (stok miktar� de�il) 10'dan b�y�k olanlar� g�ster (WHERE'i kullanam�yoruz!)
--SELECT C.CategoryName, COUNT(*) AS 'ADET �R�N'
--FROM Categories C INNER JOIN Products P
--ON C.CategoryID = P.CategoryID
--GROUP BY CategoryName
--HAVING COUNT(*) > 10
--ORDER BY 'ADET �R�N' DESC

--hangi �r�nden ka� tane sat�lm��t�r?
--SELECT P.ProductName, SUM(OD.Quantity) AS Adet
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--HOCANIN ��Z�M�:-------------
--SELECT P.ProductName, COUNT(*) AS ADET
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY ADET DESC

--en �ok kazand�ran ilk 3 �r�n?
--SELECT TOP(3) P.ProductName, SUM(OD.Quantity) AS Adet
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--HOCANIN ��Z�M�:-------------
--SELECT TOP(3) P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY TOTAL DESC


--hangi kargo �irketine ne kadar �deme yap�lm��t�r? (freight=kargo �demesi)
--SELECT S.CompanyName, O.Freight
--FROM Orders O INNER JOIN Shippers S
--ON S.ShipperID = O.ShipVia
--GROUP BY S.ShipperID
--HOCANIN ��Z�M�:--------
--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC

--en az �deme yap�lm�� kargo �irketi?
--HOCANIN ��Z�M�:--------
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL ASC --azdan �ok'a s�ralad�k.


--hangi m��teriye ne kadar tutar�nda sat�� yap�lm��t�r?
--SELECT C.CompanyName, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC


--b�lgelere g�re sat�� tutarlar�n� bulal�m.
--SELECT R.RegionDescription, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Employees E
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
--INNER JOIN Territories T ON T.TerritoryID = ET.TerritoryID
--INNER JOIN Region R ON R.RegionID = T.RegionID
--INNER JOIN Orders O ON O.EmployeeID = E.EmployeeID
--INNER JOIN [Order Details] OD On OD.OrderID = O.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC


--hangi b�lgede hangi �r�nden ka� paral�k sat�� yap�lm��t�r.
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS Total  FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
INNER JOIN Region R ON T.RegionID=R.RegionID
INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
INNER JOIN Products P ON OD.ProductID=P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName, Total DESC


--hangi b�lgede, hangi �r�nden ka� adet sat�� yap�lm��t�r.
