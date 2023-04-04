USE Northwind

--products tablosunda defalarca geçen categoryid'yi teke düþürdü.
--SELECT DISTINCT CategoryId FROM Products

--bu güne kadar hangi ülkere kargolama yapýlmýþ
--ülke adýna göre sýrala
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--DISTINCT hesaplama iþlemi yapmaz
--hangi ülkeye ne kadar satýþ yapmýþýz. bu iþlemi DISTINCT yapamaz.
--SELECT O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam TUTAR' 
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam TUTAR' DESC

--en çok satýþ yapýlan 3 ülke
--SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity * OD.UnitPrice) AS 'Toplam TUTAR' 
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam TUTAR' DESC


--elimizde en çok stoðu bulunan ilk 3 ürün
--SELECT TOP(3) P.ProductName, P.UnitsInStock AS 'STOK ADEDÝ'
--FROM Products P
--ORDER BY P.UnitsInStock DESC


--hangi kategoride kaç adet product var (stok miktarý deðil) 10'dan büyük olanlarý göster (WHERE'i kullanamýyoruz!)
--SELECT C.CategoryName, COUNT(*) AS 'ADET ÜRÜN'
--FROM Categories C INNER JOIN Products P
--ON C.CategoryID = P.CategoryID
--GROUP BY CategoryName
--HAVING COUNT(*) > 10
--ORDER BY 'ADET ÜRÜN' DESC

--hangi üründen kaç tane satýlmýþtýr?
--SELECT P.ProductName, SUM(OD.Quantity) AS Adet
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--HOCANIN ÇÖZÜMÜ:-------------
--SELECT P.ProductName, COUNT(*) AS ADET
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY ADET DESC

--en çok kazandýran ilk 3 ürün?
--SELECT TOP(3) P.ProductName, SUM(OD.Quantity) AS Adet
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--HOCANIN ÇÖZÜMÜ:-------------
--SELECT TOP(3) P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY TOTAL DESC


--hangi kargo þirketine ne kadar ödeme yapýlmýþtýr? (freight=kargo ödemesi)
--SELECT S.CompanyName, O.Freight
--FROM Orders O INNER JOIN Shippers S
--ON S.ShipperID = O.ShipVia
--GROUP BY S.ShipperID
--HOCANIN ÇÖZÜMÜ:--------
--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC

--en az ödeme yapýlmýþ kargo þirketi?
--HOCANIN ÇÖZÜMÜ:--------
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL ASC --azdan çok'a sýraladýk.


--hangi müþteriye ne kadar tutarýnda satýþ yapýlmýþtýr?
--SELECT C.CompanyName, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC


--bölgelere göre satýþ tutarlarýný bulalým.
--SELECT R.RegionDescription, SUM(OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Employees E
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
--INNER JOIN Territories T ON T.TerritoryID = ET.TerritoryID
--INNER JOIN Region R ON R.RegionID = T.RegionID
--INNER JOIN Orders O ON O.EmployeeID = E.EmployeeID
--INNER JOIN [Order Details] OD On OD.OrderID = O.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC


--hangi bölgede hangi üründen kaç paralýk satýþ yapýlmýþtýr.
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity * OD.UnitPrice) AS Total  FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
INNER JOIN Region R ON T.RegionID=R.RegionID
INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
INNER JOIN Products P ON OD.ProductID=P.ProductID
GROUP BY R.RegionDescription, P.ProductName
ORDER BY R.RegionDescription, P.ProductName, Total DESC


--hangi bölgede, hangi üründen kaç adet satýþ yapýlmýþtýr.
