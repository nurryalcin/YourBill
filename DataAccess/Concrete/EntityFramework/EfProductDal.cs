﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortWindContext>, IProductDal
    {
        

        public List<ProductDetailDto> GetProductDetails()
           
        {
            using (NortWindContext context=new NortWindContext())
            {
                var result = from p in context.Products
                             join c in context.Companies
                             on p.ProductName equals c.CompanyName
                             select new ProductDetailDto { ProductId=p.ProductId,ProductName=p.ProductName,};
                return result.ToList();
            }
        }
    }
}