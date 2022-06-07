using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        
            static void Main(string[] args)
            {
                ProductTest();
                // CategoryTest();

            }

           

            private static void ProductTest()
            {
                ProductManager productManager = new ProductManager(new EfProductDal());
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + " " + product.ProductId);
                }
            }
        }
    }

