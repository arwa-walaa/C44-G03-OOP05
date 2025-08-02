using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FlatDiscount : Discount
    {
        private readonly decimal _flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            _flatAmount = flatAmount;
            Name = $"Flat {flatAmount:C} Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return _flatAmount * Math.Min(quantity, 1);
        }
    }
}
