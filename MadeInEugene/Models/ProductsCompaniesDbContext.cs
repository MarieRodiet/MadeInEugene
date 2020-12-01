using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadeInEugene.Models
{
    public class ProductsCompaniesDbContext : DbContext
    {
        public ProductsCompaniesDbContext(DbContextOptions<ProductsCompaniesDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = -1,
                    NameOfCompany = "Nancy's",
                    ContactInfo = "(541) 689-2911"
                },
                 new Company
                 {
                     CompanyId = -2,
                     NameOfCompany = "Surata Soyfoods Inc",
                     ContactInfo = "(541) 485-6990"

                 }
                );
            /*        modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = -1,
                    NameOfProduct = "Surata Tofu",
                    Rating = 4,
                    Review = "great product",



                });*/
        }

    }
}

