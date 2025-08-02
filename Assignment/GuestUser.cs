using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class GuestUser : User
    {
        public GuestUser()
        {
            Name = "Guest User";
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
