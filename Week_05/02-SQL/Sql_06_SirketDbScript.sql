CREATE DATABASE SirketDb2
GO
--veritaban� yarat�lmas� uzun s�rd��� i�in GO komutu
USE SirketDb2
CREATE TABLE Departmanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Departmanlar(ad) VALUES
	('Muhasebe'),
	('Teknik'),
	('Sat��'),
	('�K'),
	('Y�netim')

CREATE TABLE Unvanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Unvanlar(ad) VALUES
	('���i'),
	('Muhasebe Uzman�'),
	('Sat����'),
	('�K Uzman�'),
	('�K Stajyeri'),
	('Y�netici'),
	('Y�netici Yard�mc�s�')

CREATE TABLE Iller(
	id CHAR(2) NOT NULL PRIMARY KEY,
	ad NVARCHAR(30) NOT NULL
)

INSERT INTO Iller(id, ad) VALUES
	('34', '�stanbul'),
	('06', 'Ankara'),
	('35', '�zmir'),
	('58', 'Sivas'),
	('41', 'Kocaeli')

CREATE TABLE Ilceler(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,
	ilId CHAR(2) NOT NULL,
	FOREIGN KEY(ilId) REFERENCES Iller(id)
)

INSERT INTO Ilceler (ad, ilId) VALUES
	('Kad�k�y','34'),
	('Be�ikta�','34'),
	('Avc�lar','34'),
	('Konak','35'),
	('Yenimahalle','06'),
	('�ankaya','06'),
	('Su�ehri','58')

CREATE TABLE Personeller(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	soyad NVARCHAR(25) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi DATE NOT NULL,
	ikametgahIlceId INT NOT NULL,
	iseBaslamaTarihi DATE NOT NULL,
	departmanId INT NOT NULL,
	unvanId INT NOT NULL,
	maasBilgisi MONEY NOT NULL,
	FOREIGN KEY(ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY(departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId) REFERENCES Unvanlar(id)
)

INSERT INTO Personeller 
	(ad, soyad, cinsiyet, dogumTarihi, ikametgahIlceId, 
	iseBaslamaTarihi, departmanId, unvanId, maasBilgisi) VALUES
		('Alican','Kabak',0,'1999-05-15',1,'2021-11-10',1,1,12500),
		('Sude','Can�z',1,'1999-05-15',2,'2021-11-10',2,5,13500),
		('Ya�ar','G�lery�z',1,'1999-05-15',3,'2021-11-10',3,5,14500),
		('Kemal','Tatl�c�',0,'1999-05-15',4,'2021-11-10',4,4,12800),
		('Zeliha','Ek�i',0,'1999-05-15',5,'2021-11-10',5,7,12900),
		('Arma�an','Elebakan',1,'1999-05-15',6,'2021-11-10',1,6,10900),
		('Kadriye','Kutlutepe',0,'1999-05-15',7,'2021-11-10',2,5,100),
		('Fatih','Kaya',1,'1999-05-15',1,'2021-11-10',3,3,1200),
		('H�seyin','Tepe',0,'1999-05-15',2,'2021-11-10',4,3,111500),
		('Arda','G�ler',1,'1999-05-15',3,'2021-11-10',5,2,17800),		
		('Elif','G�len',1,'1999-05-15',4,'2021-11-10',1,1,17800)


CREATE TABLE Projeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	baslamaTarihi DATE NOT NULL,
	planlananBitisTarihi DATE NOT NULL
)

INSERT INTO Projeler(ad, baslamaTarihi, planlananBitisTarihi) VALUES
	('Mutlu �ocuklar','2022-05-05','2022-08-05'),
	('Temiz �sk�dar','2022-05-05','2022-08-05'),
	('Kirli Kad�k�y','2022-05-05','2022-08-05'),
	('Haydi Gen�ler Elele','2022-05-05','2022-08-05')