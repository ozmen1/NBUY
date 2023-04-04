// Yazı tura uygulamasını(uygulama çalıştığında sonuç olarak ya yazı ya da tura diyecek) fonksiyon kullanarak yapınız.

//   Örnek kullanım: yaziTuraAt();

function yaziTuraAt(){
    let sonuc = parseInt(Math.random()*10)+1;
    console.log(sonuc);
    if (sonuc % 2 == 0) {
        console.log('Yazı');
    }
    else{
        console.log('Tura');
    }
}

yaziTuraAt();