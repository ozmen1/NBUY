USE Northwind
--product tablosunu unitprice'a göre büyükten küçüðe
--SELECT * FROM Products 
--ORDER BY UnitPrice DESC

--fiyatý 100liranýn üzerinde
--SELECT * FROM Products 
--WHERE UnitPrice >= 100

--kategorisi 7 ve 8 olan ürünler
--SELECT * FROM Products 
--WHERE CategoryID = 7 OR CategoryID = 8

--kategorisi 7 ve 8 olanlardan UnitsInStock <=10 olan ürünleri listeleyiniz. 
--SELECT * FROM Products
--WHERE (CategoryID = 7 OR CategoryID = 8) AND UnitsInStock <= 10


--kategorisi 7 ve 8 olanlardan UnitsInStock <=10 olan ürünlerin sayýsý.
--SELECT COUNT(*) FROM Products WHERE (CategoryID = 7 OR CategoryID = 8) AND UnitsInStock <= 10

--INNER JOIN ÝÞLEMLERÝ

--SELECT Products.ProductName, Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID = Categories.CategoryID

--kodu kýsaltma
--SELECT P.ProductName, C.CategoryName 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID = C.CategoryID

--SELECT P.ProductName, C.CategoryName, P.UnitPrice 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID = C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=50
--ORDER BY P.UnitPrice DESC

--productname ve suppliercompanyname'i gösteren bir sorgu yazýnýz.
--SELECT P.ProductName, S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID

--almanyadan tedarik edilen ürünlerin listesi. productname gözükse yeter
--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Germany'

--almanyadan tedarik edilen ürünlerin toplam tutarý
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Sweden'

--çay satýþlarýnýn toplam tutarý
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE P.ProductName='Chai'


--almanyaya yapýlmýþ olan çay satýþlarýnýn toplam tutarý (3 tane tablo birleþti)
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD 
--ON O.OrderID = OD.OrderID INNER JOIN Products P
--ON OD.ProductID = P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

-- müþteriye yapýlmýþ olan satýþlarýn toplamý (Ernst Handel company kullanarak)
SELECT SUM(UnitPrice * Quantity)
FROM [Order Details] OD INNER JOIN ORDERS O
ON OD.OrderID = O.OrderID INNER JOIN Customers C
ON O.CustomerID = C.CustomerID
WHERE C.CompanyName='Ernst Handel'