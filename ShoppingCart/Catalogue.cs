using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Catalogue
    {
        public List<Product> ListAllProducts()
        {
            List<Product> products = new List<Product>() {
                new Product
                {
                    Code = 'A',
                    Price = 50,
                    Offer = { Quantity = 3, Discount = 20 }
                },
                new Product
                {
                    Code = 'B',
                    Price = 30,
                    Offer = { Quantity = 2, Discount = 15 }
                },
                new Product
                {
                    Code = 'C',
                    Price = 20,
                    Offer = { Quantity = 0, Discount = 0 }
                },
                new Product
                {
                    Code = 'D',
                    Price = 15,
                    Offer = { Quantity = 0, Discount = 0 }
                }
            };

            return products;
        }
    }
}
