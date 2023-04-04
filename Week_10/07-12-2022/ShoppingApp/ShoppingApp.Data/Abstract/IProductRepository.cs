using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        //Producta özgü memberlar burada olacak. (property, field, method...)
        //örneğin aşağıdakiler gibi:
        List<Product> GetProductsByCategory();
        Task<List<Product>> GetHomePageProductsAsync();
    }
}
