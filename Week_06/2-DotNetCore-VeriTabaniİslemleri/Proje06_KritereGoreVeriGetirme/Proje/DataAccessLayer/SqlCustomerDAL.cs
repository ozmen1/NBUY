using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.DataAccessLayer.Entities;
using System.Data.SqlClient;

namespace Proje.DataAccessLayer
{
    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD; Database=Northwind; User=sa; Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>(); //Customer nesnesi tipinde list oluşturuyor.
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerID, CompanyName, City, Country FROM Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        customers.Add(new Customer() //Customer nesnesi oluşturuyor.
                        {
                            Id = sqlDataReader["CustomerID"].ToString(), //önce objeyi unboxing ile string yap.
                            CompanyName = sqlDataReader["CompanyName"].ToString(),
                            City = sqlDataReader["City"].ToString(),
                            Country = sqlDataReader["Country"].ToString()
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