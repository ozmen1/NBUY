namespace Project09_Interface
{
    //eğer her şeyin abstract olması gerekiyorsa, interface kullanalım!
    //BURAYA DERSTEKİ AÇIKLAMALAR GELECEK!
    interface IPersonel
    {
        public string Departman { get; set; }
        public string Maas { get; set; }
    }
    interface IKisi //interface'e isim verirken başına I harfi koy!
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public void Bilgi(); //Interface'ler içindeki metotlarda sadece imza bulunur, metodun gövdesi olmaz!
                             //Metodun gövdesi bu interface'i miras alan CLASS içinde doldurulur.
                            //interface new yapılamaz!
    }

    class Yonetici : IPersonel, IKisi //önce class sonra interface yazılır. Dikkat et 2 tane class yazılmaz ama istenildiği kadar interface yazılabilir!
    {
        /// <summary>
        /// Bu method, herhangi bir yönetici bilgisi girmeden yönetici oluşturur.
        /// </summary>
        public Yonetici()
        {
            //kimi zaman ad, soyad, adres, maaş ve departman bilgisini vermeden de yönetici oluşturmak istediğimiz zaman bu constructor çalışır.
        }
        /// <summary>
        /// Bu metod, Ad Soyad, Adres, Maaş ve Departman bilgileri girilerek yönetici oluşturur.
        /// </summary>
        /// <param name="adSoyad">Buraya ad soyad bilgisi girin.</param>
        /// <param name="adres">Buraya adres bilgisi girin.</param>
        /// <param name="maas">Buraya maaşı girin, ama yanlışlukla string tanımlamışım, affedin.</param>
        /// <param name="departman">Buraya departmanı girin.</param>
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"Ad soyad: {AdSoyad} Departman: {Departman}");        
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ///*bir abstract classtan, miras alan classta
            // * eğer base class'ta abstract methodlar varsa, mutlaka override edilmeli
            // * eğer base class'ta abstract olmayan methodlar varsa, onlar aynen kullanılabilir.
            // * ancak bazen, miras alınan classtaki her metodun, içinin dolu hallerini yazmak zorunlu olsun isteriz.
            // * yani bir nevi hepsi abstract olsun isteriz. bunu yapmak yerine, miras alınan class'ı class değil
            // * interface şeklinde tanımlarız!
            // * */

            ////IPersonel personel = new IPersonel(); //hatalı kullanım!

            //Yonetici yonetici1 = new Yonetici();
            //Yonetici yonetici2 = new Yonetici("Alex de Souza", "Rio de Jenario", "5000", "Futbol");
            //Yonetici yonetici3 = new Yonetici("Mustafa", "Ankara", "10000", "IT");







            //Product product1 = new Product()
            //{
            //    Id = 1,
            //    Name = "iPhone 13",
            //    Price = 5900,
            //    Properties = "8 GB Ram",
            //    Ratio = 0.5m,
            //    CreatedDate = DateTime.Now
            //};
            //Console.WriteLine($"Product Name: {product1.Name}(Büyük harf: {product1.NameToUpper(product1.Name)}) Properties: {product1.Properties}");

            //Category category1 = new Category()
            //{
            //    Id = 1,
            //    Name = "Telefon",
            //    CreatedDate = DateTime.Now,
            //    Description = "Telefon kategorisi için."
            //};
            //Console.WriteLine($"Category Name: {category1.Name}(Büyük harf: {category1.NameToUpper(category1.Name)}) Description: {category1.Description}");





            Console.ReadLine();
        }
    }
}