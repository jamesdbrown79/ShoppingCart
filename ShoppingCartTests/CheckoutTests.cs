using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void should_return_total_price()
        {
            //setup
            Checkout checkout = new Checkout("AABCDA");

            //act
            double result = checkout.CartTotal();

            //assert
            Assert.AreEqual(195, result);
        }

        [TestMethod()]
        public void should_return_product_count()
        {
            //setup
            Checkout checkout = new Checkout("AABCDAD");

            //act
            Dictionary<char, int> result = checkout.CountGoods();

            //assert
            Assert.AreEqual(3, result['A']);
            Assert.AreEqual(1, result['B']);
            Assert.AreEqual(1, result['C']);
            Assert.AreEqual(2, result['D']);
        }
    }
}