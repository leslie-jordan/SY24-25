using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    internal class CoinSlot
    {
        public double total = 0;
        public void InsertCoin(string coin)
        {
            if (coin == "penny")
            {
                total = total + .01;
            }
            if (coin == "nickel")
            {
                total = total + .05;
            }
            if (coin == "dime")
            {
                total = total + .10;
            }
            if (coin == "quarter")
            {
                total = total + .25;
            }
        }
        public void CoinReturn()
        {
            total = 0;
        }
    }
}
