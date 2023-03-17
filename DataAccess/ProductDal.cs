using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ProductDal : IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,ProductName="Laptop",QuantityPerUnit="adet",UnitPrice=10000,UnitsInStock=15},
                new Product{ProductId=1,ProductName="Televizyon",QuantityPerUnit="adet",UnitPrice=13000,UnitsInStock=12},
                new Product{ProductId=1,ProductName="Telefon",QuantityPerUnit="adet",UnitPrice=49000,UnitsInStock=3},
                new Product{ProductId=1,ProductName="Akvaryum",QuantityPerUnit="adet",UnitPrice=849,UnitsInStock=56},
                new Product{ProductId=1,ProductName="Oklava",QuantityPerUnit="adet",UnitPrice=5,UnitsInStock=76},
                new Product{ProductId=1,ProductName="A++ Pil",QuantityPerUnit="adet",UnitPrice=23,UnitsInStock=345}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Added with Ado.NET");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
