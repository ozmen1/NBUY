namespace Project12_While;
class Program
{
    static void Main(string[] args)
    {
        // //while tekrar sayısı belli olmadığı durumlarda kullanılması daha doğru.
        // //belirli koşullar devam ettikçe dönmesini istediğimiz döngü.





        // //bu örnekte sonsuz döngü (kısır döngü) oluştu.
        // int sayac = 1;
        // while (sayac <= 5)
        // {
        //     System.Console.WriteLine("Merhaba Dünya!");
        // }




        // //ayrıca değişken kullanarak for'un yaptığı şeyi yaptık. bu örnekte for tercih edilebilir.
        // int sayac = 1;
        // while (sayac <= 5)
        // {
        //     System.Console.WriteLine("Merhaba Dünya!");
        //     sayac++;
        // }







        // //if ile çözüm. kullanıcıdan değer iste, exit dedikten sonra toplamı ekrana bastır.
        // int toplam = 0;
        // string girilenDeger = "";
        // int sayac = 1; ///X. sayı diye ekrana yazdırmak için. başlangıç değeri 1. ilk sayı.
        // while (girilenDeger != "exit")
        // {
        //     System.Console.Write($"{sayac}. sayıyı giriniz (çıkış için exit): ");
        //     girilenDeger = Console.ReadLine();
        //     if (girilenDeger != "exit")   toplam += Convert.ToInt32(girilenDeger);
        //     sayac++;
        // }
        // System.Console.WriteLine(toplam);






        // //try catch çözümü. ya sayı ya exit yazılacak. başka bir şey yazılmayacak.
        // int toplam = 0;
        // string girilenDeger = "";
        // int sayac = 1; ///X. sayı diye ekrana yazdırmak için. başlangıç değeri 1. ilk sayı.
        // while (girilenDeger != "exit")
        // {
        //     System.Console.Write($"{sayac}. sayıyı giriniz (çıkış için exit): ");
        //     girilenDeger = Console.ReadLine();
        //     try
        //     {
        //         toplam += Convert.ToInt32(girilenDeger);
        //     }
        //     catch (System.Exception)
        //     {
        //         System.Console.WriteLine(toplam);
        //         break;
        //     }
        //     sayac++;
        // }







        // //soru: klavyeden exit yazılana kadar isim girilmesini isteyen uygulama.
        // //çözüm 1.
        // string isim = "";
        // while (isim != "exit")
        // {
        //     System.Console.Write("İsim giriniz: ");
        //     isim = Console.ReadLine();
        // }
        // System.Console.WriteLine("Program sona erdi...");








        // //en az 1 kez döngünün içindekilerini yazmak için. do while döngüsü kullanılır.
        // //çözüm2.
        // string isim;
        // do
        // {
        //     System.Console.Write("İsim giriniz: ");
        //     isim = Console.ReadLine();
        // } while (isim != "exit");
        // System.Console.WriteLine("Program sona erdi...");







        // ///ÖDEV. Kodları düzelt!
        // ///klavyeden exit yazılana kadar sayı almaya devam eden ve bu sayıların toplamını exit
        // //yazılınca ekrana yazan program. do-while ile.
        // string girilenDeger = " ";
        // int sayac = 1;
        // int toplam = 0;
        // do
        // {
        //     try
        //     {
        //         if (girilenDeger != "exit")
        //         {
        //             System.Console.Write($"{sayac}. sayıyı giriniz: ");
        //             girilenDeger = Console.ReadLine();
        //             toplam += Convert.ToInt32(girilenDeger);
        //             sayac++;
        //         }
        //     }
        //     catch (System.Exception ex)
        //     {
        //         System.Console.WriteLine("Lütfen geçerli bir değer giriniz.");
        //         throw;
        //     }
        // } while (girilenDeger != "exit");
        // System.Console.WriteLine(toplam);








        // //rastgele değer üretme
        // Random rastgele = new Random();     //nesne yarattık. Random tipinde rastgele değişkeni/nesnesi yarattık.
        // int rastgeleSayi = rastgele.Next();
        // System.Console.WriteLine(rastgeleSayi);
        // int rastgeleSayi2 = rastgele.Next(100); //0-100 arasında sayı üretir. 0 dahil, 100 dahil değildir.
        // System.Console.WriteLine(rastgeleSayi2);
        // int rastgeleSayi3 = rastgele.Next(1000, 2000); //1000-2000 arasında rastgele sayı üretir, 1000 dahil 2000 hariç. 2000'i dahil etmek için 2001 yazmak gerek.





        // //OYUN: Uygulamanın rastgele üreteceği bir sayıyı kullanıcının tahmin etmesini isteyeceğiz.
        // //Rastgele üretilecek sayı 1-101 arasında olsun. (100 dahil 101 dahil değil)
        // //Kullanıcı rastgele sayıdan küçük veya büyük bir sayı girdiğinde kullanıcıya uygun bir mesaj verilsin.
        // //Doğru sayıyı tahmin edene kadar uygulama çalışsın.
        // //Kullanıcı doğru sayıyı tahmin ettiyse ya da 5 hakkını kullandıysa uygulama sonra ersin.
        // //döngünün içerisinde tebrikler veya kaybettiniz yazmakla uğraşma. döngüde hak hesabı ile uğraş. sadece hakkı dolmadığı sürece döngüde kal.
        // Random rnd = new Random();
        // int uretilenSayi = rnd.Next(1, 101);
        // System.Console.WriteLine($"HİLE: {uretilenSayi}"); //testi kolay yapmak için hile yaptık.
        // System.Console.WriteLine("******************");
        // int tahminEdilenSayi; //döngüde 5-10 kere tekrar değişken tanımlamaya lüzum olmadığı için döngünün üstüne yazdık.
        // int hak = 1; //kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi bunda tutulacak.
        // int hakSiniri = 5; //kullanıcının toplam kaç hakka sahip olduğu bilgisi.

        // // do
        // // {
        // //     System.Console.Write($"{hak}. tahmininizi giriniz(1-100 arasında): ");  //hak++ yazmamızın sebebi ilk çalıştırmada hak=1-1=0 olmasın diye
        // //     tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
        // //     if (hak == hakSiniri && uretilenSayi != tahminEdilenSayi)
        // //     {
        // //         System.Console.WriteLine("Kaybettiniz");
        // //         break;
        // //     }
        // //     if (tahminEdilenSayi > uretilenSayi)
        // //     {
        // //         System.Console.WriteLine("Büyük bir değer girdiniz. Daha küçük bir değer girerek yeniden deneyiniz!");
        // //     }
        // //     else if (uretilenSayi > tahminEdilenSayi)
        // //     {
        // //         System.Console.WriteLine("Küçük bir değer girdiniz. Daha büyük bir değer girerek yeniden deneyiniz!");
        // //     }
        // //     else
        // //     {
        // //         System.Console.WriteLine("Tebrikler!");
        // //     }
        // //     hak++;
        // // } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);

        // do
        // {
        //     System.Console.Write($"{hak}. tahmininizi giriniz(1-100 arasında): ");
        //     tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
        //     if (tahminEdilenSayi > uretilenSayi)
        //     {
        //         System.Console.WriteLine("büyük girdin");
        //     }
        //     else if (tahminEdilenSayi < uretilenSayi)
        //     {
        //         System.Console.WriteLine("küçük girdin");
        //     }
        //     if (tahminEdilenSayi != uretilenSayi)
        //     {
        //         hak++;
        //         if (hak <= hakSiniri)
        //         {
        //             System.Console.WriteLine("Kaybettin.");
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Kazandın.");
        //     }
        // }
        // while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);

        // //Eğer program bu satıra gelmiş ise ya doğru tahminde bulunulmuştur ya da hak sonra ermiştir.
    }
}
