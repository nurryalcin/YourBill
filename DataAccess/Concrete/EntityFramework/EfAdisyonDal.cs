using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdisyonDal : EfEntityRepositoryBase<Adisyon, NortWindContext>, IAdisyonDal
    {

        public List<AdisyonDetailDto> GetAdisyonDetails()
        {
            using (NortWindContext context = new NortWindContext())
            {
                var items = (from a in context.Adisyons
                             join c in context.Companies on a.CompanyId equals c.CompanyId
                             join d in context.Cities on c.CompanyCityId equals d.CityId
                             join f in context.Districties on d.CityId equals f.CityId
                             select new AdisyonDetailDto
                             {

                                 a.AdisyonId,
                                 c.CompanyName,
                                 d.CityName,
                                 f.DistrictName
                             }).Tolist();

                return items;
            }
            
        }
    }
}
