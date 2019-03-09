using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductsMVC.Controllers
{
    public class ProductController : Controller
    {
        IRepository _repository;

        public ProductController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var res = _repository.GetList();
            return View(res);
        }

        public IActionResult Details(int ID)
        {
            var product = _repository.GetProductById(ID);
            return View(product);
        }
    }
}