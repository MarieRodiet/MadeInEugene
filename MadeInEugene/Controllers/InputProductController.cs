using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadeInEugene.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MadeInEugene.Controllers
{
    public class InputProductController : Controller
    {

        private ProductsCompaniesDbContext context { get; set; }


        public InputProductController(ProductsCompaniesDbContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return View(product);
        }

        public IActionResult Products(Product product)
        {
            var products = context.Products.Include(product => product.Company).ToList<Product>();
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var review = context.Products.Find(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                //if it is the first product ever entered in the database (id will be 0)
                if (product.ProductId == 0)
                    context.Products.Add(product);
                else
                    context.Products.Update(product);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            //if invalid data
            else
                return View(product);
               

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
