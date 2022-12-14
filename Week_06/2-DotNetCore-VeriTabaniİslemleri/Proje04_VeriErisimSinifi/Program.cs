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
                Console.ReadLine();
            }
            else if (select == "2")
            {
                // CustomerList();
                // Console.ReadLine();
            }
            else if (select != "0")
            {
                System.Console.WriteLine("Lütfen geçerli bir değer giriniz.");
            }
        } while (select != "0");
    }
    static void ProductList()
    {
        // var sqlProductDAL = new SqlProductDAL();
        // List<Product> products = sqlProductDAL.GetAllProducts();
        var sqliteProductDAL = new SqliteProductDAL();
        List<Product> products = sqliteProductDAL.GetAllProducts();
        foreach (var product in products)
        {
            System.Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
    // static void CustomerList()
    // {
    //     List<Customer> customers = GetAllCustomers();
    //     foreach (var customer in customers)
    //     {
    //         System.Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.CompanyName}, Contact Name: {customer.ContactName}");
    //     }
    // }

    // static List<Customer> GetAllCustomers()
    // {
    //     List<Customer> customers = new List<Customer>();
    //     using (var connection = GetSqlConnection())
    //     {
    //         try
    //         {
    //             connection.Open();
    //             string queryString = "SELECT CustomerID, CompanyName, ContactName FROM Customers";
    //             SqlCommand sqlCommand = new SqlCommand(queryString, connection);
    //             SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //             while (sqlDataReader.Read())
    //             {
    //                 customers.Add(new Customer()
    //                 {
    //                     Id = sqlDataReader["CustomerID"].ToString(), //önce objeyi unboxing ile string yap.
    //                     CompanyName = sqlDataReader["CompanyName"].ToString(),
    //                     ContactName = sqlDataReader["ContactName"].ToString()
    //                 });
    //             }
    //             sqlDataReader.Close();
    //         }
    //         catch (Exception)
    //         {
    //             System.Console.WriteLine("Bir sorun oluştu");
    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return customers;
    // }



}
