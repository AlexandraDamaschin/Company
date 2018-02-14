using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Company.DAL
{
    public class IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductByID(int id);
    }
}