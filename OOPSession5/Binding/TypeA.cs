using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Binding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
        }
        public void funct01()
        {
            Console.WriteLine("Parent Class");
        }

        public virtual void funct02()
        {
            Console.WriteLine($"TypeA A: {A}");
        }

    }
}
