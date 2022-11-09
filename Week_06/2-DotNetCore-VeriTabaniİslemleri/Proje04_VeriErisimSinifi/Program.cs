using System.Data.SqlClient;

namespace Proje04_VeriErisimSinifi;
class Program
{
    static void Main(string[] args)
    {
        string select;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Product mı Müşteri mi? (1/2)");
            System.Console.WriteLine("Çıkmak için 0'a basınız.");
            select = Console.ReadLine();
            if (select == "1")
            {
                ProductList();
            }
            else if (select == "2")
            {
                CustomerList();
            }
            else if (select != "0")
            {
                System.Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }
            Console.ReadLine();
        } while (select != "0");
    }
    static void ProductList()
    {
        List<Product> products = GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
    static void CustomerList()
    {
        List<Customer> customers = GetAllCustomers();
        foreach (var customer in customers)
        {
            System.Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.CompanyName}, Contact Name: {customer.ContactName}");
        }
    }
    static List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>(); //Product nesnesi tipinde list oluşturuyor.
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    products.Add(new Product() //Product nesnesi oluşturuyor.
                    {
                        Id = int.Parse(sqlDataReader[0].ToString()), //önce objeyi unboxing ile string yap.
                        Name = sqlDataReader[1].ToString(),
                        Price = decimal.Parse(sqlDataReader[2].ToString()),
                        Stock = int.Parse(sqlDataReader[3].ToString())
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Bir sorun oluştu");
            }
            finally
            {
                connection.Close();
            }
        }
        return products;
    }


    static List<Customer> GetAllCustomers()
    {
        List<Customer> customers = new List<Customer>();
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT CustomerID, CompanyName, ContactName FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    customers.Add(new Customer()
                    {
                        Id = sqlDataReader["CustomerID"].ToString(), //önce objeyi unboxing ile string yap.
                        CompanyName = sqlDataReader["CompanyName"].ToString(),
                        ContactName = sqlDataReader["ContactName"].ToString()
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Bir sorun oluştu");
            }
            finally
            {
                connection.Close();
            }
        }
        return customers;
    }


    static SqlConnection GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
    }
}
