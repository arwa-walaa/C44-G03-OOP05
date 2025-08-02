using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal abstract class User
    {
        public string Name { get; protected set; }

        public abstract Discount GetDiscount();
    }
}
