namespace Project14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 45;
            //int b = a * 2;
            //Random rnd = new Random();  //adresleme yapıldı.
            //int c = rnd.Next(); //Next rnd'nin içinde değil rnd'nin işaret ettiği Random nesnesinde.







            Kisi kisi1 = new Kisi();   //Nesne ürettik. Property'i çağırdık. Yeni bir instance aldık, örnek aldık!!!!**** her bir new yeni bir nesne yaratır. Kisi reference type'dır.
            kisi1.Ad = "Kerem";
            kisi1.Yas = 20;
            kisi1.Meslek = "Software Developer";

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Saliha";
            kisi2.Yas = 21;
            kisi2.Meslek = "Öğretmen";

            Kisi kisi3 = new Kisi();
            kisi3.Ad = "Cemal";
            kisi3.Yas = 40;
            kisi3.Meslek = "Şair";





            Araba araba1 = new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Kırmızı";





            DateTime bugun = DateTime.Now;
            Random rnd2 = new Random();

        }
        class Kisi
        {
            //classların isimlendirilmesinde her kelimenin ilk harfi büyük yapılır. (aynı şekilde property'lerde de)
            //form doldurma mantığı. template oluşturmak.
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }
        }
        class Araba
        {
            //ERİŞİM BELİRLİYİCİLER: bir property'nin dışarıdan yani içinde bulunduğu class'ın dışından erişim seviyesini belirleyen anahtar sözcüklere denir.
            //public, private, internal, protected
            //eğer herhangi bir erişim belirleyici kullanılmamışsa default erişim belirleyici private olarak kabul edilir.
            public string Renk { get; set; }  //public dışarıdan erişilebilir.
            string VitesTuru { get; set; } //private olanlar sadece bu class içerisinde erişilebilir. private yazmazsak da default olarak private olur.
            public string Marka { get; set; }

        }
    }
}