using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje05_KatmanlıMimari.DataAccessLayer;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanlıMimari.BusinessLayer
{
    public class ProductManager
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL; //dependency injection
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
            return _productDAL.GetAllProducts();
        }

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

    }
}