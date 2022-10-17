namespace Project13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad; //değişkeni tanımlıyoruz ama sonra kullanmak için.
            //ad = "Engin";
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";





            //string[] adlar = new string[3];  //değişkeni tanımlıyoruz ama sonra kullanmak için. İçinde 3 adet string bilgi tutabilecek bir dizi.
            ////diziler eleman sayısı sürekli değişen durumlarda kullanılması zahmetli olur. çünkü en başta dizinin uzunluğu belirlenmiştir. statiktir.
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "Cemal Gündem";
            //adlar[2] = "Selin Dilci";
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}





            //int[] yaslar = new int[3];
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 }; //bu şekilde tanımlayınca baştan eleman sayısını belirtmeye gerek yok.
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam += rakamlar[i];
            //}
            //Console.WriteLine(toplam);




            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 }; //bu şekilde tanımlayınca baştan eleman sayısını belirtmeye gerek yok.
            //string okul = "Wissen Akademie"; //doğal haliyle her string bir karakter dizisidir.
            //Console.WriteLine(okul[0]);






            ////ÇALIŞMA: Klavyeden kullanıcının adını soyadını girmesini isteyiniz.
            ////Girilen ad soyadı aşağıya doğru BÜYÜK HARFLERLE yazdırınız.
            ////Engin Niyazi Ergül
            ///*
            // * E
            // * N
            // * G
            // * İ
            // * N
            //*/
            //Console.WriteLine("Lütfen adınızı soyadınızı giriniz: ");
            //string girilenMetin = Console.ReadLine().ToUpper();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    Console.WriteLine(girilenMetin[i]);
            //}







            //Console.Write("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine().ToLower();
            //Console.Write("Hangi karakterin sırasını bulmamı istersiniz? ");
            //string karakter = Console.ReadLine().ToLower();
            //int siraNo = girilenMetin.IndexOf(karakter) + 1; //0dan başladığı için sürekli 1 eksik söylüyor o yüzden +1 yaptık.
            //Console.Clear(); //sonucu temiz bir ekranda göstermek için.
            //Console.WriteLine($"Girilen Metin: {girilenMetin}\nAradığınız Karakter: {karakter}\nAradığınız Karakterin Girilen Metindeki Sıra Numarası: {siraNo}");






            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.Eleman:\t{rakamlar[i]}");  ////i+1 yazmamızın sebebi ekrana "0.eleman" bastırmaması.
            //}
            //Console.WriteLine($"En küçük:\t{rakamlar.Min()}\nEn büyük:\t{rakamlar.Max()}");







            ////dizinin içerisindeki en büyük sayıyı bulduracak algoritma. 
            ////kendimiz en büyük sayıyı buluyoruz.
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int enBuyuk = rakamlar[0];
            //int enKucuk = rakamlar[0];
            //for (int i = 1; i < rakamlar.Length; i++)  //i=0 iken i=1 yapmamızın sebebi: 2 kere döngüye girdiği için
            //{
            //    if (enBuyuk < rakamlar[i])
            //    {
            //        enBuyuk = rakamlar[i];
            //    }
            //    if (enKucuk > rakamlar[i])
            //    {
            //        enKucuk = rakamlar[i];
            //    }
            //}
            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enKucuk);










            ////İSTEĞE BAĞLI ÖDEV: BU diziyi küçükten büyüğe sıralayınız.
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };










            ////DİZİNİN TERS ÇEVRİLMİŞ HALİNİ BULMA ve TERS ÇEVRİLMİŞ HALİNİ BULMA
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");  ////i+1 yazmamızın sebebi ekrana "0.eleman" bastırmaması.
            //}
            //Console.WriteLine($"En küçük:\t{rakamlar.Min()}\nEn büyük:\t{rakamlar.Max()}");

            ////Console.WriteLine("Dizinin ters çevrilmiş hali");
            ////Console.WriteLine("****************************");
            ////Array.Reverse(rakamlar);
            ////for (int i = 0; i < rakamlar.Length; i++)
            ////{
            ////    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");  ////i+1 yazmamızın sebebi ekrana "0.eleman" bastırmaması.
            ////}


            //////Console.WriteLine("Dizinin küçükten büyüğe sıralanmış hali");
            //////Console.WriteLine("****************************");
            //////Array.Sort(rakamlar); //SORT DEFAULT OLARAK KÜÇÜKTEN BÜYÜĞE SIRALAR.
            //////for (int i = 0; i < rakamlar.Length; i++)
            //////{
            //////    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");  ////i+1 yazmamızın sebebi ekrana "0.eleman" bastırmaması.
            //////}


            ////////Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali");
            ////////Console.WriteLine("****************************");
            ////////Array.Sort(rakamlar); //SORT DEFAULT OLARAK KÜÇÜKTEN BÜYÜĞE SIRALAR.
            ////////Array.Reverse(rakamlar); //BÜYÜKTEN KÜÇÜĞE SIRALADI (TERS ÇEVİRDİ.)
            ////////for (int i = 0; i < rakamlar.Length; i++)
            ////////{
            ////////    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");  ////i+1 yazmamızın sebebi ekrana "0.eleman" bastırmaması.
            ////////}










            //ÖRNEKLER:
            ////ÖRNEK1 sayilar dizisinin elemanlarının ortalamasını bulup ekrana yazdıralım.
            //int[] sayilar = { 5, 6, 8, 12, 56, 78, 90, 113 };
            //int toplam = sayilar.Sum();
            //Console.WriteLine(toplam);


            ////ÖRNEK2. sayilar dizisindeki çift sayıları ekrana yazdırın.
            //int[] sayilar = { 5, 6, 8, 12, 56, 78, 90, 113 };
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[]);
            //    }
            //}


            ////ÖRNEK3. Sayılar dizisindeki sayıları yanlarında pozitif, negatif ya da işaretsiz olma bilgileriyle yazdıralım.
            //int[] sayilar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "Pozitif" :
            //        sayilar[i] < 0 ? "Negatif" :
            //        "İşaretsiz";
            //    Console.WriteLine($"{i + 1}. sayı: {sayilar[i]}\ttipi: {tip}");
            //}


            ////ÖRNEK 4. Kullanıcın gireceği bir metnin içindeki sesli harf sayısını ekrana yazdıralım.
            ////Contains (içeriyor mu?) metodunu kullanalım.
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        sesliHarfAdedi++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);


            ////ÖRNEK 5. Klavyeden girilen bir "CÜMLE"deki yine klavyeden girilecek bir kelimenin kaç kez geçtiğini bulduralım.
            //string ornekMetin = "Engin Niyazi Ergül";
            ////cümleyi parçalayalım.
            //string[] sozcukDizisi = ornekMetin.Split(" ");
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}


            ////ÖRNEK 5(gerçek çözüm). Klavyeden girilen bir "CÜMLE"deki yine klavyeden girilecek bir kelimenin kaç kez geçtiğini bulduralım.
            ////cümleyi parçalayalım.
            //int sozcukAdedi = 0;
            //Console.Write("Cümleyi giriniz: ");
            //string girilenCumle = Console.ReadLine();
            //Console.Write("Adedini bulmak istediğiniz sözcüğü giriniz: ");
            //string sayilacakSozcuk = Console.ReadLine();
            //string[] girilenCumleninDiziHali = girilenCumle.Split();
            //for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            //{
            //    if (sayilacakSozcuk.ToLower() == girilenCumleninDiziHali[i].ToString().ToLower())
            //    {
            //        sozcukAdedi++;
            //    }
            //}
            //Console.WriteLine($"{girilenCumle} içinde {sayilacakSozcuk} sözcüğü {sozcukAdedi} kez bulunmaktadır.");


            




            //ARAŞTIRMA ÖDEVİ: ÖDEV: 
            //Çok boyutlu dizileri araştırın.






            //PROJE ÖDEVİ: ÖDEV:
            //İçinde Türkçe karakterler hariç tüm küçük harfler, 0-9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-)
            //karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız.
            //çözüm: bu karakterlerin hepsinin bulunduğu bir dizi oluştur. şifreyi oluşturmak için 6 karakterlik boş bir dizi oluştur.
            //her indis için random methodunu kullanarak karakter çağır.
        }
    }
}