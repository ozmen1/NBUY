namespace Project06_MatematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 43;
            //int sayi2 = 55;
            //int minimum = Math.Min(sayi1, sayi2);
            //int maximum = Math.Max(sayi1, sayi2);
            //Console.WriteLine($"Minimum: {minimum}\nMaximum: {maximum}");



            //int taban = 4;
            //int us = 2;
            //// int sonuc = Math.Pow(taban, us); //Pow metodu double döndürür. Bu yanlış bir kullanımdır.
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine(sonuc);



            //Console.WriteLine("Taban: ");
            //int taban = Convert.ToInt32(Console.ReadLine()); //readline methodu sadece string aldığı için int'e çevirdik.
            //Console.WriteLine("Üs: ");
            //int us = int.Parse(Console.ReadLine()); //stringi int'e çevirir.parse ediyor.
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine(sonuc);



            double sayi = 5.493486;
            Console.WriteLine(Math.Ceiling(sayi));  //üste yuvarlamak. tavana.
            Console.WriteLine(Math.Floor(sayi));    //alta yuvarlamak. tabana.
            Console.WriteLine(Math.Round(sayi, 2)); //seçilen basamağa yuvarla.

        }
    }
}