namespace Project05_MetinselMetotlar;
class Program
{
    static void Main(string[] args)
    {
        // bu projede metinsel işlemlere dair bazı metotlar öğreneceğiz.

        //string metin = "Wissen Akademie";
        //int uzunluk = metin.Length;
        //Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");



        //string metin = "WİSSEN";
        //string kucukMetin = metin.ToLower();
        //Console.WriteLine(kucukMetin);
        //string buyukMetin = kucukMetin.ToUpper();
        //Console.WriteLine(buyukMetin);  



        //string m1 = "Wissen";
        //string m2 = "Wissen Akademie";
        //int sonuc = String.Compare(m1, m2);
        //Console.WriteLine(m1);
        //Console.WriteLine(m2);
        //Console.WriteLine(sonuc);



        //Console.Write("Lütfen ilk metni giriniz: ");
        //string m1 = Console.ReadLine();
        //Console.Write("Lütfen ikinci metni giriniz: ");
        //string m2 = Console.ReadLine(); 
        //int sonuc = String.Compare(m1, m2);
        //if (sonuc == 0)
        //{
        //    Console.WriteLine("Girilen iki metin birbirine eşittir.");
        //}
        //else
        //{
        //    Console.WriteLine("Girilen iki metin birbirinden farklıdır.");
        //}



        ////concat metoduyla stringleri birleştirme. operatör kullanmadık.
        //string m1 = "İşkur";
        //string m2 = "Eğitimleri";
        ////string sonuc = m1 + m2;
        //string sonuc = String.Concat(m1, m2);
        //Console.WriteLine(sonuc);
        //string m3 = "Wissen";
        //string sonuc2 = String.Concat(m1, m2, m3);
        //Console.WriteLine(sonuc2);


        //string ad = "Kerem";
        //int yas = 28;
        //string okul = "BAU";
        //string sonuc = String.Concat("Benim adım ", ad, ". " ,yas, " yaşındayım. Okuduğum okulun adı ", okul, ".");
        //Console.WriteLine(sonuc);
        //Console.WriteLine("Benim adım " + ad + ". " + yas + " yaşındayım. Okuduğum okulun adı " + okul + ".");
        //Console.WriteLine($"Benim adım {ad}. {yas} yaşındayım. Okuduğum okulun adı {okul}.");


        //string metin = "Merhaba. Bu hafta eğitime başladık.";
        //bool sonuc = metin.Contains("wissen");
        //Console.WriteLine(sonuc);



        //string adres = "Selami Ali Mahallesi, Can Sokak, Numara: 6, Kadıköy/İstanbul";
        //bool sonuc = adres.EndsWith("İstanbul");
        //Console.WriteLine(sonuc);
        //bool sonuc2 = adres.StartsWith("İstanbul");
        //Console.WriteLine(sonuc2);


        ////adres içindeki C harfi kaçıncı sıradadır? ---- küçük c'leri bulamıyor.
        //string adres = "Selami Ali Mahallesi, Can Sokak, Numara: 6, Kadıköy/İstanbul";
        //int siraNo = adres.IndexOf('C');
        //Console.WriteLine($"C harfi {adres} adresinde {siraNo}. sıradadır.");



        //////adres içindeki C harfi kaçıncı sıradadır? ---- küçük c'leri de buluyor. manipülasyon yapıldı.
        //string adres = "Selami Ali Mahallesi, Can Sokak, Numara: 6, Kadıköy/İstanbul";
        //string aranacakIfade = "c";
        //int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
        //Console.WriteLine($"C harfi {adres} adresinde {siraNo}. sıradadır.");



        //string adres = "Selami Ali Mahallesi, Can Sokak, Numara: 6, Kadıköy/İstanbul";
        //string aranacakIfade = "Can Sokak";
        //int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
        //Console.WriteLine($"{aranacakIfade} ifadesi {adres} içinde {siraNo}. sıradadır.");



        //string metin = "Wissen Akademie";
        //Console.WriteLine($"Metnin ilk hali: {metin}");
        //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali: {metin.Remove(6)}");  //boşluğu da sildik.
        //Console.WriteLine($"Aka ifadesi silindikten sonraki hali: {metin.Remove(7, 3)}");



        ////replace
        //string urunAd = "IPhone 13 Pro"; //iphone-13-pro çevir
        //// string sonuc1 = urunAd.Replace(' ', '-');               //hatalı sonuç. char null olmaz.
        //// string sonuc = (urunAd.Replace(" ", "-")).ToLower();    //string içi boş olabilir.
        //string sonuc = urunAd.ToLower().Replace(" ", "-");
        //Console.WriteLine(sonuc);
        //string sonuc2 = urunAd.Replace("IPhone", "Samsung");
        //Console.WriteLine(sonuc2);
    }
}
