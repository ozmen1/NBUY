using System.Data.SqlClient;

namespace Proje02_Verilerin_Çekilmesi;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GetSqlConnection();
    }

    static void GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Password=123";
        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                System.Console.WriteLine("Bağlantı sağlandı.");
                string queryString = "SELECT * FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //sqlDataReader.Read(); //sadece 1. satırı döndürür. o yüzden döngüye sokmak gerek.
                int sayac = 1;
                while (sqlDataReader.Read())
                {
                    System.Console.WriteLine($"Sıra: {sayac} - Name: {sqlDataReader[1]} - Price: {sqlDataReader[5]}");
                    sayac++;
                }
                sqlDataReader.Close();

            }
            catch (Exception e)
            {
                
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
