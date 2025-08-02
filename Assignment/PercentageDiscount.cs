using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PercentageDiscount : Discount
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
            Name = $"{percentage}% Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (_percentage / 100);
        }
    }
}
