namespace Project07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tarih bilgisi spesifik bir formatta tutulur. karışıklıklar olmaması için.

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            DateTime dogumTarihi = new DateTime(1994, 01, 01); //01.01.1994 tarihi yaratıldı.
            DateTime bugun = DateTime.Now;
            TimeSpan span = bugun.Subtract(dogumTarihi);
            Console.WriteLine(span);
        }
    }
}