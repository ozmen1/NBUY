namespace Project02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // csharp tip güvenlidir. dikkat.
            // bir değişkene isim verirken;
            // 1. alfanümerik karakterler kullanılmaz (alt tire hariç)
            // 2. türkçe karakter kullanılmaz. (zorunlu değil)
            // 3. özel ya da ayrılmış sözcükler kullanılmaz.
            // 4. değişken isimleri küçük büyük harf duyarlıdır.
            // 5. iki sözcüğün de baş harfinin büyük yazılması metodlar isimlendirilirken kullanılır. değişkenler için kullanılmaz.
            // 6. değişken camel casing.

            /*
            string adsoyad; //1
            string ad_soyad1; //1
            // string static; //3
            string Adsoyad; //4
            string AdSoyad; //5
            string ad; //6
            // string adSoyad; //6
            string zeynebinGecKalmaNedeni; //6
            */

            /*
            string adSoyad;
            adSoyad = "Alex de Souza";
            Console.WriteLine(adSoyad);
            Console.WriteLine("adSoyad"); //ctrl k ctrl c
            */

            //int yas;
            //yas = 19;
            //Console.WriteLine(yas);
            //string adSoyad = "Ahmet Candan";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine(adSoyad + "'ın yaşı \n" + yas);

            //TAM SAYI
            int sayi1 = 45; //32 bitlik yer kaplıyor
            byte sayi2 = 255; //küçük sayılarda kullanılır. 1 byte = 8 bit.
            Console.WriteLine(byte.MinValue + "/" + byte.MaxValue);
            Console.WriteLine(int.MinValue + "/" + int.MaxValue);
            long sayi3 = 1234567894748; //çok büyük sayılar. 64 bitlik.

            //string sayi4 = "15";
            //Console.WriteLine(sayi4+2); //burada 2'yi de stringe dönüştürüp çıktı verdi.

            //ONDALIKLI
            float a = 10.5f; //sonuna f. en hassas işlerde. uzay hesapları.
            double b = 20.6; //genel kullanım.
            decimal c = 100.65m; //sonuna m. parasal işlerde.

            //KARAKTER ve METİN
            string name = "Kerem"; //her bir string bir karakter dizisidir.
            char cinsiyet = 'e'; //tek tırnakta yazılır. 

            //MANTIKSAL
            bool evliMi = false;


        }
    }
}