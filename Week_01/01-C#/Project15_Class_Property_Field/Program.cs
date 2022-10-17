namespace Project15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci(); //içi boş form oluştu şimdi. (instance)
            ogrenci1.OgrenciNo = 11;
            ogrenci1.Ad = "Kerem";
            ogrenci1.Sinif = "9A";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrenciNo = 12;
            ogrenci2.Ad = "Kemal";
            ogrenci2.Sinif = "10B";

            Ogrenci ogrenci3 = new Ogrenci()  //bu şekilde de yazılabilir.
            { 
                OgrenciNo = 15, 
                Ad = "Umay", 
                Sinif = "10C" 
            };
            Ogrenci[] ogrenciler = { ogrenci1, ogrenci2, ogrenci3 }; //int[] sayilar = { 32, 46, 16 };  ile aynı mantık.
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"Ad: {ogrenciler[i].Ad}, Sınıf: {ogrenciler[i].Sinif}");
            //}

            //foreach (var siradakiOgrenci in ogrenciler) //hepsini gez mantığında bir yapı. tek eksiği o sırada kaçıncı sırada öğrenci olduğunu tespit etmek mümkün değil. for döngüsüne göre kullanımı çok kolay.
            //{
            //    Console.WriteLine(siradakiOgrenci.Ad + ", " + siradakiOgrenci.Sinif);
            //}









            ////sayılar dizisindeki her bir sayının karesini al ve ekrana yazdır.
            //int[] sayilar = { 32, 46, 16 };
            //foreach (var siradakiSayi in sayilar)
            //{
            //    Console.WriteLine(siradakiSayi * siradakiSayi);
            //}



        }
        class Ogrenci
        {
            //classta üretilecek nesneye property hazırlandı. Class'ın property'leri yaratılmadı.






            private int ogrenciNo; //veri aslında burada kapsüllenmiş. field. gerçekte bilgiyi tutan.

            public int OgrenciNo //main methodunda bu çağırılıyor. property. zahiri.
            {
                get { return ogrenciNo; }
                set { ogrenciNo = value; }
            }
            //classların içindeki veriler kıymetlidir. dışarıya kapatmayı isteriz. korumak için kapsülleme kullanılır. amaç veriyi korumak! kapsülleme = araya katman koymak.
            //kapsülleme kavramı örneği: kapıda yönlendirmek için duran insan.






            private string ad;

            public string Ad
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }







            public string Sinif { get; set; } //bu yazım şeklinde property var field yok. ancak csharp programı run ettiği anda field'ları gizli olarak oluşturuyor.

        }
    }
}