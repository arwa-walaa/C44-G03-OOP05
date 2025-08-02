using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Abstraction
{
    internal abstract class BaseArea:Shape

    {
       

        public override decimal CalculateArea()
        {
            return Dim01 * Dim02; // Assuming Dim01 and Dim02 are the base dimensions
        }
        public override string ToString()
        {
            return $"BaseArea with dimensions {Dim01} and {Dim02} has area {CalculateArea()}";
        }
    }
}
