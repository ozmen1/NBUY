namespace Project08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //runtime hatalar
            //öngörebildiğimiz hataları catch bloğunda yakaladık.

            ////hata elde etmek için: 1520'yi 2'ye böl. byte'dan daha büyük bir sayı çıksın. 
            //try
            //{
            //    Console.Write("1. Sayıyı giriniz: ");
            //    double sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("2. Sayıyı giriniz: ");
            //    double sayi2 = Convert.ToInt32(Console.ReadLine());
            //    byte sonuc = Convert.ToByte(sayi1 / sayi2); //hata elde etmek için: 1520'yi 2'ye böl. byte'dan daha büyük bir sayı çıksın. 
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception hatamesaj)
            //{

            //    //Console.WriteLine("İşlemde bir hata oluştu.");
            //    Console.WriteLine(hatamesaj.Message);   //ingilizce hata mesajı çıktı.
            //}







            //örnek hata senaryosu: sayı bölü sıfır tanımsız! 
            try
            {
                Console.Write("1. Sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi1 / sayi2; //hata elde etmek için: 1555555555555555555555555'yi 2'ye böl. int'dan daha büyük bir sayı çıksın. 
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölme hatası.");
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("Çok büyük bir sayı girdiniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen hata.");
            }
            finally
            {
                //try ya da catch bloklarından hamgisi çalışırsa çalışsın her halukarda çalışmasını istedğimizi kodlar burada çalışır.
                Console.WriteLine("Program sona ermiştir.");
            }



        }
    }
}