// Değişken sayıda parametre alan toplam isminde bir fonksiyon tanımlayınız.

function toplam(){
    let x;
    let i = 1;
    let toplamSayi = 0;
    do {
        x = parseInt(prompt('Lütfen bir sayı giriniz: '));
        toplamSayi += x;
        i++;
    } while (x != 0);
    console.log(toplamSayi);
}

toplam();