using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{

   
    //generic constraint-kısıtlar
    //class:referans tip olabilir demek
    //IEntity:IEntity olabilir ya da Ientity implemente eden bir nesne olabilir.
    //new:new'lenebilir olmalıdır.IEntity devre dışı bıraktı arayüz yenilenmez.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(int id);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>expression);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        

      
    }
}
