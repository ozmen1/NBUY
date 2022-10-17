namespace Project11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //döngülerde i kullanılması bir alışkanlık. şart değil.
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






            //// 1 ile 10 arasındaki çift sayıların toplamını ayrı tek sayıların toplamını ayrı bul.
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        tekToplam += i;
            //    }
            //    else
            //    {
            //        ciftToplam += i;
            //    }
            //}
            //Console.WriteLine($"Tek toplam: {tekToplam}, Çift toplam: {ciftToplam}");







            ////klavyeden iki sayı gir. bu sayıların arasındaki sayıları topla ve ekrana yaz.
            //Console.WriteLine("1. Sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);







            ////klavyeden iki sayı gir. bu sayıların arasındaki sayıları topla ve ekrana yaz. 1. sayı 2. sayıdan küçük girilirse ihtimali
            //Console.WriteLine("1. Sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //if (sayi2 > sayi1)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;
            //    }
            //}
            //else
            //{
            //    for (int i = sayi1; i >= sayi2; i--) //tersine döngü oluşturduk.
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);







            ////klavyeden iki sayı gir. bu sayıların arasındaki sayıları topla ve ekrana yaz. 1. sayı 2. sayıdan küçük girilirse. min max kullanarak.
            //Console.WriteLine("1. Sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min = Math.Min(sayi1, sayi2);   
            //int max = Math.Max(sayi1, sayi2);   
            //    for (int i = min; i <= max; i++)
            //    {
            //        toplam += i;
            //    }
            //Console.WriteLine(toplam);








            ////kullanıcıdan bir sayı girmesini iste ancak kullanıcı sayı girmeye devam ettikçe girilen sayıların toplanmasını sağlayalım.
            ////sayı adedi belirsizdir. uygulamanın bitip ekrana toplamı yazdırabilmesi için kullanıcının sayı yerine exit yazmasını kontrol et.
            ////x. sayıyı giriniz şeklinde mesaj versin.
            ////şuana kadar girilen sayıların toplamını da söylesin. her adım toplam değerini de ekrana versin.
            ////sonuçta x + y + z = sonuç işlemini de matematiksel olarak ekrana bastırsın.
            ////x + y + z + = sonuc şeklinde veriyor. 3 karakter silinecek.
            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetin = "";
            //string arti = " + ";
            //for (int i = 1; i < 10000000; i++)
            //{
            //    Console.Write(i + ". sayıyı giriniz (çıkış için exit)" + "(geçerli toplam: " + toplam + "): ");
            //    girilenDeger = Console.ReadLine();
            //    if (girilenDeger.ToLower() == "exit") //csharpta küçük büyük harf duyarlıdır. EXIT yazarsa küçük harfe çevirecek.
            //    {
            //        break; //içinde bulunulan döngünün tamamlanmasını beklemeden istenilen bir anda durdurulması için kullanılır.
            //    }
            //    sonucMetin = sonucMetin + girilenDeger + arti;
            //    toplam += Convert.ToInt32(girilenDeger);
            //}
            //int alinacakKisminUzunlugu = sonucMetin.Length - arti.Length; //fazla karakterleri silmek için.
            //sonucMetin = sonucMetin.Substring(0, alinacakKisminUzunlugu);
            //Console.WriteLine($"{sonucMetin} = {toplam}");





            ////SORU: 5x5'lik bir kare biçimini yıldız işaretleriyle oluşturan uygulamayı yazınız.
            //int satir = 5;
            //int sutun = 5;
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("*"); //writeline kullanmamak gerek. yoksa yıldızları hep alt alta koyar.
            //    }
            //    Console.WriteLine();
            //}






            ////SORU 5x5 lik içi boş kare, çevresi * olacak.
            ///*
            // * *****
            // * *   *
            // * *   *
            // * *   *
            // * *****
            // */

            //int satir = 5;
            //int sutun = 5;
            //for (int i = 1; i <= satir; i++)
            //{
            //    for (int j = 1; j <= sutun; j++)
            //    {
            //        //çeşitli kontroller. 0. ve 4. satırlar tam dolu. 1,2 ve 3. satırların başı ve sonu dolu.
            //        if (i == 1 || i == satir)  // eğer 1. veya son satırdaysan
            //        {
            //            Console.Write("*"); 
            //        }
            //        else if (j == 1 || j == sutun) // eğer 1. veya son sütundaysan
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}









            //ÖDEV: üstteki içi boş kareyi oluşturan uygulamayı adım adım çalıştırarak anlamaya çalışın.







            //ÖDEV-1: 1-100 arasındaki sayıların ortalamasını bulduran program.







            //ÖDEV-2: 1-100 arasındaki çift, tek ve 5in katı olan sayıların adetleri ve toplamlarını ekrana yazdıran program.






            //ÖDEV-3: Aşağıdaki yüksekliği 5, tabanı 9 birim olan yıldızlardan oluşan dik üçgeni çizdiren program.
            // *
            // ***
            // *****
            // *******
            // *********



            Console.WriteLine("Merhaba Dünya!")

        }
    }
}