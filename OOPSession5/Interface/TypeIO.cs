using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Interface
{
    internal class TypeIO : Itype
    {
        public int MyProperty
        {
            get;
            set;
        }

        public void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod in Type class");
        }
    }
}
