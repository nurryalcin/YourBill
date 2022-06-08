using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdisyonManager : IAdisyonService
    {
         private static IAdisyonDal _adisyonDal;
       



        public AdisyonManager(IAdisyonDal adisyonDal)
        {
          
           
            _adisyonDal = adisyonDal;

           

        }
        //[ValidationAspect(typeof(AdisyonValidator))]
        public IResult Add(Adisyon adisyon)
        {

            _adisyonDal.Add(adisyon);


            return new SuccessResult(Messages.AdisyonAdded);

        }

        public IDataResult<List<Adisyon>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Adisyon>>(Messages.MaintenanceTime);
            }
            var data = _adisyonDal.GetAll().Where(x => x.CompanyId== 1);

            return new SuccessDataResult<List<Adisyon>>(_adisyonDal.GetAll(), true, Messages.ProductsListed);
        }

        public IDataResult<List<Adisyon>> GetByName(string ImagePath)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Adisyon> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Add(int id, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

        
