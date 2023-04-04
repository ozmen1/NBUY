using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        //<T> içine tip yazabilmek için T yazıldı
        //tüm entitylerde geçerli olacak metotlar burada oluşacak

        Task<T> GetByIdAsync(int id); //Id'ye göre entity getirecek.
        Task<List<T>> GetAllAsync(); // ilgili tüm kayıtları getirecek. tüm kategorilerin vs getirilmesi için
        Task CreateAsync(T entity); //yeni kayıt yaratacak (T olarak ne yollandıysa product, category vs farketmez)
        void Update(T entity); //kayıt güncelleyecek (T olarak ne yollandıysa product, category vs farketmez)
        void Delete(T entity); //kayıt silecek (T olarak ne yollandıysa product, category vs farketmez)

    }
}
