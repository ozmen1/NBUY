--sayfa sayýsý 300'den büyük eþit olan kitaplarý listele
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi >= 300
--stok adedi 90 ile 113 olanlarý göster

--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE stok>=90 AND stok<=113

--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113

--sayfa sayýsý en çok olandan en az olana
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

--türe göre küçükten büyüðe
--türe göre sýrala ama ayný türde olanlarý sayfa sayýsýna göre desc sýrala
--SELECT * FROM Kitaplar ORDER BY turId, sayfaSayisi DESC
