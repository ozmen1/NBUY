using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03_Sayi_Bulmaca_With_Methods
{
    internal class Oyna
    {
        public static int Uret()
        {
            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 101);
            System.Console.WriteLine($"HİLE: {uretilenSayi}");
            return uretilenSayi;
        }

        public static int TahminGir(int tahminSiraNo)
        {
            System.Console.Write($"{tahminSiraNo}. tahmininizi giriniz(1-100 arasında): ");
            int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            return tahminEdilenSayi;
        }

        public static string Tespit(int tahminEdilenSayi, int uretilenSayi)
        {
            if (tahminEdilenSayi > uretilenSayi)
            {
                string mesaj = "Büyük girdin!";
            }
            else if (tahminEdilenSayi < uretilenSayi)
            {
                string mesaj = "Küçük girdin!";
            }
            if (tahminEdilenSayi != uretilenSayi)
            {
                int hak++;
                if (hak <= hakSiniri) System.Console.WriteLine(mesaj); //son mesajda küçük girdin büyük girdin mesajına gerek yok.
            }
            return mesaj;
        }
    }
}
