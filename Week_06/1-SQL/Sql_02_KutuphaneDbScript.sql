/*
1. KütüphaneDb adýnda bir veri tabaný oluþturunuz.
2. Veritabanýnda aþaðýdaki tablolar bulunsun:
	Turler id ad
	Yazarlar adsoyad cinsiyet yas
	Yayinevleri ad adres
	Uyeler ad
	Kitaplar ad yayýnevi türü yayýn yýlý
	OduncIslemleri hangi kitap kime hangi tarihte ödünç verildi

* bir kitap birden fazla türde olabilir.
* bir kitap birden fazla yayýnevinden çýkabilir.

3. Yeteri kadar örnek veri giriþi de yapýnýz.

4. türü silmeye çalýþ
*/


USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb
GO

CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Turler VALUES
	('Genel'),
	('Bilim'), 
	('Roman'), 
	('Tarih'), 
	('Bilim Kurgu'), 
	('Fantastik'), 
	('Þiir'), 
	('Edebiyat'), 
	('Yabancý Dil'), 
	('Üniversiteye Hazýrlýk')
GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	dogumYili DATE,
)
GO

INSERT INTO Yazarlar(adSoyad, cinsiyet, dogumYili) VALUES
	('Ferdi Özbeðen','E','1815'),
	('Ümit Elibol','E','1985'),
	('Canan Ferdi','K',null),
	('Selim Ýnebolulu','E','1990'),
	('Salime Bozaçan','K','1978'),
	('Ayþe Kadýn','K','1964'),
	('Feride Naime Bozkýr','K',null)
GO

CREATE TABLE Yayinevleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Yayinevleri VALUES
	('Altýn Yayýn','Adana'),
	('Beþiktaþ Kültür Yayýnevi','Ýstanbul'),
	('Ýþbankasý Yayýnevi','Ýstanbul'),
	('Zambak Yayýnlarý','Ýzmir'),
	('Elden Ele Yayýncýlýk','Antalya')
GO


CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Uyeler VALUES
	('Fahri Gözlükçü','Yozgat'),
	('Mine Çanakkale','Erzincan'),
	('Halide Kývanç','Ýstanbul'),
	('Sümbül Kaya','Ýstanbul'),
	('Faruk Þerefoðlu','Ankara'),
	('Eyüp Canoba','Selanik'),
	('Elif Candan','Kastamonu')
GO


CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	yayinYili INT NOT NULL, 
	yayinEviId INT NOT NULL,
	turId INT NOT NULL DEFAULT 1,
	FOREIGN KEY (yayinEviId) REFERENCES Yayinevleri(id),
	FOREIGN KEY (turId) REFERENCES Turler(id) ON DELETE SET DEFAULT --ON DELETE CASCADE --ON DELETE SET NULL
	--türler tablosundan herhangi bir kayýt silinmeye çalýþýlýrsa kontrol et: bu türe ait kitap var mý? yoksa sil, varsa silme. (ON DELETE CASCADE)
	--default tür atama ON DELETE SET DEFAULT
	--yazar adý ekle!!!
)
GO

INSERT INTO Kitaplar VALUES
	('Bir Öðretmenin Anýlarý', 1986, 4, 5),
	('Camýn Önünde Duran Kedi', 2012, 1, 6),
	('Sevgili Günlüðüm', 1995, 3, 2),
	('Ericanýn Not Defteri', 2000, 5, 4),
	('Savaþ ve Yine Savaþ', 1834, 2, 7),
	('Ortaokul Matematik Ders Kitabý', 2020, 4, 3),
	('Lise Fizik Ders Kitabý', 2020, 5, 3)

--- birden fazla tür birden fazla yayýnevi?
GO

CREATE TABLE OduncIslemleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	oduncAlan INT NOT NULL,
	oduncVerilenKitap INT NOT NULL,
	tarih INT NOT NULL,
	FOREIGN KEY (oduncAlan) REFERENCES Uyeler(id),
	FOREIGN KEY (oduncVerilenKitap) REFERENCES Kitaplar(id),
)
GO

INSERT INTO OduncIslemleri VALUES
	(1, 7, '2021'),
	(2, 6, '2020'),
	(3, 5, '2019'),
	(4, 4, '2018'),
	(1, 4, '2019'),
	(5, 1, '2022'),
	(6, 2, '2006'),
	(7, 3, '2009')
GO