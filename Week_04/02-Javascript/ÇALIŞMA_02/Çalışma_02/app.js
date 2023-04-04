// 1- "Elma,Armut,Muz,Çilek" elemanlarına sahip bir dizi oluşturunuz.
// 2- Dizi kaç elemanlıdır?
// 3- Dizinin ilk ve son elemanı nedir?
// 4- Elma dizinin bir elemanımıdır?
// 5- Kiraz meyvesini listenin sonuna ekleyiniz.
// 6- Dizinin son 2 elemanını siliniz.
// 7- Aşağıdaki bilgileri dizi içerisinde saklayınız ve her öğrencinin yaşını ve not ortalamasını hesaplayınız.
//     /*
//         Öğrenci 1: Kemal Devrimdar 2010 (70,60,80)
//         Öğrenci 2: Saliha Temel 2012   (80,80,90)
//         Öğrenci 3: Defne Küp  2009 (60,60,70)
//     */


// let meyveler = ['Elma', 'Armut', 'Muz', 'Çilek'];

// console.log(meyveler.length);

// console.log(meyveler[0]);
// console.log(meyveler[3]);

// console.log(meyveler.includes('Elma'));


// console.log(meyveler.push('Kiraz'));
// console.log(meyveler);

// console.log(meyveler.splice(meyveler.length-3, 3));

// Öğrenci 1: Kemal Devrimdar 2010 (70,60,80)
// Öğrenci 2: Saliha Temel 2012   (80,80,90)
// Öğrenci 3: Defne Küp  2009 (60,60,70)

// let ogrenci1 = ['Kemal Devrimdar', 2010, [70,60,80]];
// let ogrenci2 = ['Saliha Temel', 2012, [80,80,90]];
// let ogrenci3 = ['Defne Küp', 2009, [60,60,70]];

// let simdi = new Date().getFullYear();
// ogrenci1.yas = console.log(simdi-ogrenci1[1]);
// ogrenci2.yas = console.log(simdi-ogrenci2[1]);
// ogrenci3.yas = console.log(simdi-ogrenci3[1]);

// toplam1 = 0;
// for (let i = 0; i < ogrenci1.length; i++) {
//     toplam1 += ogrenci1[2][i];
    
// }
// console.log(toplam1/3);

// toplam2 = 0;
// for (let i = 0; i < ogrenci2.length; i++) {
//     toplam2 += ogrenci2[2][i];
    
// }
// console.log(toplam2/3);

// toplam3 = 0;
// for (let i = 0; i < ogrenci2.length; i++) {
//     toplam3 += ogrenci2[2][i];
    
// }
// console.log(toplam3/3);