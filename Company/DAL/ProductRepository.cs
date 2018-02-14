using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DAL
{
    public class ProductRepository : IProductRepository
    {
        private SampleDBEntities context;

        public ProductRepository(SampleDBEntities context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}