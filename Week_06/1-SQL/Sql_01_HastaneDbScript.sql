USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO
--�st taraf varsa hastanedb'yi silip yeniden olu�turur.
--yoksa zaten olu�turur.

USE HastaneDb
GO

--HASTALAR TABLOSU
CREATE TABLE Hastalar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad	NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11),

)
GO

INSERT INTO Hastalar (adSoyad, cinsiyet, adres) VALUES
	('Erencan Germirli','E','�stanbul'),
	('Selin Fergen�','K','Ankara'),
	('Sadi Kulo�lu','E','�zmir'),
	('Ne�e Kalabal�k','K','�stanbul'),
	('Sevda A�alar','K','�zmir'),
	('Nora Ta�kesen','K','Ankara'),
	('Emma �eto�lu','K','�stanbul'),
	('Kerem S�zc�','E','Ankara'),
	('Suat Tartar','E','�zmir')

GO

--B�L�MLER TABLOSU
CREATE TABLE Bolumler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30)	NOT NULL
)

GO

INSERT INTO Bolumler VALUES
	('Dahiliye'),
	('N�roloji'),
	('Ortopedi'),
	('Di�'),
	('Periodontoloji'),
	('Genel Cerrahi')

GO

--DOKTORLAR TABLOSU

CREATE TABLE Doktorlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	bolumId INT,
	FOREIGN KEY (bolumId) REFERENCES Bolumler(id)
)
GO

INSERT INTO Doktorlar VALUES
	('Ali Can','�stanbul',1),
	('Demet Evgar','Bursa',2),
	('Sedat Kanar','�stanbul',2),
	('Ferhunde Han�m','�zmir',1),
	('Zafer Kimki','Ankara',2),
	('Hale Elveren','�stanbul',3),
	('Tuna Sefer','Ankara',4),
	('Kevser Tutku','Ankara',4),
	('Tutkum Kap��mak','�zmir',5),
	('�sa Canova','�zmir', null)

GO
--yukar�daki INSERT INTO'nun son sat�r�n�n alternatifi
--INSERT INTO Doktorlar(adSoyad, adres) VALUES
--	('Tu��e B�l�ms�z','�stanbul')
--GO
