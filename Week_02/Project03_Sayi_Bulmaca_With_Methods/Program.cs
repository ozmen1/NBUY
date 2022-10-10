namespace Project03_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sayı bulmaca oyununu, yeni öğrendiğimiz methods konusu bağlamında yeniden hazırlayınız.
            //5 tercih hakkı olsun
            //puan sistemi olsun (1. tercihinde 50, bilmedikçe 10'ar 10'ar düşsün)
            //oyunu kaybettiğinde ya da kazandığında yeniden oynamak istiyorsa oynayabilsin.

            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 101);
            System.Console.WriteLine($"HİLE: {uretilenSayi}"); //testi kolay yapmak için hile yaptık.
            System.Console.WriteLine("******************");
            int tahminEdilenSayi; //döngüde 5-10 kere tekrar değişken tanımlamaya lüzum olmadığı için döngünün üstüne yazdık.
            int hak = 1; //kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi bunda tutulacak.
            int hakSiniri = 5; //kullanıcının toplam kaç hakka sahip olduğu bilgisi.
            string mesaj = "";

            do
            {
                System.Console.Write($"{hak}. tahmininizi giriniz(1-100 arasında): ");
                tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (tahminEdilenSayi > uretilenSayi)
                {
                    mesaj = "Büyük girdin!";
                }
                else if (tahminEdilenSayi < uretilenSayi)
                {
                    mesaj = "Küçük girdin!";
                }
                if (tahminEdilenSayi != uretilenSayi)
                {
                    hak++;
                    if (hak <= hakSiniri) System.Console.WriteLine(mesaj); //son mesajda küçük girdin büyük girdin mesajına gerek yok.
                }
            }
            while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);
            mesaj = tahminEdilenSayi == uretilenSayi ? "Kazandınız" : "Kaybettiniz";  //ternery if
            System.Console.WriteLine(mesaj);
        }
    }
}