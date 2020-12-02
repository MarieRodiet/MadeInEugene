using System;
using System.Linq;
using MadeInEugene.Controllers;
using MadeInEugene.Models;
using MadeInEugene.Repositories;
using Xunit;

namespace Tests
{
    public class ProductTest
    {

        [Fact]
        public void AddProductTest()
        {
            //Arrange
            FakeProductRepository fakeRepo = new FakeProductRepository();
            InputProductController controller = new InputProductController(fakeRepo);
            Product product = new Product()
            {
                ProductId = -1,
                NameOfProduct = "Surata Tofu",
                Rating = 4,
                Review = "great product",

            };

            //Act
            controller.Index(product);

            //Assert that my index method in the controller did add my product to the list in my fake repo
            Product retrievedProduct = fakeRepo.Products.ToList()[0];
            Assert.Equal("great product", retrievedProduct.Review);
        }

        [Fact]
        public void RemoveProductTest()
        {
            //Arrange
            FakeProductRepository fakeRepo = new FakeProductRepository();
            InputProductController controller = new InputProductController(fakeRepo);
            Product product = new Product()
            {
                ProductId = -2,
                NameOfProduct = "Surata Tofu",
                Rating = 4,
                Review = "great product",

            };

            //Act
            //Add it, then can delete it
            controller.Index(product);
            controller.Delete(product);

            //Assert that my delete method in the controller did remove my product in the list of my fake repo
            Assert.Null(fakeRepo.Products.ToList()[0]);
        }

    }
}
