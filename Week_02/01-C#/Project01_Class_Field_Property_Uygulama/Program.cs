namespace Project01_Class_Field_Property_Uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BirinciYontem
            ////bir product class'ımız olacak içinde name, price, description alanları olacak.
            ////istenildiği kadar Product bilgisinin girilmesini sağlayacağız.
            ////Kaç adet Product bilgisini gireceğini kullanıcı belirlesin.
            ////Product ekleme işi bitince, eklenmiş product'lar listelensin.

            //Console.Write("Kaç adet ürün gireceksiniz? ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];  //x adetlik dizi tanımladık. 
            ////döngüde tanımlanan bilgileri diziye atacağız.
            //Product product;
            //for (int i = 0; i < adet; i++)
            //{
            //    //Product nesnesi yarattık.
            //    product = new Product();
            //    //Product product = new Product(); //heapte yaratılan nesne. (işaretçi). her döngü döndüğünde tekrar yaratılmasına gerek yok. Onun yerine "Product product;" döngünün üstünde oluşturduk.
            //    //Product nesnesinin içine atadık.
            //    Console.Write("Product Name: ");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price: ");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.Write("Description: ");
            //    product.Description = Console.ReadLine();
            //    //products dizisinin içine kaydettik.
            //    products[i] = product;
            //}
            //Console.WriteLine($"Product Name\tPrice\tDescription");
            //foreach (var prdct in products)
            //{
            //    Console.WriteLine($"{prdct.Name}\t{prdct.Price}\t{prdct.Description}");
            //}
            #endregion












            #region RastgeleDegerUreterek
            //Product[] products = new Product[5];
            //Product product;
            //string[] nameArray = { "Galaxy A50", "HP Notebook", "Macbook Air M2", "iPhone 12 Plus", "LG 24 Inch Monitör" };
            //string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırttır" };
            //Random random = new Random(); //price'da kullanacağız.
            //for (int i = 0; i < 5; i++)
            //{
            //    product = new Product();
            //    product.Name = nameArray[random.Next(0, 5)];
            //    product.Description = descArray[random.Next(0, 5)];
            //    product.Price = random.Next(100, 1001);

            //    products[i] = product;
            //}
            //Console.WriteLine($"Product Name\tPrice\tDescription");
            //foreach (var prdct in products)
            //{
            //    Console.WriteLine($"{prdct.Name}\t{prdct.Price}\t{prdct.Description}");
            //}
            #endregion








            #region RastgeleDegerUreterekAciklamalarDuzenlendiZamOraniEklendi
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Galaxy A50", "HP Notebook", "Macbook Air M2", "iPhone 12 Plus", "LG 24 Inch Monitör" };
            string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırttır" };
            Random random = new Random(); //price'da kullanacağız.
            decimal[] oldPrices = new decimal[5];
            Console.Write("Ne kadar zam yapılsın? ");
            decimal oran = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                product = new Product();
                product.Name = nameArray[random.Next(0, 5)];
                product.Description = descArray[random.Next(0, 5)];
                product.Price = random.Next(100, 1001);

                oldPrices[i] = product.Price;
                product.Price = product.Price * (1 + oran / 100);

                products[i] = product;
            }
            Console.WriteLine("Product Name".PadRight(30) + "Old Price".PadRight(10) + "Price".PadRight(10) + "Description");
            int j = 0;
            foreach (var prdct in products)
            {
                Console.WriteLine($"{prdct.Name.PadRight(30)}{oldPrices[j].ToString().PadRight(10)}{prdct.Price.ToString().PadRight(10)}{prdct.Description}");
                j++;
            }
            #endregion
        }
    }
}