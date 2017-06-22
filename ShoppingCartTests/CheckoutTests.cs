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
            //setup
            List<Product> productCatalogue = Catalogue.ListAllProducts();
            Checkout checkout = new Checkout(productCatalogue);

            //act
            checkout.Scan("AABCDA");
            double result = checkout.Total();

            //assert
            Assert.AreEqual(195, result);
        }

        [TestMethod()]
        public void should_return_single_item_price()
        {
            //setup
            List<Product> productCatalogue = Catalogue.ListAllProducts();
            Checkout checkout = new Checkout(productCatalogue);

            //act
            checkout.Scan("A");
            double result = checkout.Total();

            //assert
            Assert.AreEqual(productCatalogue.FirstOrDefault(p => p.Code == "A").Price, result);
        }
    }
}