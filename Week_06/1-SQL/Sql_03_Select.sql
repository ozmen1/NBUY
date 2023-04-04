--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar


--F�LTRELEME

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD', adres as 'ADRES' FROM Doktorlar

--SELECT * FROM Doktorlar WHERE adSoyad ='Tuna Sefer'

--SELECT * FROM Doktorlar WHERE adSoyad !='Tuna Sefer'

--SELECT * FROM Doktorlar WHERE NOT adSoyad = 'Tuna Sefer'

--SELECT * FROM Doktorlar WHERE id=3 OR id=6

--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='�zmi

--SELECT * FROM Doktorlar WHERE id >= 6

--SELECT * FROM Doktorlar WHERE adres IN ('�zmir','�stanbul')

--ad� A harfi ile ba�layan doktorlar?
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'a%'
--�lk harfi a olan geri kalan� ne olursa olsun...

--ad soyad� r ile bitenler
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%r'

--i�inde s ge�en
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'

--ikinci harfi e olanlar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'

--ilk harfi d 
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'D_m%'


--SIRALAMA ��LEMLER�

--artan
--SELECT * FROM Doktorlar ORDER BY adSoyad

--azalan
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC

--bolumid'ye g�re b�y�kten k����e
--SELECT * FROM Doktorlar ORDER BY bolumId DESC

--adrese g�re s�rala (A-Z)
--SELECT * FROM Doktorlar ORDER BY adres 

--adrese g�re s�rala (A-Z) ve doktor adsoyad s�rala (Z-A) 
--SELECT * FROM Doktorlar ORDER BY adres ASC, adSoyad DESC



--HESAPLAMA ��LEMLER�



--USE KutuphaneDb
--SELECT * FROM Kitaplar

--SELECT MIN(sayfaSayisi) as 'En Az Sayfa Say�s�' FROM Kitaplar

--SELECT MAX(sayfaSayisi) as 'En Y�ksek Sayfa Say�s�' FROM Kitaplar

--SELECT COUNT(*) as 'Kolon Say�s�' FROM Kitaplar

--USE HastaneDb
--b�l�m� olan doktorlar�n say�s�
--SELECT COUNT(bolumId) FROM Doktorlar


--USE KutuphaneDb
--elimizdeki kitaplar�n ortalama sayfa say�s�
--SELECT AVG(sayfaSayisi) FROM Kitaplar

--toplam stok adedi
--SELECT SUM(stok) FROM Kitaplar

--tane sayfa var (t�m kitaplar�n toplam sayfas�) (bunu �r�n fiyat�*stok gibi d���n)
--SELECT SUM(stok*sayfaSayisi) FROM Kitaplar


--STRING ��LEMLER�

--USE HastaneDb
--SELECT LEN('Kerem �zmen')
--SELECT adSoyad, LEN(adSoyad) as 'Ad�n�n toplam uzunlu�u' FROM Doktorlar

--SELECT 
--	adSoyad, 
--	LEFT(adSoyad,3) as '�lk 3 karakter', 
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'B�Y�K',
--	LOWER(adSoyad) as 'K���K'
--FROM Doktorlar

--SELECT
--	REPLACE('Kerem �zmen', 'n', 'MERHABA')

--SELECT
--	LOWER(REPLACE('Kerem �zmen', ' ', '')) + '@gmail.com'

--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad), ' ', '') + '@gmail.com' as 'Mail Adresi'
--FROM Doktorlar


--Sercan Furkan ad�nda Amasya'da ya�ayan b�l�m� 3 olan doktoru kaydedecek olan sorguyu yaz�n�z.
--INSERT INTO Doktorlar(adSoyad, adres, bolumId) VALUES
--	('Sercan Furkan', 'Amasya', 3)

--G�NCELLEME ��LEMLER�
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
--WHERE id=12

--UPDATE Doktorlar SET adSoyad = 'al sana yeni isim!'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2


--S�LME ��LEMLER�
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

--DELETE FROM Doktorlar bolumId IS NULL