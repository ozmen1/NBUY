using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    public interface ICategoryService
    {
        //bütün generic ve kategoriye özgü metotlar buraya yazıldı. categoriye özgü: Icategoryreposiyory, generic olan: efcoregeneric
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetByIdWithProducts();
    }
}
