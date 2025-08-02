using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public new void funct01()
        {
            Console.WriteLine("Child Class");
        }
        public override void funct02()
        {
            Console.WriteLine($"TypeB, A: {A}, B: {B}");
        }
    }
  
}
