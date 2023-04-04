// Kullanıcıya her defasında 100'den büyük bir sayı girmesi için prompt ile veri girmesini isteyin. Eğer farklı bir değer girerse tekrardan değer girmesi talebinde bulunun.
// Kullanıcı 100 den büyük bir sayı veya boş satıra onay verene kadar döngüye devam edilmelidir.
// Burada kullanıcının sadece sayısal değerler gireceğini farzedin. Ayrıca sayısal değerleri kontrol için bir kod yazmak ile uğraşmayın.


let input = prompt("Lütfen 100'den büyük bir sayı giriniz: ");
if (input > 100 || input === '') {
    console.log(input);
}else{
    do {
        input = prompt("Lütfen 100'den büyük bir sayı giriniz: ");
    } while (input <= 100 || input !== '');
    console.log(input);
}
