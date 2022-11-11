using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;
using Microsoft.Data.Sqlite;

namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public class SqliteCustomerDAL : ICustomerDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString = @"Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>(); //Customer nesnesi tipinde list oluşturuyor.
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerID, CompanyName, City, Country FROM Customers";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        customers.Add(new Customer() //Customer nesnesi oluşturuyor.
                        {
                            Id = sqliteDataReader["CustomerID"].ToString(), //önce objeyi unboxing ile string yap.
                            CompanyName = sqliteDataReader["CompanyName"].ToString(),
                            City = sqliteDataReader["City"].ToString(),
                            Country = sqliteDataReader["Country"].ToString()
                        });
                    }
                    sqliteDataReader.Close();
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

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}