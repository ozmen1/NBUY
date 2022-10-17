namespace Project11_Collections_GenericList
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            //List<int> sayilar = new List<int>();
            //sayilar.Add(12);
            //sayilar.Add(120);
            //sayilar.Add(69);
            //sayilar.Add(28);
            //sayilar.Add(316);

            //List<string> isimler = new List<string>();
            //isimler.Add("Ali");
            //isimler.Add("Begüm");
            //isimler.Add("Kemal");

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            //sayilar.Sort();
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region FirstSample
            //////ÖRNEK MANTIK: 
            //////int a = 45
            //////int b = a
            //////a'ya bir daha ihtiyaç kalmadı
            //////1. yöntem: nesne oluşturulduğu ve listeye atıldı (bir daha kullanılmamak üzere listeye atıldı=. belleğin heap kısmında boşuna yer kaplıyor.
            //////Product product1 = new Product() { Id = 1, Name = "Bilgisayar", Price = 28000 };
            //////Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 18000 };
            //////Product product3 = new Product() { Id = 3, Name = "Masa Sandalye Takımı", Price = 8000 };

            //////List<Product> products = new List<Product>();
            //////products.Add(product1);
            //////products.Add(product2);
            //////products.Add(product3);

            //////2. yöntem: sorun çözüldü.
            //////ÖRNEK MANTIK: int b = 45
            ////List<Product> products = new List<Product>()
            ////{
            ////    new Product() { Id = 1, Name = "Telefon", Price = 19000 },
            ////    new Product() { Id = 2, Name = "Bilgisayar", Price = 49000 },
            ////    new Product() { Id = 3, Name = "Mesa Sandalye", Price = 119000 }
            ////};
            //////foreach (var product in products)
            //////{
            //////    Console.WriteLine($"{product.Name} / {product.Price}");
            //////}








            //////Yeni bir liste yaratın adı da newProducts olsun. İçine tıpkı yukarıdaki gibi 3 yeni ürün bilgisi girin.

            ////List<Product> newProducts = new List<Product>()
            ////{
            ////    new Product() { Id = 4, Name = "Ayakkabı", Price = 10000 },
            ////    new Product() { Id = 5, Name = "Çanta", Price = 19000 },
            ////    new Product() { Id = 6, Name = "Buzdolabı", Price = 10900 }
            ////};


            //////newProducts içindeki product'ları products içine ekleyeceğiz.
            ////products.AddRange(newProducts);

            //////products.ForEach(product => { 
            //////    Console.WriteLine($"{product.Name} / {product.Price}");
            //////    Console.WriteLine();
            //////});

            ////int elemanSayisi = products.Count;


            ////products.Insert(0, new Product() { Id = 21, Name = "Gözlük", Price = 1200 }); //istediğimiz yere ekledik.

            ////products.InsertRange(3, newProducts);

            ////foreach (var product in products)
            ////{
            ////    Console.WriteLine($"{product.Name} / {product.Price}");
            ////}








            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id = 1, Name = "Telefon", Price = 19000 },
            //    new Product() { Id = 2, Name = "Bilgisayar", Price = 49000 },
            //    new Product() { Id = 3, Name = "Mesa Sandalye", Price = 119000 }
            //};
            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "First Category",
            //    Products = products
            //};
            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t{product.Name}");
            //}
            //Console.WriteLine(productModel.Id);
            #endregion

            //İçinde 3 adet ProductModel tipinde veri barındıran bir list oluşturun.
            //Her bir ProductModel içinde ise, Products özelliğine 3'er adet product koyun.

            List<ProductModel> productModels = new List<ProductModel>()
            {
                new ProductModel() { 
                    Id = 1, 
                    CategoryName = "Bilgisayarlar", 
                    Products = new List<Product>()
                    {
                        new Product() { Id = 1, Name =  "Ürün1", Price = 500 },
                        new Product() { Id = 2, Name =  "Ürün2", Price = 600 },
                        new Product() { Id = 3, Name =  "Ürün3", Price = 700 }
                    }
                },
                new ProductModel() {
                    Id = 2,
                    CategoryName = "Telefonlar",
                    Products = new List<Product>()
                    {
                        new Product() { Id = 11, Name =  "Ürün11", Price = 5100 },
                        new Product() { Id = 21, Name =  "Ürün21", Price = 6100 },
                        new Product() { Id = 31, Name =  "Ürün31", Price = 7100 }
                    }
                },
                new ProductModel() {
                    Id = 3,
                    CategoryName = "Mobilyalar",
                    Products = new List<Product>()
                    {
                        new Product() { Id = 12, Name =  "Ürün12", Price = 5020 },
                        new Product() { Id = 22, Name =  "Ürün22", Price = 6020 },
                        new Product() { Id = 32, Name =  "Ürün32", Price = 7020 }
                    }
                }
            };
            foreach (var productModel in productModels)
            {
                Console.WriteLine($"Product Model Id: {productModel.Id} - Category Name: {productModel.CategoryName}");
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"\tProduct Id: {product.Id} - Product Name: {product.Name} - Product Price {product.Price}");
                }
                Console.WriteLine("*********************");
            }


            Console.ReadLine();
        }
    }
}