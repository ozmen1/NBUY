using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class,
        IEntity,
        new()
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(()=> { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }
        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>(); //ortak sorgu query'e eklendi. *burada context'imize erişip hangi entity ile çalışacaksak o entity'i alıyoruz ve o entity'i Iqueryable tipinde alıyoruz. Ki sonra bunun arkasına, Where, Include gibi yapıları duruma göre ekleyebilelim.
            if (predicate != null) //predicate null mü kontrol edildi. *bu metoda gelen birinci parametre yani predicate eğer null değilse bu bir koşul belirtilmiş demektir. o koşulu (predicate) if içinde where ile ekledim. eğer predicate null ise query üzerine where ile ilgili bir şey eklememize gerek yok.
            {
                query = query.Where(predicate); //predicate eğer null değilse sonuna sorgu eklendi.
            }
            if (includeProperties.Any()) //eğer include properties true ise
                                         //*eğer 2. paramatremiz olan includeproperties dizisinde eleman varsa bu dizi içerisinde dönerek her elemanı kquery'e ekliyoruz. ki her eleman bir include taşıyor.
            {
                foreach (var includeProperty in includeProperties) //includeproperties listesinin içerisinde gez
                {
                    query = query.Include(includeProperty); //her include property'i sorguya ekle
                }
            }
            return await query.ToListAsync(); //listeye return et. artık tolistasync yapılabilecek query elimizde, biz de geriye döndüreceğimiz bir query'yi tolistasync ile listeye çeviriyoruz çünkü bu metot geriye bir liste döndürmesi gerekiyor.
        }
        //Article article = repositoryArticle.GetAllAsync(x => x.Category == 12, y => y.User, y => y.Comments);
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);
            
            if (includeProperties.Any())
            {

                foreach (var includeProperty in includeProperties) {
                    query = query.Include(includeProperty);
                }
                
            }
            return await query.FirstOrDefaultAsync(); ////bu da olur. ilkini döndürür.
            //return await query.SingleOrDefaultAsync(); ////benzersiz ve tek bir şeyi döndürmek için.
        }


    }
}
