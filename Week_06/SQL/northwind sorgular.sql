USE Northwind
--product tablosunu unitprice'a g�re b�y�kten k����e
--SELECT * FROM Products 
--ORDER BY UnitPrice DESC

--fiyat� 100liran�n �zerinde
--SELECT * FROM Products 
--WHERE UnitPrice >= 100

--kategorisi 7 ve 8 olan �r�nler
--SELECT * FROM Products 
--WHERE CategoryID = 7 OR CategoryID = 8

--kategorisi 7 ve 8 olanlardan UnitsInStock <=10 olan �r�nleri listeleyiniz. 
--SELECT * FROM Products
--WHERE (CategoryID = 7 OR CategoryID = 8) AND UnitsInStock <= 10


--kategorisi 7 ve 8 olanlardan UnitsInStock <=10 olan �r�nlerin say�s�.
--SELECT COUNT(*) FROM Products WHERE (CategoryID = 7 OR CategoryID = 8) AND UnitsInStock <= 10

--INNER JOIN ��LEMLER�

--SELECT Products.ProductName, Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID = Categories.CategoryID

--kodu k�saltma
--SELECT P.ProductName, C.CategoryName 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID = C.CategoryID

--SELECT P.ProductName, C.CategoryName, P.UnitPrice 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID = C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=50
--ORDER BY P.UnitPrice DESC

--productname ve suppliercompanyname'i g�steren bir sorgu yaz�n�z.
--SELECT P.ProductName, S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID

--almanyadan tedarik edilen �r�nlerin listesi. productname g�z�kse yeter
--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Germany'

--almanyadan tedarik edilen �r�nlerin toplam tutar�
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Sweden'

--�ay sat��lar�n�n toplam tutar�
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE P.ProductName='Chai'


--almanyaya yap�lm�� olan �ay sat��lar�n�n toplam tutar� (3 tane tablo birle�ti)
--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD 
--ON O.OrderID = OD.OrderID INNER JOIN Products P
--ON OD.ProductID = P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

-- m��teriye yap�lm�� olan sat��lar�n toplam� (Ernst Handel company kullanarak)
SELECT SUM(UnitPrice * Quantity)
FROM [Order Details] OD INNER JOIN ORDERS O
ON OD.OrderID = O.OrderID INNER JOIN Customers C
ON O.CustomerID = C.CustomerID
WHERE C.CompanyName='Ernst Handel'