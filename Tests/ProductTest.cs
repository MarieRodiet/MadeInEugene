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
            Assert.Single(fakeRepo.Products.ToList());
            controller.Delete(product);

            //Assert that my delete method in the controller did remove my product in the list of my fake repo
            Assert.Empty(fakeRepo.Products.ToList());
        }

        [Fact]
        public void EditProductWith0asIdTest()
        {
            //Arrange
            FakeProductRepository fakeRepo = new FakeProductRepository();
            InputProductController controller = new InputProductController(fakeRepo);

            Product product = new Product()
            {
                ProductId = 0,
                NameOfProduct = "Surata Tofu",
                Rating = 4,
                Review = "great product",

            };

            //Act
            controller.Edit(product);
            //because products' id is 0, it should be added
            Assert.Single(fakeRepo.Products.ToList());
            Product retrievedProduct = fakeRepo.Products.ToList()[0];
            Assert.Equal("Surata Tofu", retrievedProduct.NameOfProduct);

        }

        [Fact]
        public void EditProductWithPositiveIdTest()
        {
            //Arrange
            FakeProductRepository fakeRepo = new FakeProductRepository();
            InputProductController controller = new InputProductController(fakeRepo);

            Product product = new Product()
            {
                ProductId = 3,
                NameOfProduct = "Surata Tofu",
                Rating = 4,
                Review = "great product",

            };

            //Add it first
            controller.Index(product);
            //Retrieve it, then update it
            Product retrievedProduct = fakeRepo.Products.ToList()[0];
            retrievedProduct.NameOfProduct = "updated";
            retrievedProduct.Rating = 3;
            controller.Edit(retrievedProduct);
            //retrieve it again to check if updated
            Product updatedProduct = fakeRepo.Products.ToList()[0];

            Assert.Equal("updated", updatedProduct.NameOfProduct);
        }
    }
}
