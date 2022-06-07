using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;

        }

       // [ValidationAspect(typeof(CompanyValidator))]
        public IResult Add(Company company)
        {
            //business codes

            _companyDal.Add(company);
            return new SuccessResult(Messages.CompanyAdded);

        }

        public IDataResult<List<Company>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Company>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), true, Messages.CompanyListed);
        }
        //public IResult Update(Company company)
        //{
         //   throw new NotImplementedException();
       // }
    }
    
}
