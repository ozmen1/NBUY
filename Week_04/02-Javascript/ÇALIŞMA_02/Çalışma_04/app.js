// let sayilar = [1,5,7,15,3,25,12,24];

//     1- sayilar listesindeki her bir elemanın karesini yazdırınız.
//     2- sayilar listesindeki hangi sayılar 5' in katıdır?
//     3- sayilar listesindeki çift sayıların toplamını bulunuz.

//     let urunler = ["iphone 12","samsung s22","iphone 13","samsung s23","samsung s20"];

//     4- urunler listesindeki tüm ürünleri büyük harf ile yazdırınız.
//     5- urunler listesinde samsung geçen kaç ürün vardır?

//     let ogrenciler = [
//     {"ad":"yiğit", "soyad": "bilgi", "notlar": [60,70,60]},
//     {"ad":"ada", "soyad": "bilgi", "notlar": [80,70,80]},
//     {"ad":"çınar", "soyad": "turan", "notlar": [10,20,60]}
// ];

//     6- ogrenciler listesindeki her öğrencinin not ortalaması ve başarı durumlarını yazdırınız.
//     7- tüm öğrencilerin not ortalaması kaçtır?

let sayilar = [1,5,7,15,3,25,12,24];

for (let i = 0; i < sayilar.length; i++) {
    sayilar[i] = sayilar[i]*sayilar[i];
}
console.log(sayilar);

besinKatlari = [];
for (let i = 0; i < sayilar.length; i++) {
    if (sayilar[i] % 5 == 0) {
        besinKatlari = sayilar[i];
    }
}
console.log(besinKatlari);