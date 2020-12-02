using System;
using System.Collections.Generic;
using System.Linq;
using MadeInEugene.Models;

namespace MadeInEugene.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        //List of Product instead of database
        private List<Product> products = new List<Product>();

        //needs to return an IQuerable because that's what the db would do
        public IQueryable<Product> Products
        {
            get
            {
                var queryable = products.AsQueryable();
                return queryable;
            }
        }

        //needs to add a product to the List
        public void AddProduct(Product product)
        {
            //ProductId needs to be set manually
            product.ProductId = products.Count;
            products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public Product FindProductById(int id)
        {
            Product product = new Product();
            product.ProductId = id;
            return product;
        }

        public void UpdateProduct(Product product)
        {
            Product oldProduct = new Product();
            oldProduct.ProductId = products.Count;
            product = oldProduct;

        }
    }
}
