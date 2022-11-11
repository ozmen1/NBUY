using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;
using System.Data.SqlClient;

namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
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
            List<Customer> customers = new List<Customer>(); //Product nesnesi tipinde list oluşturuyor.
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
                        customers.Add(new Customer() //Product nesnesi oluşturuyor.
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