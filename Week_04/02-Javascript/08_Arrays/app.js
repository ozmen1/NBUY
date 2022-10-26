// let urunler = [];

// urunler[0] = "Samsung S21";
// urunler[1] = "iPhone 13";
// urunler[123] = 'Bilgisayar';




// let urunler = ['iPhone 13', 'iPhone XR', 'Dell X5'];
// let fiyatlar = [15000, 35000, 45000];
// let renkler = ['gold', 'gri', 'lacivert'];

// // foreach dizi metodu olarak sunulmuş
// // => arrow function
// urunler.forEach((urun, i) =>{
//     console.log(urun, fiyatlar[i], renkler[i]);
// })






// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);


// // böyle tanımlayınca dizi olarak değil obje olarak tanımlanıyor
// let urun1 = [];
// urun1[0] = 'iPhone 13';
// urun1[1] = 25000;
// urun1[2] = 'Gold';
// urun1[3] = true;

// let urun2 = ['Dell X5', 45000, 'Sarı', false];
// let urun3 = ['Samsung S22', 35000, 'Kırmızı', true];

// let urunler = [urun1, urun2, urun3]

// console.log(urun1, typeof(urun1));
// console.log(urun2, typeof(urun2));
// console.log(urun3, typeof(urun3));
// console.log(urunler, typeof(urunler));





// let urun1 = 'iPhone 13, 25000, Yeşil, true';
// let urun1Dizi = urun1.split(',');
// console.log(urun1, typeof urun1);
// console.log(urun1Dizi, typeof urun1Dizi);




let ogrenciler = ['Cemre', 'Melahat', 'Sema', 'Hasancan'];
let sonuc;
// sonuc = ogrenciler.length;
// console.log(sonuc);
// sonuc= ogrenciler;
// console.log(sonuc);
// sonuc= ogrenciler.toString();
// console.log(sonuc);
// sonuc=ogrenciler.join('/');

ogrenciler[4] = 'Serhat';
ogrenciler.push('Aylin');
ogrenciler.pop();
sonuc = ogrenciler.push('Aylin'); //en sona ekler
sonuc = ogrenciler.pop();
sonuc = ogrenciler.unshift('Aylin') //en başa ekler



console.log(ogrenciler);
console.log(sonuc);
