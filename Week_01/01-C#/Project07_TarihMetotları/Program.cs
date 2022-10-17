namespace Project07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tarih bilgisi spesifik bir formatta tutulur. karışıklıklar olmaması için.

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            //DateTime dogumTarihi = new DateTime(1994, 01, 01); //01.01.1994 tarihi yaratıldı.
            //DateTime bugun = DateTime.Now;
            //TimeSpan span = bugun.Subtract(dogumTarihi);
            //Console.WriteLine(Math.Floor(span.TotalDays));  //toplam gün sayısı hesabıyla ne kadar yaşadığın. ondalık basamak kalmayacak şekilde yuvarladık.


            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString());   //uzun tarih 5 Ekim 2022 Çarşamba
            //Console.WriteLine(bugun.ToLongTimeString());   //uzun saat 13:35:30
            //Console.WriteLine(bugun.ToShortDateString());  //5.10.2022
            //Console.WriteLine(bugun.ToShortTimeString());  //13.35



            ////bir sonraki yılın ilk gününün tarihini bulduralım.
            //DateTime bugun = DateTime.Now;
            //int yil = bugun.Year + 1;
            //Console.WriteLine(yil);
            //DateTime sonuc = new DateTime(yil, 1, 1);
            //Console.WriteLine(sonuc.ToLongDateString());



            ////bir sonraki ayın ilk gününün tarihini bulduralım.
            //DateTime bugun = DateTime.Now;
            //int ay = bugun.Month + 1;
            //DateTime sonuc = new DateTime(bugun.Year, ay, 1);
            //Console.WriteLine(sonuc.ToLongDateString()); //12. ayda bir sonraki ayın 13 olma ihtimali var. buraya kontrol mekanizması eklemek lazım.



            ////ÖDEV: Ertesi günün tarihini bulup ekrana yazdıran programı yazınız
            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun + 1); // ertesi günün tarihi böyle bulunmaz.



            ////ÖDEV
            DateTime bugun = DateTime.Now;
            DateTime yarin = bugun.AddDays(1);
            Console.WriteLine($"Yarının tarihi: {yarin.ToLongDateString()}");




        }
    }
}