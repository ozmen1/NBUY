namespace Project02_Methods
{
    public class Program
    {

        //static void Topla(int sayi1, int sayi2 /*burada argümanlar yazılır*/)
        //{
        //    kendi içinde yazılı kodları çalıştırıp tamamlanıyorsa = void.
        //    method isimlerinin ilk harfi büyük.
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Toplam: {toplam}");
        //}

        //static void Cikart(int sayi1, int sayi2)
        //{
        //    int cikart = sayi1 - sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Fark: {cikart}");
        //}










    //    public static int Topla(int sayi1, int sayi2)
    ////dönüş tipi olan metod:
    //{
    //    return sayi1 + sayi2;
    //}
  //  static int Cikart(int sayi1, int sayi2)
        ////dönüş tipi olan metod:
        //{
        //    return sayi1 - sayi2;
        //}










        static int SiraNoBul(string metin, char karakter)
        {
            int sonuc = metin.IndexOf(karakter);
            return sonuc;
        }




        static bool VarMi(string metin, char karakter)
        {
            bool sonuc = metin.Contains(karakter);
            return sonuc;
        }


        static void Main(string[] args) //METHOD
        {
            //Console.Write("Birinci sayıyı giriniz: ");
            //int s1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int s2 = int.Parse(Console.ReadLine());

            ////Topla(s1, s2);
            ////Cikart(s1, s2);

            //int toplam = Topla(s1, s2);
            //int cikart = Cikart(s1, s2);
            //Console.WriteLine($"Toplam: {toplam}\tFark: {cikart}\tToplam - Fark: {toplam - cikart}");









            //kendisine verilen metnin içinde, aradığımız karakterin kaçıncı sırada olduğunu bulan metodu hazırlayınız. (IndexOf)
            Console.WriteLine(SiraNoBul("wissen akademie", 'a'));








            //kendisine verilen metnin içinde, aradığımız karakterin olup olmadığını bize söyleyen bir metodu hazırlayınız. (Contains)
            Console.WriteLine(VarMi("wissen akademi", 'ş') == true ? "İçinde geçiyor" : "İçinde geçmiyor");






            #region MethodOverloads
            MethodOverload methodOverload = new MethodOverload();

            Console.WriteLine(methodOverload.Topla(24, 45));

            Console.WriteLine(methodOverload.Islem(false, 24, 45));

            int[] sayilar = { 56, 44, 55, 77, 89 };
            Console.WriteLine(methodOverload.Topla(sayilar));
            #endregion



        }
    }
}