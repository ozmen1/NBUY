//using Solid03_OpenClosed.Before;
using Solid03_OpenClosed.After;


namespace Solid03_OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region before
            //Kare kare1 = new Kare(1);
            //Kare kare2 = new Kare(1);
            //Daire daire1 = new Daire(1);
            //object[] sekiller = new object[3] { kare1, kare2, daire1 };
            //Hesapla hesapla = new Hesapla();
            //Console.WriteLine("Sonuç: " + hesapla.AlanlariTopla(sekiller));
            #endregion

            #region after
            Kare kare1 = new Kare(1);
            Kare kare2 = new Kare(1);
            Daire daire1 = new Daire(1);
            Sekil[] sekiller = new Sekil[3] { kare1, kare2, daire1 };
            Hesapla hesapla = new Hesapla();
            Console.WriteLine("Sonuç: " + hesapla.AlanlariTopla(sekiller));
            #endregion
        }
    }
}