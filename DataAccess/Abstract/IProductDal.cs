using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
       // List<Product> GetAll();
        //  void Add(Product product);
        // void Update(Product product);
        // void Delete(Product product);
        // public List<Product> GetAllByCategory(int CategoryId);//categoriye göre filtreleme ypar.

       // List<ProductDetailDto> GetProductDetails();

    }
}
