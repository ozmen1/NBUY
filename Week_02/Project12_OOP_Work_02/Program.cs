namespace Project12_OOP_Work_02
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

    }
    class Ogrenci : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    internal class Program
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                Bolum bolum = new Bolum();
                bolum.Id = int.Parse(GirisYap($"{i + 1}.Bölüm Id:"));
                bolum.Ad = GirisYap($"{i + 1}.Bölüm Adı:");
                bolum.Aciklama = GirisYap($"{i + 1}.Bölüm Açıklaması:");
                List<Ogrenci> ogrenciler = new List<Ogrenci>();
                Console.WriteLine($"{bolum.Ad} Bölümü Öğrencileri");
                Console.WriteLine("***********************");
                for (int j = 0; i < 3; i++)
                {
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Id = int.Parse(GirisYap($"{j + 1}.Öğrenci Id: "));
                    ogrenci.OgrNo = int.Parse(GirisYap($"{j + 1}.Öğrenci No: "));
                    ogrenci.Ad = GirisYap($"{j + 1}.Öğrenci Ad: ");
                    ogrenci.Soyad = GirisYap($"{j + 1}.Öğrenci Soyad: ");
                    ogrenci.Yas = int.Parse(GirisYap($"{j + 1}.Öğrenci Yaş: "));
                    ogrenciler.Add(ogrenci);
                }
                bolum.Ogrenciler = ogrenciler;
                bolumler.Add(bolum);
            }
            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"Bölüm Id: {bolum.Id} - Bölüm Ad: {bolum.Ad} - Bölüm Açıklamsı: {bolum.Aciklama}");
                foreach (var ogrenci in bolum.Ogrenciler)
                {
                    Console.WriteLine($"Öğrenci Id: {ogrenci.Id} - Öğrenci No: {ogrenci.OgrNo }- Öğrenci Ad - Soyad {ogrenci.Ad} {ogrenci.Soyad} - Öğrenci Yaş {ogrenci.Yas}");
                }
            }

            Console.ReadLine();
        }
    }
}

//Console.Write($"{i + 1}.Bölüm Id: ");
//bolum.Id = int.Parse(Console.ReadLine());
//Console.Write($"{i + 1}.Bölümün Adı: ");
//bolum.Ad = Console.ReadLine();
//Console.Write($"{i + 1}.Bölümün Açıklaması: ");
//bolum.Aciklama = Console.ReadLine();