// 1 den büyük olup 1 veya kendisi haricinde hiçbir sayıya kalansız bölünemeyen sayılara asal sayı denir.
// Örneğin 5 bir asal sayıdır. Çünkü 2,3 ve 4 e kalansız bölünemez.
// 2 den n'e kadar olan asal sayıları bulan kodu yazınız.
// Örneğin n = 10 için sonuç 2,3,5,7 olacaktır.
// NOT: Kod her türlü n değeri için çalışmalıdır, sabit bir sayı değildir.


// // ÇÖZÜM1
// let n = prompt('Lütfen bir sayı giriniz: ');
// let asalMi;
// //1 ve kendisi hariç (asallık)
// for (let i = 2; i <= n; i++) {
//     asalMi = true;
//     for (let j = 2; j < i; j++) {
//         if (i % j === 0) {
//             asalMi = false;
//         }
//     }
//     if(asalMi === true){
//         console.log(i);
//     }
// }



// ÇÖZÜM2
let n = prompt('Bir sayı giriniz');

nextPrime:
for (let i = 2; i < n; i++) {
    for (let j = 2; j < i; j++) {
        if (i % j === 0) {
            continue nextPrime;
        }
    }    
    console.log(i);   
}