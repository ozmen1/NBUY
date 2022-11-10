using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void CreateCustomer(Customer customer);//C-reate
        List<Customer> GetAllCustomers();     //R-ead
        Customer GetByIdCustomer(int id);     //R-ead
        void UpdateCustomer(Customer customer);//U-pdate
        void DeleteCustomer(int id);         //D-elete
        List<Customer> GetCustomersByCategory(string categoryName);
    }
}