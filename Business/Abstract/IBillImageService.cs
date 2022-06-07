using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillImageService
    {
        public IResult Add(int id, IFormFile file);
        public IResult Delete(int id);
       
        public IDataResult<BillImage> GetById(int id);
        public IDataResult<List<BillImage>> GetAll();


    }
}
