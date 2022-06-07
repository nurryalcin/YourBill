using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdisyonService
    {
        IDataResult<List<Adisyon>> GetAll();
        IResult Add(Adisyon adisyon);
       
       
      
      
    }
}
