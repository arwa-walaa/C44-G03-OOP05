using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Interface
{
    internal interface Itype
    {
        public int MyProperty { get; set; }

        public void MyMethod();

        public void print()
        {
            Console.WriteLine("Hello from print method in Itype interface");
        }
    }
}
