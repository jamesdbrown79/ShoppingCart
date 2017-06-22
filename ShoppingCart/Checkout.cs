using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class Checkout
    {
        private List<Product> productCatalogue;
        private List<string> scannedItems = new List<string>();

        public Checkout(List<Product> productCatalogue)
        {
            this.productCatalogue = productCatalogue;
        }

        public void Scan(string Items)
        {
            char[] items = Items.ToCharArray();

            foreach (var item in items)
            {
                scannedItems.Add(item.ToString());
            }
        }

        public double Total()
        {
            double total = 0;
            Dictionary<string, int> scannedItemsCount = new Dictionary<string, int>();

            scannedItemsCount = scannedItems.GroupBy(g => g).ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (var item in scannedItemsCount)
            {
                Product product = productCatalogue.FirstOrDefault(p => p.Code == item.Key);
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
