using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50% Off";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity <= 1) return 0;
            return (price / 2) * (quantity / 2);
        }
    }
}
