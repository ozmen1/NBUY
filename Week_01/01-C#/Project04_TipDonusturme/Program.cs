namespace Project04_TipDonusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5; //işaret tutmaz.
            //short b = 10;
            //sbyte c = -10; //8 bitin 1 bitini işareti tutmak için kullanılıyor.
            //int d = a + b + c; //implicit convert - örtülü dönüştürme
            //Console.WriteLine($"Sonuç(d)= {d}");

            //string metin = "NBUY";
            //char karakter = 'k';
            //object e = metin + karakter + d; //her bir şeyin ortak bir atası vardır: object.
            //Console.WriteLine($"Object = {e}"); //burada da implicit convert var.

            //runtime error!!!
            //byte a = 155;
            //byte b = 102;
            //// byte c = Convert.ToByte(a + b); //explicit convert, bilinçli bir dönüştürme var.
            ////Console.WriteLine($"Sonuc: {c}");

            //unboxing
            //byte d = (byte)(a + b); //unboxing. tur attı. burada bir veri kaybı var. veri kaybına razıysak unboxing yapabiliriz.
            //Console.WriteLine($"Sonuç : {d}");
            //int a = 511;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            byte a = 155;
            byte b = 111;
            int c = a + b; //bytelar sığmayacağı için sonuç int'e atanır. burada bir implicit dönüştürme var csharp olayı hallediyor.
            Console.WriteLine(c);

            //genellikle Converttoint32 kullanılıyor.
            Convert.ToDouble(c);
            Convert.ToInt64(c);
            

        }
    }
}