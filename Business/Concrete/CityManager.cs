using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager:ICityService
    {

        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        //[ValidationAspect(typeof(AdisyonValidator))]
        public IResult Add(City city)
        {

            _cityDal.Add(city);


            return new SuccessResult(Messages.AdisyonAdded);

        }
    }
}
