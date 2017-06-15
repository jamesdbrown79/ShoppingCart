using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public char Code { get; set; }
        public double Price { get; set; }
        public Offer Offer { get; set; }

        public Product()
        {
            Offer = new Offer();
        }
    }
}
