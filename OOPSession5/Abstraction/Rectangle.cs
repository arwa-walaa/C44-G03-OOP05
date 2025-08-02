using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Abstraction
{
    internal class Rectangle : BaseArea
    {
        public override decimal Perimeter => (Dim01 + Dim02)*2;
        //public override decimal Perimeter
        //{
        //    return (Dim01 + Dim02) * 2;
        //}
        public override string ToString()
        {
            return $"Rectangle with dimensions {Dim01} and {Dim02} has area {CalculateArea()}";
        }
  
    }
}
