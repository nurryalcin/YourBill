using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();//ürünleri döndürür.Mesajla birlikte
           // List<Product> GetAll();//sadece ürünleri döndürür.
        IDataResult<List<Product>> GetallByCategory(int id);

        IDataResult<List<ProductDetailDto>>GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
            


    }
}
