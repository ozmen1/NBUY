using Microsoft.EntityFrameworkCore;
using OnlineTutor.Data.Abstract;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(DbContext context) : base(context)
        {
        }

        public Category GetByIdWithShowCards()
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoryWithShowCardsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryWithSubjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoryWithSubjectsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
