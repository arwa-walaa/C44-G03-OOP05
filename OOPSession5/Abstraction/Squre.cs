using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Abstraction
{
    internal class Squre : BaseArea
    {
       public Squre(decimal Dim) 
        {
            Dim01 = Dim;
            Dim02 = Dim; 
        }

        public override decimal Perimeter => Dim01*4;

        public override string ToString()
        {
            return $"Square with side {Dim01} has area {CalculateArea()}";
        }
   
    }
}
