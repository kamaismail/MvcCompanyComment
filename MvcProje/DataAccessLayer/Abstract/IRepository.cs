using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List(); // T entity değerine göre listeleme yap.

        int Insert(T p); // Ekleme işlemine göre genellikle int kullanır çünkü c#'tan executenonquery'yi hatırladığımızda geriye sayısal bir ifade döndürüyor , T'den türetilmiş olan parametreleri ekle.

        int Update(T p);

        int Delete(T p);

        T GetByID(int id); // Bana id'getir int id dışarıdan gönderilen parametredir.

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T, bool>> where);
    }
}
