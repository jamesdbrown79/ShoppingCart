using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Checkout
    {
        public string goods { get; set; }

        public Checkout(string goods)
        {
            this.goods = goods;
        }

        public Dictionary<char, int> CountGoods()
        {
            return goods.GroupBy(g => g).ToDictionary(grp => grp.Key, grp => grp.Count());
        }

        public double CartTotal()
        {
            double total = 0;
            Dictionary<char, int> items = CountGoods();

            Catalogue catalogue = new Catalogue();
            List<Product> products = catalogue.ListAllProducts();

            foreach (var item in items)
            {
                Product product = products.FirstOrDefault(p => p.Code == item.Key);
                total += item.Value * product.Price;
                if (product.Offer.Quantity > 0)
                {
                    total -= (item.Value / product.Offer.Quantity) * product.Offer.Discount;
                }
            }

            return total;
        }
    }
}
