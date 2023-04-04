using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Proje04_VeriErisimSinifi
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);//C-reate
        List<Product> GetAllProducts();     //R-ead
        Product GetByIdProduct(int id);     //R-ead
        void UpdateProduct(Product product);//U-pdate
        void DeleteProduct(int id);         //D-elete
        List<Product> GetProductsByCategories(string categoryName);
    }

    public class SqlProductDAL : IProductDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
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

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategories(string categoryName)
        {
            throw new NotImplementedException();
        }
    }

    public class SqliteProductDAL : IProductDAL
    {
        private SqliteConnection GetSqliteConnection(){
            string connectionString = "Data Source = northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        products.Add(new Product(){
                            Id=int.Parse(sqliteDataReader["ProductID"].ToString()),
                            Name=sqliteDataReader["ProductName"].ToString(),
                            Price=decimal.Parse(sqliteDataReader["UnitPrice"].ToString()),
                            Stock=int.Parse(sqliteDataReader["UnitsInStock"].ToString())
                        });
                    }
                    sqliteDataReader.Close();
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                    System.Console.WriteLine("Bir hata oluştu.");
                }
                finally
                {
                    connection.Close();
                }
            }
            return products;
        }

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategories(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}