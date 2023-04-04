// 10) Verilen bir metnin her sözcüğününün ilk harfleri büyük geri kalanları küçük hale dönüştürecek functionı hazırlayınız.

let metin = 'Bu program Wissen Akademie öğrencileri tarafından hazırlanmıştır.';

function cevirici(){
    let metinDizisi = metin.split(" ");
    for (let i = 0; i < metinDizisi.length; i++) {
        metinDizisi[i] = metinDizisi[i].charAt(0).toUpperCase() + metinDizisi[i].slice(1);
    }
    let sonuc = metinDizisi.join(" ");
    console.log(sonuc);
}

cevirici();