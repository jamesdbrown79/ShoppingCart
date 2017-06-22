using System;

namespace ShoppingCart
{
    public class Product
    {
        public string Code { get; set; }
        public double Price { get; set; }
        public Offer Offer { get; set; }

        public Product()
        {
            Offer = new Offer();
        }
    }
}
