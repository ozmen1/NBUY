namespace Project12_OOP_Work_01
{
    public class Bolum
    {
        public int Id { get; set; }
        public string BolumAdi { get; set; }
        public string Aciklama { get; set; }
    }

    public class Ogrenci : Bolum
    {
        public int Id { get; set; }
        public int OgrNo { get; set; }
        public int Yas { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    public class Program
    {
        public static void VeriGirisi()
        {
            Console.ReadLine();
            return;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Bolum> bolum = new List<Bolum>();
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = Console.ReadLine();



            Console.ReadLine();
        }
    }
}