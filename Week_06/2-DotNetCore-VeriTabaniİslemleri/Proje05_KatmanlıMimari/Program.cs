using System.Data.SqlClient;
using Proje05_KatmanlıMimari.BusinessLayer;
using Proje05_KatmanlıMimari.DataAccessLayer;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanlıMimari;
class Program
{
    static void Main(string[] args)
    {
        int select;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Choose Database->");
            System.Console.WriteLine("1-MsSql");
            System.Console.WriteLine("2-Sqlite");
            System.Console.WriteLine("Çıkmak için 0'a basınız.");
            System.Console.WriteLine("Lütfen seçiminizi giriniz: ");
            select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Menu(select);
                Console.ReadLine();
            }
            else if (select == 2)
            {
                Menu(select);
                Console.ReadLine();
            }
            else if (select != 0)
            {
                System.Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }
        } while (select != 0);
    }
    static void Menu(int dbType){
        Console.Clear();
        string dbName = dbType == 1? "MsSql" : "Sqlite";
        System.Console.WriteLine($"By {dbName} Database - Northwind");
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("1-Product List");
        System.Console.WriteLine("2-Customer List");
        System.Console.Write("Seçiminizi yapınız: ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
        {
            if (dbType == 1)
            {
                ProductList(new SqlProductDAL());
            }
            else
            {
                ProductList(new SqliteProductDAL());
            }
        }
        else if(select == 2){
            if (dbType == 1)
            {
                CustomerList(new SqlCustomerDAL());
            }
            else
            {
                CustomerList(new SqliteCustomerDAL());
            }
        }
    }
    static void ProductList(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        List<Product> products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
    static void CustomerList(ICustomerDAL customerDAL)
    {
        var customerManager = new CustomerManager(customerDAL);
        List<Customer> customers = customerManager.GetAllCustomers();
        foreach (var customer in customers)
        {
            System.Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.CompanyName}, Contact Name: {customer.ContactName}, City: {customer.City}, Country: {customer.Country}");
        }
    }
}
