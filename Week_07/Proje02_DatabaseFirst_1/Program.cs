using Proje02_DatabaseFirst_1;
using Proje02_DatabaseFirst_1.efcore;

var mt = new MultiTable();
// mt.MusteriSayisi();
// mt.SatisYapilanMusteriler();
// mt.SatisYapilmayanMusteriler();
mt.MusteriSatisListesi();



// NorthwindContext context = new NorthwindContext();





//Customer listesini alıyor
// List<Customer> customers = context.Customers.ToList();

// foreach(var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }




// //London'da yaşayan Customerların listesi
// List<Customer> customers = context.Customers.Where(c => c.City=="London").ToList();
// foreach(var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City:{customer.City} - Phone:{customer.Phone}");
// }

// Console.WriteLine("Bitti...");





// //London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim.
// var customers = context
//     .Customers
//     .Select(c => new {c.CompanyName, c.ContactName, c.City})
//     .Where(c => c.City=="London")
//     .ToList();
// foreach(var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City:{customer.City} - Contact Name:{customer.ContactName}");
// }

// Console.WriteLine("Bitti...");






// //London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim.
// //Nesne kullanarak
// List<CustomerModel> customers = context
//     .Customers
//     .Select(c => new CustomerModel() {
//         CompanyName = c.CompanyName,
//         ContactName = c.ContactName,
//         City = c.City
//     })
//     .Where(c => c.City=="London")
//     .ToList();
// foreach(var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City:{customer.City} - Contact Name:{customer.ContactName}");
// }

// Console.WriteLine("Bitti...");




// //Beverages kategorisindeki ürünlerin listesini getir.
// var beveragesProducts = context
//     .Products
//     .Where(p => p.Category.CategoryName == "Beverages")
//     .ToList();
// foreach (var p in beveragesProducts)
// {
//     Console.WriteLine(p.ProductName);
// }





// //Suppliers tablosundaki Germany'de yaşayanları listeleyin.
// var suppliers = context
//     .Suppliers
//     .Where(s => s.Country == "Germany")
//     .ToList();
// foreach (var s in suppliers)
// {
//     Console.WriteLine(s.ContactName);
// }




// //Nancy adındaki Employee'nin yaptığı satışlar, toplam satışlar, brazilyaya yaptığı
// var ordersOfNancy = context
//     .Orders
//     .Where(o => o.Employee.FirstName == "Nancy" && o.ShipCountry == "Brazil")
//     .ToList();
// foreach (var o in ordersOfNancy)
// {
//     Console.WriteLine(o.OrderId);
// }
// //toplam yaptığı satış
// Console.WriteLine(ordersOfNancy.Count());







//Product'ları ID'ye göre büyükten küçüğe sıralı bir şekilde listeleyelim.
// var products = context
//     .Products
//     .OrderByDescending(p => p.ProductId)
//     .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }




//En son satılan 5 ürünü listeleyelim
// var products = context
//     .Products
//     .OrderByDescending(p => p.ProductId)
//     .Take(5)
//     .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// }





//Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, fiyata göre küçükten büyüğe sıralayalım.
//kullanmayacağımız kolonları almadık
// var products = context
//     .Products
//     .OrderBy(p => p.UnitPrice)
//     .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 20)
//     .Select(p => new {
//         p.ProductName,
//         p.UnitPrice
//     })
//     .ToList();

// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName} ---> {p.UnitPrice}");
// }




// //Beverages kategorisindeki ürünlerin ortalama fiyatını ekrana yazdıralım.
// var ortalama = context
//     .Products
//     .Where(p => p.Category.CategoryName == "Beverages")
//     .Average(p => p.UnitPrice);

// System.Console.WriteLine($"Beverages Fiyat Ortalaması: {ortalama}");

// //Beverages kategorisindeki ürün adedi
// var adet = context 
//     .Products
//     // .Where(p => p.Category.CategoryName == "Beverages")
//     // .Count();
//     .Count(p => p.Category.CategoryName == "Beverages");
// System.Console.WriteLine($"Beverages Ürün Adedi: {adet}");





// //Beverages ve Condiments kategorilerinde toplam kaç adet ürün vardır
// var adet = context
//     .Products
//     .Where(p => p.Category.CategoryName =="Beverages" || p.Category.CategoryName =="Condiments")
//     .Count();
// System.Console.WriteLine($"B ve C adet: {adet}");







// //Adının içinde tofu geçen ürünleri listeleyin
// var products = context
//     .Products
//     .Where(p=>p.ProductName.Contains("tofu"))
//     .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName}");
// }





// //En ucuz ve en pahalı ürünler hangileridir?
// var minPrice = context.Products.Min(p => p.UnitPrice);
// var maxPrice = context.Products.Max(p => p.UnitPrice);


// var minProduct = context
//     .Products
//     .Where(p => p.UnitPrice == minPrice)
//     .Select(p => new {
//         p.ProductName,
//         p.UnitPrice
//     }).FirstOrDefault(); //karşılaştığının ilkini döndürür.

// var maxProduct = context
//     .Products
//     .Where(alex => alex.UnitPrice == maxPrice)
//     .Select(hooijdonk => new {
//         hooijdonk.ProductName,
//         hooijdonk.UnitPrice
//     }).FirstOrDefault();

// System.Console.WriteLine($"MinPrice: {minPrice} -- Product: {minProduct.ProductName} - {minProduct.UnitPrice}");
// System.Console.WriteLine($"MaxPrice: {maxPrice} -- Product: {maxProduct.ProductName} - {maxProduct.UnitPrice}");





// //Products tablosundan en düşük ve en yüksek fiyatlarını listeleyelim
// var minPrice = context.Products.Min(p => p.UnitPrice);
// var minProducts = context
//     .Products
//     .Where(p => p.UnitPrice == minPrice)
//     .Select(p => new
//     {
//         p.ProductName
//     })
//     .ToList();
// System.Console.WriteLine($"En ucuz {minPrice}TL ürünlerin listesi:");
// foreach (var p in minProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }

// var maxPrice = context.Products.Max(p => p.UnitPrice);
// var maxProducts = context
//     .Products
//     .Where(p => p.UnitPrice == maxPrice)
//     .Select(p => new
//     {
//         p.ProductName
//     })
//     .ToList();
// System.Console.WriteLine($"En pahalı {maxPrice}TL ürünlerin listesi:");

// foreach (var p in maxProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }



// class CustomerModel //sayfanın sonuna konulur
// {
//     public string CompanyName { get; set; }
//     public string ContactName { get; set; }
//     public string City { get; set; }

// }