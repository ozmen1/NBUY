// Prompt aracılığı ile kullanıcıdan bir saniye değeri alın. Örneğin 1500. Ardından bu girilen değerin kaç dakika, kaç saniye olduğunu hesaplayıp konsola düzgün bir şekilde yazdırın.
// Örnek sonuç: 
// Girilen değer: 1270
// Sonuç: 21 dakika 10 saniye

// let dakika = 0;
// let saniye = 0;
// let input = parseInt(prompt('Lütfen bir saniye değeri giriniz: '));
// dakika = input/60;
// dakika = Math.floor(dakika);
// saniye = input%60;
// console.log(dakika + ' dakika ' + saniye + ' saniye');




// hocanın çözümü
// let saniye = parseInt(prompt('Lütfen saniye değerini giriniz: '));
// console.log('Girilen saniye değeri: ' + saniye);
// let dakika = parseInt(saniye / 60);
// saniye = saniye % 60;
// console.log(dakika + ' dakika ' + saniye + ' saniye');


//ÖNERİ:

/*
girilen saniye değerini 1 saat 45 dk 40 sn olarak göstersin


*/

let saniye = parseInt(prompt('Lütfen saniye değerini giriniz: '));
console.log('Girilen saniye değeri: ' + saniye);
let saat = parseInt(saniye / 3600);
let dakika = Math.abs(saat*60 - parseInt(saniye / 60));
saniye = saniye % 60;
console.log(saat + ' saat ' + dakika + ' dakika ' + saniye + ' saniye');