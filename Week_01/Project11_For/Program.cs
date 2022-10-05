namespace Project11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i+1 + "." + "merhaba");
            //} 



            ////1den 10'a kadar toplamını yazdır.
            //int toplam = 0;
            //for (int i = 1; i <= 11130; i++)
            //{
            //   toplam += i;
            //}
            //Console.WriteLine(toplam);




            //// 1 ile 10 arasındaki çift sayıların toplamını bul ve ekrana yazdır. burada döngü 10 defa dönüyor.
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }

            //}
            //Console.WriteLine(toplam);






            //// 1 ile 10 arasındaki çift sayıların toplamını bul ve ekrana yazdır. burada sadece 5 kere döngü dönüyor.
            //int toplam = 0;
            //for (int i = 0; i <= 10; i=i+2)
            //{
            //        toplam += i;
            //}
            //Console.WriteLine(toplam);







            //// 1 ile 10 arasındaki çift sayıların toplamını bul. burada sadece 5 kere döngü dönüyor. daha performanslı demek.
            //int toplam = 0;
            //for (int i = 0; i <= 10; i = i + 2)
            //{
            //    if (toplam % 2 == 0) toplam += i;
            //}
            //Console.WriteLine(toplam);



            // 1 ile 10 arasındaki çift sayıların toplamını ayrı tek sayıların toplamını ayrı bul.
            int ciftToplam = 0;
            int tekToplam = 0;
            for (int i = 0; i <= 10; i = i + 2)
            {
                if (i % 2 != 0)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine($"Tek toplam: {tekToplam}, Çift toplam: {ciftToplam}");
        }
    }
}