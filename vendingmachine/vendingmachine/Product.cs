using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    internal class Product
    {
        public CoinSlot CS = new CoinSlot();
        Dictionary<string, int> merch = new Dictionary<string, int>();
        public void AddProduct(string product, int count)
        {
            merch.Add(product, count);
        }

        public void Buy(string product, double price)
        {
            if (CS.total >= price && merch[product] > 0)
            {
                CS.total = CS.total - price;
                merch[product]--;
            }
           

        }

        public int GetCount(string product)
        {
            return merch[product];
        }
    }
}
