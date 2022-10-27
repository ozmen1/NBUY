// function selamVer(){
//     console.log('Merhaba Javascript');
// }


// selamVer();





// function selamVer(isim){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Kerem');
// selamVer('Engin');




// function selamVer(isim=''){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Kerem');
// selamVer('Engin');
// selamVer();







// function selamVer(isim='Dünya'){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Kerem');
// selamVer('Engin');
// selamVer();






// RETURN!!!!

// function yasHesapla(dogumYili){
//     return new Date().getFullYear() - dogumYili;
// }

// console.log(yasHesapla(1975));;











// let yas = 2000;

// if (yas < 30) {
//     console.log('yaşınız uygun değildir.');
// }else{
//     console.log('kabul edildiniz.');
// }







// //bir tutar bilgisi alıp, bu tutarın kdv'sini hesaplayıp geri döndüren function

// function kdvHesapla(tutar){
//     let sonuc = (tutar * 0.18);
//     sonuc = sonuc.toFixed(2);
//     return sonuc;
// }

// console.log(kdvHesapla(117));











// function kdvHesapla(){
//     for (let i = 0; i < arguments.length; i++) {
//         console.log(arguments[i] * 0.18);
//     }
// }

// kdvHesapla(100, 200, 1000);







//kendisine gönderilecek tutar bilgilerini kullanarak kdvleri hesaplayıp, geriye hesaplanmış kdvleri içinde barındıran bir dizi döndüren function

function kdvHesapla(){
    let sonuc = [];
    let kdv = 0;
    for (let i = 0; i < arguments.length; i++) {
        kdv = arguments[i] * 0.18;
        kdv = kdv.toFixed(2);
        sonuc.push(kdv);
    }
    return sonuc;
}

console.log(kdvHesapla(100, 450, 7800));