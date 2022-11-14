using Proje02_DatabaseFirst_1.efcore;

NorthwindContext context = new NorthwindContext();

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




//Nancy adındaki Employee'nin yaptığı satışlar, toplam satışlar, brazilyaya yaptığı
var ordersOfNancy = context
    .Orders
    .Where(o => o.Employee.FirstName == "Nancy" && o.ShipCountry == "Brazil")
    .ToList();
foreach (var o in ordersOfNancy)
{
    Console.WriteLine(o.OrderId);
}
//toplam yaptığı satış
Console.WriteLine(ordersOfNancy.Count());



class CustomerModel //sayfanın sonuna konulur
{
    public string CompanyName { get; set;}
    public string ContactName { get; set;}
    public string City { get; set;}

}