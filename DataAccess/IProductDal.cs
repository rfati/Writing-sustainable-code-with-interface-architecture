using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IProductDal
    {
        public List<Product> GetAll();

        void Add(Product product);

    }
}
