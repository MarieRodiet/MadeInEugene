using System;
using MadeInEugene.Models;
using System.Linq;

namespace MadeInEugene.Repositories
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; } //Retrieve a list of Products

        Product FindProductById(int id); //Retrieve a product

        void UpdateProduct(Product product); //Update

        void DeleteProduct(Product product); //Delete

        void AddProduct(Product product); //Add

        
    }
}
