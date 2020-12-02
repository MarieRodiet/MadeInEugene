using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadeInEugene.Models;
using MadeInEugene.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MadeInEugene.Controllers
{
    public class InputProductController : Controller
    {
        IProductRepository repo;

        public InputProductController(IProductRepository r)
        {
            repo = r;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            if (ModelState.IsValid)
                repo.AddProduct(product);
            return View(product);
        }

        public IActionResult Products()
        {
            //var products = repo.Products.Include(product => product.Company).ToList<Product>();
            List<Product> products = repo.Products.ToList<Product>();
            return View(products);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var product = context.Products.Find(id);
            //needed to include other model Company to have its name and contact info show up in View
            var productWithCompany = repo.FindProductById(id);
            return View(productWithCompany);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                //if it is the first product ever entered in the database (id will be 0)
                if (product.ProductId == 0)
                    repo.AddProduct(product);
                else
                    repo.UpdateProduct(product);
                return RedirectToAction("Index", "Home");
            }
            //if invalid data
            else
                return View(product);
               

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = repo.FindProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index", "Home");
        }

    }
}
