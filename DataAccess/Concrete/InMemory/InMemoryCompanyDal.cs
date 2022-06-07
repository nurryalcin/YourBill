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
    public class InMemoryCompanyDal : ICompanyDal
    {
        List<Company> _companies;


        public void Add(Company company)
        {
            _companies.Add(company);
        }

        public void Delete(Company company)
        {
            Company companyToDelete = _companies.SingleOrDefault(p => p.CompanyId == company.CompanyId);
            _companies.Remove(companyToDelete);
        }

        public Company Get(Expression<Func<Company, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            Company companyToUpdate = _companies.SingleOrDefault(p => p.CompanyId == company.CompanyId);
            companyToUpdate.CompanyName = company.CompanyName;
        }
    }
}
