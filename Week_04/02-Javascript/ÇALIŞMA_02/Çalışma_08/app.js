// Kendisine gönderilen bir sayının tam bölenlerini dizi şeklinde döndüren fonksiyonu yazınız.

//   Örnek kullanım: console.log(tamBolenler(10));    // 2, 5

function tamBolenler(x){
    dizi = [];
    for (let i = 2; i < x; i++) {
        if (x % i == 0) {
           dizi.push(i);
        }
    }
    console.log(dizi);
}

tamBolenler(10);