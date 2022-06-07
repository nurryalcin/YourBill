using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBillImageDal : EfEntityRepositoryBase<BillImage, NortWindContext>, IBillImageDal
    {
        public bool IsExist(int id)
        {
            using (NortWindContext context = new NortWindContext())
            {
                return context.BillImages.Any(pre => pre.BillImageId == id);
            }
        }
    }
}
