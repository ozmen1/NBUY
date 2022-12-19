using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context) : base(context) //base'e gönderdik.
        {
            //buraya gelen context base class'a gönderiliyor ve aynı zamanda sadece bu constructor içinde geçerli. Ama bu class'ın bütününde henüz kullanılamıyor.Eğer kullanılsın istersek yapmamız gereken işlemler var.
        }

        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
