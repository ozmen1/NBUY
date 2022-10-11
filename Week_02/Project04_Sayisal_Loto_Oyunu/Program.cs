using System.Collections;

namespace Project04_Sayisal_Loto_Oyunu
{
    internal class Program
    {
        static int[] SayiUret()
        {
            Random rnd = new Random();
            int[] loto = new int[6];
            int sayi;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    sayi = rnd.Next(1, 50);
                } while (loto.Contains(sayi));
                loto[i] = sayi;
            }
            return loto;
        }

        static void Hile(int[] loto)
        {
            Console.WriteLine("HİLE");
            Console.WriteLine("****");
            foreach (var siradakiSayi in loto)
            {
                Console.WriteLine(siradakiSayi);
            }
        }

        static int TahminYap(int tahminSiraNo) //kullanıcının her tahmin yapışını burası sağlaayacak.
        {
            int tahmin;
            Console.Write($"{tahminSiraNo}. tahmininizi giriniz: ");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;
        }
        static void Main(string[] args)
        {
            /*
             * 1. sistem 6 tane farklı sayı üretsin (1-49 arasında)
             * 2. kullanıcıdan 6 tane tahmin alalım. //1-49 arası dışındaki tahminleri kabul etme!
             * 3. sonuç olarak kullanıcının kaç tane doğru tahmin yaptığını tahminleriyle birlikte yazdıralım.
             * 4. not: hiç doğru tahmin yapamazsa kaybetiiniz yazınız.
            */
            int[] loto = SayiUret();
            int[] tahminler = new int[6];
            Hile(loto);
            int tahmin;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    tahmin = TahminYap(i + 1);
                } while (tahmin < 0 || tahmin > 49);
                tahminler[i] = tahmin;
            }
            //baştan kaç tane doğru sayı tahmin edileceği bilinemeyince arraylist tanımladık.
            ArrayList bilinenler = new ArrayList(); //Arraylistlerin kaç elemanlı olacağı söylenmez! İçinde her bir eleman istenilen tipte değer tutabilir int, string, char vb.

            foreach (var siradakiTahmin in tahminler)  
            {
                if(loto.Contains(siradakiTahmin))
                {
                    bilinenler.Add(siradakiTahmin); 
                }
            }
            if (bilinenler.Count == 0)
            {
                Console.WriteLine("Kaybettiniz, hiç bilemediniz!");
            }
            else
            {
                Console.WriteLine($"Tebrikler, {bilinenler.Count} adet doğru tahmin yaptınız!");
                Console.WriteLine("Bildiğiniz sayılar:");
                foreach (var siradakiBilinen in bilinenler)
                {
                    Console.WriteLine(siradakiBilinen);
                }
            }

            Console.ReadLine(); //ekran hızlıca kapanmasın 
        }
    }
}