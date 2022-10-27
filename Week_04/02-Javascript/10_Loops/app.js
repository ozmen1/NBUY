//while

// let i = 0;
// while (i<10){
//     console.log(i);
//     i++;
// }

// let i = 0;
// while (i<10){
//     i++;
//     console.log(i);
// }

// let i = 0;
// while (i < 10){
//     i++;
//     console.log(i + '. Javascript');
// }

//döngüye hiç girmedi
// let i = 0;
// while (i > 10){
//     i++;
//     console.log(i + '. Javascript');
// }


//do while



// let i = 0;
// do {
//     i++;
//     console.log(i + '. JS');
// } while (i < 10);


// döngü 1 kere çalıştı ve çıktı
// let i = 0;
// do {
//     i++;
//     console.log(i + '. JS');
// } while (i > 10);



// for (let i = 0; i < 10; i++) {
//     console.log(i+1  + '. Javascript');
// }



// //1-10 arasındaki sayıları toplayıp konsola yazdırın.
// let toplam = 0;
// let i = 1;
// while (i <= 10) {
//     toplam += i;
//     i++;
// }
// console.log('while ile toplam: ' + toplam);

// let toplam2 = 0;
// for (let i = 1; i < 10; i++) {
//     toplam2 += i;
// }
// console.log('for ile toplam: ' + toplam2);






// //Kullanıcının gireceği 3 sayıyı toplatan kodları for kullanarak yazınız.
// let toplam = 0;
// for (let i = 0; i < 3; i++) {
//     const input = prompt('lütfen sayı giriniz');
//     toplam += parseInt(input)
// }
// console.log(toplam);

//hocanın çözümü
// let toplam = 0;
// let girilenSayi;
// for (let i = 1; i <= 3; i++) {
//     girilenSayi = Number(prompt(i + '.sayı: '))
//     toplam += girilenSayi;
// }
// console.log('Toplam: '+toplam);







// //Kullanıcı 0 girene kadar girilen sayıları toplayıp sonucu konsola yazan kodu yazınız.
// let toplam = 0;
// let input;
// while (true) {
//     input = parseInt(prompt('lütfen sayı giriniz'));
//     if(input==0){
//         break;
//     }
//     toplam += input;
// }
// console.log(toplam);

// // hocanın çözümü
// let toplam = 0;
// let girilenSayi;
// let i = 1;
// do {
//     girilenSayi = Number(prompt(i + '.sayı: '))
//     toplam += girilenSayi;
//     i++;
// } while (girilenSayi != 0);
// console.log('Toplam: '+toplam);
//........
//son örnekteki girilen sayıları da sonuçta yazdıralım!!!!!!!!!!!!!!
// 1. sayı: 20
// 2. sayı: 10
// 3. sayı: 30
// toplam: 60
// not: girilen sayıları bir diziye aktararak kullanın!

// let toplam=0;
// let dizi = [];
// let girilenSayi;
// let i = 1;
// do {
//     girilenSayi = Number(prompt(i + '.sayı: '))
//     toplam += girilenSayi;
//     dizi.push(girilenSayi);
//     i++;
// } while (girilenSayi != 0);
// dizi.pop();
// console.log(toplam);
// console.log(dizi);

// //hocanın çözümü:
// let toplam = 0;
// let girilenSayilar = [];
// let i = 0;
// do {
//     girilenSayilar[i] = Number(prompt(i+1 + '.sayı: '))
//     toplam += girilenSayilar[i];
//     i++;
// } while (girilenSayilar[i-1] != 0);
// //girilenSayilar[i-1] dememizin sebebi döngü i++ ile sürekli arttığı için bir sonraki sayıyı kontrol etmemek için!
// girilenSayilar.pop();
// for (let i = 0; i < girilenSayilar.length; i++) {
//     console.log(i+1+'. Sayı:\t' + girilenSayilar[i]);
// }
// console.log('Toplam: '+toplam);





// //kullanıcının istediği kadar sayı girmesini sağlayın.
// //sayi girişi bitişi için 0'a basılması gereksin.
// //0'a basılıp sayı girişi bittiğinde kullanıcıya şu soruyu sorun: tek mi çift mi?
// //kullanıcı tek derse: tek sayıları ve toplamlarını.
// //çift derse çift sayıları ve toplamlarını yazdırın.

// let sayilar = [];
// let i = 0;
// do {
//     sayilar[i] = Number(prompt(i+1 + '.sayı: '));
//     i++;
// } while (sayilar[i-1] != 0);
// sayilar.pop();

// let sonucDizi = [];
// let toplam = 0;
// let tur;
// let cevap = prompt('Tek mi çift mi?');
// // console.log(cevap);
// if(cevap.toLocaleLowerCase() == 'tek'){
//     tur = 'Tek';
//     for (let i = 0; i < sayilar.length; i++) {
//         if (sayilar[i]%2 === 1) {
//             sonucDizi.push(sayilar[i])
//             toplam += sayilar[i];
//         }
//     }
// }
// else if(cevap.toLocaleLowerCase() == 'çift'){
//     tur = 'Çift';
//     for (let i = 0; i < sayilar.length; i++) {
//         if (sayilar[i]%2 === 0) {
//             sonucDizi.push(sayilar[i])
//             toplam += sayilar[i];
//         }
//     }
// }else{
//     alert('Lütfen "Tek" ya da "Çift yaz!');
//     // console.log('Lütfen "Tek" ya da "Çift yaz!');
// }
// console.log(sayilar);
// console.log(tur + ' sayılar: '+sonucDizi);
// console.log(tur + ' sayıların toplamı: '+ toplam);


// // promptda boşa basıp entera basınca ne sonuç döner
// // promptda bir şey yazmadan iptale basınca ne sonuç döner







