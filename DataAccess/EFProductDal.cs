using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class EFProductDal : IProductDal
    {
        List<Product> _products;
        public EFProductDal()
        {

            _products = new List<Product>
            {
                new Product{ProductId=1,ProductName="Laptop EF",QuantityPerUnit="adet",UnitPrice=10000,UnitsInStock=15},
                new Product{ProductId=1,ProductName="Televizyon EF",QuantityPerUnit="adet",UnitPrice=13000,UnitsInStock=12},
                new Product{ProductId=1,ProductName="Telefon EF",QuantityPerUnit="adet",UnitPrice=49000,UnitsInStock=3},
                new Product{ProductId=1,ProductName="Akvaryum EF",QuantityPerUnit="adet",UnitPrice=849,UnitsInStock=56},
                new Product{ProductId=1,ProductName="Oklava EF",QuantityPerUnit="adet",UnitPrice=5,UnitsInStock=76},
                new Product{ProductId=1,ProductName="A++ Pil EF",QuantityPerUnit="adet",UnitPrice=23,UnitsInStock=345}
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("Added with Entity Framework");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
