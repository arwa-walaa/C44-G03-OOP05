using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal radius)
        {
            Dim01 = Dim02 = radius; // Assuming Dim01 is the radius
           
        }
        public override decimal Perimeter => 2 * 3.14m * Dim01 ;

        public override decimal CalculateArea()
        {
            return 3.14m * Dim01 * Dim01; 
        }
    }
}
