using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void should_return_multiple_item_total_price()
        {
            //arrange
            List<Product> productCatalogue = Catalogue.ListAllProducts();
            Checkout checkout = new Checkout(productCatalogue);

            //act
            checkout.Scan("AABCDA");

            //assert
            Assert.AreEqual(195, checkout.Total());
        }

        [TestMethod()]
        public void should_return_single_item_price()
        {
            //arrange
            List<Product> productCatalogue = Catalogue.ListAllProducts();
            Checkout checkout = new Checkout(productCatalogue);

            //act
            checkout.Scan("A");

            //assert
            Assert.AreEqual(productCatalogue.FirstOrDefault(p => p.Code == "A").Price, checkout.Total());
        }
    }
}