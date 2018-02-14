using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DAL
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductByID(int id);
    }
}