using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAdisyonDal :IEntityRepository<Adisyon>, IAdisyonDal
    {
        List<Adisyon> _adisyons;

        public InMemoryAdisyonDal()
        {
           

        }

    public void Add(Adisyon adisyon)
        {
            _adisyons.Add(adisyon);
        }

        public void Delete(Adisyon adisyon)
        {
            Adisyon adisyonToDelete = _adisyons.SingleOrDefault(p => p.AdisyonId == adisyon.AdisyonId);
            _adisyons.Remove(adisyonToDelete);
        }

        public Adisyon Get(Expression<Func<Adisyon, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Adisyon Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Adisyon> GetAll(Expression<Func<Adisyon, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        

        public void Update(Adisyon adisyon)
        {
            Adisyon adisyonToUpdate = _adisyons.SingleOrDefault(p => p.AdisyonId ==adisyon.AdisyonId );
            adisyonToUpdate.Date = adisyon.Date;

        }
       
    }
}
