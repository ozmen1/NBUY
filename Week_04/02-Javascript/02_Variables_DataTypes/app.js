/*

    ECMASCRIPT ES5
    Değişkenler tanımlanırken üç farklı keyword kullanılabilir.
    1. var
    2. let (2015 ecmascript es5 güncellemesi ile geldi)
    3. const(sabit)

    - ES6 ile birlikte artık modarn javaxript tabiri kullanılmaya başlanmıştır. Bu süreçte let ve const kullanın, var kullanmaktan kaçının.
    - js de değişken tanımlanırken tip belirtilmez.
    - bu, değişkenlerin tipi olmadığı anlamına gelmez.
    - js motoru bir değişkene değer atanması esnasında o değere göre tipi belirler.
    - eğer henüz bir değişkene değer atanmamışsa undefined olarak belirlenir.


*/


    // let yas = 20
    // console.log(yas)
    // let ad= 'Geç kalan Sema';
    // let soyad = 'Geç kalan Harun';
    // console.log(ad);
    // console.log(soyad);
    // console.log(ad, soyad);
    // let firstName='Serhat';
    // let lastName='Kaya';
    // console.log(firstName + ' ' + lastName);

    // let sayi1 = 15;
    // let sayi2 = 25;
    // let sayi3 = 35;

    // let s1 = 15, s2 = 45, s3=55;

    // let say1 = 25,
    //     say2 = 55,
    //     say3 = 48;

    // let durum = true;

    // sayi1 = 125;
    // console.log(sayi1);

    // let toplam = 0;
    // toplam = toplam + sayi1;

    // const benimDogumYilim = 1975;
    // console.log('benim doğum yılım: ' + benimDogumYilim);

    // // Bildiğiniz değişken isimlendirme yönlemlerini burada da kullanabilirsiniz. Değişkenli genellikle camelCase ile isimlendiririz.
    // // -Değişken isminde harf, rakam, $ ve _ olabilir.
    // // -Değişken ismi rakamla başlayamaz.
    // // -Reserved keyword'ler değişken adı olarak kullanılamaz.
    // // Const sabir değerleri tutmak için kullanılır. Genellikle tamamen büyük harf ile isimlendirilir.

    // const PI_SAYISI = 3.14;
    // const _PI_SAYISI = 3.14;

    // const RENK_1 = 'Sarı';
    // const RENK_2 = 'Kırmızı';
    // let renk_3 = 'Yeşil';
    // console.log(RENK_1 renk_3, RENK_2);

    




    // DATATYPES

    // 1. NUMBER

    // let sayi1 = 100;
    // console.log(sayi1);
    // console.log(typeof sayi1);
    // console.log(typeof(sayi1));

    // let sayi2 = 17.5;
    //     console.log(sayi2, typeof sayi2);

    // let sayi3 = 25/0;
    // console.log(sayi3, typeof(sayi3));

    // let sayi4 = 'okul'/25;
    // console.log(sayi4, typeof(sayi4));

    // let sayi5 = 235235334985734573984758937458734985735739847589374598734895738947587n;
    // console.log(sayi5, typeof(sayi5));
    // let sayi6 = sayi5 * 9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999n;
    // console.log(sayi6, typeof(sayi6));



    // 2. STRING

    /*

    String ifadeler üc farklı şejilde ifade edilebilir.
    1. tek tırnak ile
    2. çift tırnak ile
    3. backticks (tilda) (altgr-;-boşluk) (``)




    */

    // let ad = 'Engin';
    // let soyad = "Niyazi";
    // let adSoyad = ad + " " + soyad;
    // console.log(adSoyad);

    // let adres = 'Halitağa Mah. \n\tSütlü Nuriye Sok. Candaş Ap. No:21 \nBeşiktaş'
    // console.log(adres);

//     let adSoyad = 'Kerem Özmen';
//     let yas = 28;
//     let kanGrubu = '0RH+';
//     let kilo = 80;
//     let cinsiyet = 'Erkek';

//     console.log('Sayın '+adSoyad+', '+yas+' yaşındasınız.\nKilo: '+kilo+' \nKan Grubu: '+kanGrubu+'\nCinsiyet: '+cinsiyet+'\n\n\n');

// console.log(`Sayın ${adSoyad}, ${yas} yaşındasınız. 
// Kilo: ${kilo}
// Kan Grubu:${kanGrubu}
// Cinsiyet:${cinsiyet}`);

    // BOOLEAN 

    // let durum = true;
    // console.log(durum, typeof(durum));
    // let ad = 'Halil';
    // console.log(ad, typeof(ad));

    // null, undefined
    // let yas;
    // yas = null;
    // console.log(yas, typeof(yas));

    //Javascriptte char diye bir tip yoktur!




    // CONVERT DATA TYPES
    // let durum = true;
    // console.log(durum, typeof(durum));

    // let metin = 'Durumunuz ' + durum + ' şeklindedir.';
    // console.log(metin, typeof(metin));

    // let durumMetin = String(durum);
    // console.log(durumMetin, typeof(durumMetin));

    // let sayi = 25;
    // let metin2 = sayi + ' yaşındasınız.';
    // console.log(metin2, typeof(metin2));
    // let sayiMetin = String(sayi);
    // console.log(sayiMetin, typeof(sayiMetin));

    // let metinSayi = '455';
    // console.log(metinSayi, typeof(metinSayi));
    // let metinSayiNumber = Number(metinSayi);
    // console.log(metinSayiNumber, typeof(metinSayiNumber));









    // let sayiMetin = `       145         `;
    // console.log(sayiMetin, typeof(sayiMetin));
    // let sayi = Number(sayiMetin);
    // console.log(sayi, typeof(sayi));

// //number sınırı --> 2 üzeri 53-1
//     let sayi = 1254n;
//     console.log(sayi, typeof(sayi));


// console.log(Number(true));
// console.log(Number(false));


// //boolean sadece sayısal değer olan 0'ı false alır geriye kalan her şey true döndürülür.
// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean(34345));
// console.log(Boolean(-353453));
// console.log(Boolean('0'));


// // let a;
// a = '' + 1 + 0; console.log(a, typeof(a));
// + ile başladı = birleştirme

// a = '' - 1 + 0; console.log(a, typeof(a));
// - ile başladı = işlem

// a = true + false; console.log(a, typeof(a));
// örtük bir şekilde toplama

// a = 6 / '3'; console.log(a, typeof(a));
// örtülü bir şekilde number'a çevirdi (dönüştürülebilir olduğu için) işlem yaptı

// a = 4 + 5 + 'px'; console.log(a, typeof(a));
// öncelik aritmetik işlemde, sonra stringlerle birleştirme yaptı

// a = '$' + 4 + 5; console.log(a, typeof(a));
// okuma sırasında string olduğu için birleştirme ile devam etti

// a = '4px' - 2; console.log(a, typeof(a));
// metinin yanında birleştirme yapması için + olması lazımdı

// a = '       -9         ' + 5; console.log(a, typeof(a));
// + var yani, stringleri birleştirme yaptı 

// a = '       -9         ' - 5; console.log(a, typeof(a));
// bu sefer dönüştürme yapabildi ve çıkartma işlemi yaptı

// a = null + 1; console.log(a, typeof(a));
// null içinde bir şey olmayan objecttir. matematiksel olarak 0dır. etkisizdir.

// a = undefined + 1; console.log(a, typeof(a));
// NaN number

// a = NaN + 1; console.log(a, typeof(a));
// NaN number

// a = '$' + (4 + 5); console.log(a, typeof(a));
// matematiksel öncelikler

// a = Number('       -9         ') + 5; console.log(a, typeof(a));
// dönüştürmeye zorladık