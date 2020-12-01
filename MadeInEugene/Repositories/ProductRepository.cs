using System;
using System.Linq;
using MadeInEugene.Models;
using Microsoft.EntityFrameworkCore;

namespace MadeInEugene.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ProductsCompaniesDbContext context;


        public ProductRepository(ProductsCompaniesDbContext c)
        {
            context = c;
        }


        public IQueryable<Product> Products
        {
            get
            {
                return context.Products.Include(product => product.Company);
            }
        }


        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public Product FindProductById(int id)
        {
            var product = context.Products
                .Include(product => product.Company)
                .Where(product => product.ProductId == id)
                .First();
            return product;
        }
    }
}
