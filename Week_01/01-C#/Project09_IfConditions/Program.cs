namespace Project09_IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(logical)
             * {
             *      bool true ise yapılacak işler
             * }
             *  
             */



            //// negatif sayı girilirse program hata verir!
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //byte yas = Convert.ToByte(Console.ReadLine());     //byte 155ten küçük. 155 yaşında kimse olamaz zaten int kullanmaya gerek yok.
            //if (yas < 18)
            //{
            //    Console.WriteLine("18 yaşından küçüklere giriş yasak!");
            //}
            //else if (yas > 18)
            //{
            //    Console.WriteLine("Hoşgeldiniz!");
            //}
            //else     //son olasılık için kullanılır.
            //{
            //    Console.WriteLine("Veli ile giriş serbest.");
            //}





            ////Girilen iki sayıdan büyük olanı yazdır.
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());    
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"Büyük sayı: {sayi1}");
            //}
            //else if (sayi1 < sayi2)
            //{
            //    Console.WriteLine($"Büyük sayı: {sayi2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Sayı1 ({sayi1}) ve Sayı2 ({sayi2}) birbirine eşittir.");
            //}





            ////Girilen üç sayıdan büyük olanı yazdıralım. bu algoritma bu şekilde çözülmez. yanlış algoritma.
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üçüncü sayıyı giriniz: ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    if (sayi1 > sayi3)
            //    {
            //        Console.WriteLine("En büyük sayı: " + sayi1);
            //    }
            //}
            //if (sayi2 > sayi1)
            //{
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine("En büyük sayı: " + sayi2);
            //    }
            //}
            //if (sayi3 > sayi1)
            //{
            //    if (sayi3 > sayi2)
            //    {
            //        Console.WriteLine("En büyük sayı: " + sayi3);
            //    }
            //}



            ////En büyük sayıyı ekrana bastır. 2'den fazla karşılaştırma olursa and veya or kullan.
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Üçüncü sayıyı giriniz: ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 >= sayi2 && sayi1 >= sayi3)
            //{
            //    Console.WriteLine(sayi1);
            //}
            //else if (sayi2 >= sayi1 && sayi2 >= sayi3)
            //{
            //    Console.WriteLine(sayi2);
            //}
            //else if (sayi3 >= sayi1 && sayi3 >= sayi2)
            //{
            //    Console.WriteLine(sayi3);
            //}




            ////ekrana her defasında buyuk sayıyı bastırmadan kontrol yaptıktan sonra ekrana en buyuk sayıyı bastırmak.
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayi = 0;  //başlangıç değeri vermek gerek.
            //if (sayi1 > sayi2)
            //{
            //    buyukSayi = sayi1;
            //}
            //else if (sayi2 > sayi1)
            //{
            //    buyukSayi = sayi2;
            //}
            //Console.WriteLine(buyukSayi);




            ////Ternery if
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayi = sayi1 > sayi2 ? sayi1 : sayi2;
            //Console.WriteLine(buyukSayi);





            ////Ternery if kullanarak eşitlikleri de kontrol ettik. girinti vererek okunurluğu artırdık.
            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //string sonuc = sayi1 > sayi2 ? "1. sayı 2. sayıdan büyüktür." : 
            //                sayi2 > sayi1 ? "2. sayı 1. sayıdan büyüktür." : 
            //                "İki sayı birbirine eşittir.";
            //Console.WriteLine(sonuc);






        }
    }
}