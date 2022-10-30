// Dikdörtgenin alan ve çevresini hesaplayan fonksiyonu yazınız.

//   Örnek kullanım: let sonuc = alanCevreHesapla(7, 10);

function alanCevreHesapla(a, b){
    let alan = a*b;
    let cevre = 2*(a+b);
    console.log('Alan: ' + alan + ' Çevre:' + cevre);
}

alanCevreHesapla(5,5);