using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.BuiltInIo
{
    internal class UserNameComparer : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            //x >y return 1
            //x < y return -1
            //x == y return 0
           
            return string.Compare(x?.Name, y?.Name);
            
        }
    }
}
