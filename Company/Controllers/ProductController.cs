using Company.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository repository;

        // GET: Product
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(repository.GetProducts());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(repository.GetProductByID(id));
        }
    }
    }
