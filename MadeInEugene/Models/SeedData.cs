using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;

namespace MadeInEugene.Models
{
    public class SeedData
    {
        public static void Seed(ProductsCompaniesDbContext context)
        {
            if (!context.Products.Any())  // this is to prevent adding duplicate data
            {
                Product product = new Product
                {
                    NameOfProduct = "Product 1",
                    Rating = 1,
                    Review = "review",
                    Company = new Company { ContactInfo = "111111", NameOfCompany = "Company 1" }
                };
                context.Products.Add(product);  
                  Product product1 = new Product
                  {
                      NameOfProduct = "Product 2",
                      Rating = 1,
                      Review = "review",
                      Company = new Company { ContactInfo = "22222", NameOfCompany = "Company 2" }
                  };
                context.Products.Add(product1);
                context.SaveChanges(); // stores all the reviews in the DB

                //next two products will be by the same company, so I will create
                //the company object once and store it so that both products will be
                //associated with the same entity in the DB
                Company aNewCompany = new Company
                {
                    NameOfCompany = "Company 3",
                    ContactInfo = "1112222"
                };

                product = new Product
                {
                    NameOfProduct = "Product 4",
                    Rating = 1,
                    Review = "review",
                    Company = aNewCompany
                };

                context.Products.Add(product);

                product = new Product
                {
                    NameOfProduct = "Product 4",
                    Rating = 1,
                    Review = "review",
                    Company = aNewCompany
                };

                context.Products.Add(product);
                context.SaveChanges();

            }
        }
    
    }
}
