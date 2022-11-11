using System.Data.SqlClient;
using Proje.BusinessLayer;
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje;
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
    static void Menu(int dbType)
    {
        Console.Clear();
        string dbName = dbType == 1 ? "MsSql" : "Sqlite";
        System.Console.WriteLine($"By {dbName} Database - Northwind");
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("1-Product List");
        System.Console.WriteLine("2-Customer List");
        if (dbType == 1)
        {
            System.Console.WriteLine("3-Search Product by Id");
            System.Console.WriteLine("4-Filter Product by Category Id");
            System.Console.WriteLine("5-Filter Product by Category Name");
        }
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
        else if (select == 2)
        {
            if (dbType == 1)
            {
                CustomerList(new SqlCustomerDAL());
            }
            else
            {
                CustomerList(new SqliteCustomerDAL());
            }
        }
        else if (select == 3)
        {
            if (dbType == 1)
            {
                ProductSearch(new SqlProductDAL());
            }
            else
            {

            }
        }
        else if (select == 4)
        {
            if (dbType == 1)
            {
                ProductsFilterByCategoryId(new SqlProductDAL());
            }
            else
            {

            }
        }
        else if (select == 5)
        {
            if (dbType == 1)
            {
                ProductsFilterByCategory(new SqlProductDAL());
            }
            else
            {

            }
        }
    }

    static void ProductsFilterByCategoryId(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        System.Console.WriteLine("Enter Category Id: ");
        int catId = int.Parse(Console.ReadLine());
        List<Product> products = productManager.GetProductsByCategoryId(catId);
        if (products.Count > 0)
        {
            foreach (var product in products)
            {
                System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
        else
        {
            System.Console.WriteLine("Aradığınız kategoride ürün yoktur!");
        }

    }

    static void ProductsFilterByCategory(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        System.Console.WriteLine("Enter Category Name: ");
        string categoryName = Console.ReadLine();
        List<Product> products = productManager.GetProductsByCategory(categoryName);
        if (products.Count > 0)
        {
            foreach (var product in products)
            {
                System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }
        else
        {
            System.Console.WriteLine("Aradığınız kategoride ürün yoktur!");
        }

    }
    static void ProductSearch(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        Console.Write("Enter id: ");
        int id = int.Parse(Console.ReadLine());
        Product product = productManager.GetByIdProduct(id);
        if (product != null)
        {
            System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
        else
        {
            System.Console.WriteLine("No product!");
        }
        Console.ReadLine();
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
