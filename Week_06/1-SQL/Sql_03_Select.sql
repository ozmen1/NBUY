--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar


--FÝLTRELEME

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD', adres as 'ADRES' FROM Doktorlar

--SELECT * FROM Doktorlar WHERE adSoyad ='Tuna Sefer'

--SELECT * FROM Doktorlar WHERE adSoyad !='Tuna Sefer'

--SELECT * FROM Doktorlar WHERE NOT adSoyad = 'Tuna Sefer'

--SELECT * FROM Doktorlar WHERE id=3 OR id=6

--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='Ýzmi

--SELECT * FROM Doktorlar WHERE id >= 6

--SELECT * FROM Doktorlar WHERE adres IN ('Ýzmir','Ýstanbul')

--adý A harfi ile baþlayan doktorlar?
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'a%'
--Ýlk harfi a olan geri kalaný ne olursa olsun...

--ad soyadý r ile bitenler
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%r'

--içinde s geçen
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'

--ikinci harfi e olanlar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'

--ilk harfi d 
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'D_m%'


--SIRALAMA ÝÞLEMLERÝ

--artan
--SELECT * FROM Doktorlar ORDER BY adSoyad

--azalan
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC

--bolumid'ye göre büyükten küçüðe
--SELECT * FROM Doktorlar ORDER BY bolumId DESC

--adrese göre sýrala (A-Z)
--SELECT * FROM Doktorlar ORDER BY adres 

--adrese göre sýrala (A-Z) ve doktor adsoyad sýrala (Z-A) 
--SELECT * FROM Doktorlar ORDER BY adres ASC, adSoyad DESC



--HESAPLAMA ÝÞLEMLERÝ



--USE KutuphaneDb
--SELECT * FROM Kitaplar

--SELECT MIN(sayfaSayisi) as 'En Az Sayfa Sayýsý' FROM Kitaplar

--SELECT MAX(sayfaSayisi) as 'En Yüksek Sayfa Sayýsý' FROM Kitaplar

--SELECT COUNT(*) as 'Kolon Sayýsý' FROM Kitaplar

--USE HastaneDb
--bölümü olan doktorlarýn sayýsý
--SELECT COUNT(bolumId) FROM Doktorlar


--USE KutuphaneDb
--elimizdeki kitaplarýn ortalama sayfa sayýsý
--SELECT AVG(sayfaSayisi) FROM Kitaplar

--toplam stok adedi
--SELECT SUM(stok) FROM Kitaplar

--tane sayfa var (tüm kitaplarýn toplam sayfasý) (bunu ürün fiyatý*stok gibi düþün)
--SELECT SUM(stok*sayfaSayisi) FROM Kitaplar


--STRING ÝÞLEMLERÝ

--USE HastaneDb
--SELECT LEN('Kerem Özmen')
--SELECT adSoyad, LEN(adSoyad) as 'Adýnýn toplam uzunluðu' FROM Doktorlar

--SELECT 
--	adSoyad, 
--	LEFT(adSoyad,3) as 'Ýlk 3 karakter', 
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'BÜYÜK',
--	LOWER(adSoyad) as 'KÜÇÜK'
--FROM Doktorlar

--SELECT
--	REPLACE('Kerem Özmen', 'n', 'MERHABA')

--SELECT
--	LOWER(REPLACE('Kerem Özmen', ' ', '')) + '@gmail.com'

--SELECT
--	adSoyad,
--	REPLACE(LOWER(adSoyad), ' ', '') + '@gmail.com' as 'Mail Adresi'
--FROM Doktorlar


--Sercan Furkan adýnda Amasya'da yaþayan bölümü 3 olan doktoru kaydedecek olan sorguyu yazýnýz.
--INSERT INTO Doktorlar(adSoyad, adres, bolumId) VALUES
--	('Sercan Furkan', 'Amasya', 3)

--GÜNCELLEME ÝÞLEMLERÝ
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
--WHERE id=12

--UPDATE Doktorlar SET adSoyad = 'al sana yeni isim!'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2


--SÝLME ÝÞLEMLERÝ
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

--DELETE FROM Doktorlar bolumId IS NULL