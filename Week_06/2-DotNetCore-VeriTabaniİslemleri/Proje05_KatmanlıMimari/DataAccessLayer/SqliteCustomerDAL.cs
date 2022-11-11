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
            string connectionString = "Data Source = northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerID, CompanyName, ContactName FROM Customers";
                    SqliteCommand sqliteCommand = new SqliteCommand(queryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        customers.Add(new Customer(){
                            Id=sqliteDataReader["CustomerID"].ToString(),
                            CompanyName=sqliteDataReader["CompanyName"].ToString(),
                            ContactName=sqliteDataReader["ContactName"].ToString()
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
            return customers;
        }

        public Customer GetByIdCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}