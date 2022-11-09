/*
1. K�t�phaneDb ad�nda bir veri taban� olu�turunuz.
2. Veritaban�nda a�a��daki tablolar bulunsun:
	Turler id ad
	Yazarlar adsoyad cinsiyet yas
	Yayinevleri ad adres
	Uyeler ad
	Kitaplar ad yay�nevi t�r� yay�n y�l�
	OduncIslemleri hangi kitap kime hangi tarihte �d�n� verildi

* bir kitap birden fazla t�rde olabilir.
* bir kitap birden fazla yay�nevinden ��kabilir.

3. Yeteri kadar �rnek veri giri�i de yap�n�z.

4. t�r� silmeye �al��
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
	('�iir'), 
	('Edebiyat'), 
	('Yabanc� Dil'), 
	('�niversiteye Haz�rl�k')
GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	dogumYili DATE,
)
GO

INSERT INTO Yazarlar(adSoyad, cinsiyet, dogumYili) VALUES
	('Ferdi �zbe�en','E','1815'),
	('�mit Elibol','E','1985'),
	('Canan Ferdi','K',null),
	('Selim �nebolulu','E','1990'),
	('Salime Boza�an','K','1978'),
	('Ay�e Kad�n','K','1964'),
	('Feride Naime Bozk�r','K',null)
GO

CREATE TABLE Yayinevleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Yayinevleri VALUES
	('Alt�n Yay�n','Adana'),
	('Be�ikta� K�lt�r Yay�nevi','�stanbul'),
	('��bankas� Yay�nevi','�stanbul'),
	('Zambak Yay�nlar�','�zmir'),
	('Elden Ele Yay�nc�l�k','Antalya')
GO


CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Uyeler VALUES
	('Fahri G�zl�k��','Yozgat'),
	('Mine �anakkale','Erzincan'),
	('Halide K�van�','�stanbul'),
	('S�mb�l Kaya','�stanbul'),
	('Faruk �erefo�lu','Ankara'),
	('Ey�p Canoba','Selanik'),
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
	--t�rler tablosundan herhangi bir kay�t silinmeye �al���l�rsa kontrol et: bu t�re ait kitap var m�? yoksa sil, varsa silme. (ON DELETE CASCADE)
	--default t�r atama ON DELETE SET DEFAULT
	--yazar ad� ekle!!!
)
GO

INSERT INTO Kitaplar VALUES
	('Bir ��retmenin An�lar�', 1986, 4, 5),
	('Cam�n �n�nde Duran Kedi', 2012, 1, 6),
	('Sevgili G�nl���m', 1995, 3, 2),
	('Erican�n Not Defteri', 2000, 5, 4),
	('Sava� ve Yine Sava�', 1834, 2, 7),
	('Ortaokul Matematik Ders Kitab�', 2020, 4, 3),
	('Lise Fizik Ders Kitab�', 2020, 5, 3)

--- birden fazla t�r birden fazla yay�nevi?
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