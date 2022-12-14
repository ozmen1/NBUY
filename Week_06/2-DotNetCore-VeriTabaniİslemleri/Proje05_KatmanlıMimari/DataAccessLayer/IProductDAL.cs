using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);//C-reate
        List<Product> GetAllProducts();     //R-ead
        Product GetByIdProduct(int id);     //R-ead
        void UpdateProduct(Product product);//U-pdate
        void DeleteProduct(int id);         //D-elete
        List<Product> GetProductsByCategory(string categoryName);
    }
}