--sayfa say�s� 300'den b�y�k e�it olan kitaplar� listele
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi >= 300
--stok adedi 90 ile 113 olanlar� g�ster

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113

--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

--sayfa say�s� en �ok olandan en az olana
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

--t�re g�re k���kten b�y��e
--t�re g�re s�rala ama ayn� t�rde olanlar� sayfa say�s�na g�re desc s�rala
--SELECT * FROM Kitaplar ORDER BY turId, sayfaSayisi DESC
