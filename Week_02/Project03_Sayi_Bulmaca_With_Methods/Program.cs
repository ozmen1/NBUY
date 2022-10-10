namespace Project03_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Uret();
            TahminGir();
            //sayı bulmaca oyununu, yeni öğrendiğimiz methods konusu bağlamında yeniden hazırlayınız.
            //5 tercih hakkı olsun
            //puan sistemi olsun (1. tercihinde 50, bilmedikçe 10'ar 10'ar düşsün)
            //oyunu kaybettiğinde ya da kazandığında yeniden oynamak istiyorsa oynayabilsin.
            int tahminEdilenSayi; //döngüde 5-10 kere tekrar değişken tanımlamaya lüzum olmadığı için döngünün üstüne yazdık.
            int hak = 1; //kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi bunda tutulacak.
            int hakSiniri = 5; //kullanıcının toplam kaç hakka sahip olduğu bilgisi.
            string mesaj = "";

            do
            {
                Tespit();
            }
            while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
            mesaj = tahminEdilenSayi == uretilenSayi ? "Kazandınız" : "Kaybettiniz";  //ternery if
            System.Console.WriteLine(mesaj);
        }
    }
}