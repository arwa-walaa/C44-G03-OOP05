using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Example02Interface
{
    internal class Car :Vehicle, IMoveOnGround
    {
     
        public void Backward()
        {
            Console.WriteLine("Car is moving backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car is moving forward");
        }

        public void Left()
        {
            Console.WriteLine("Car is movin left");
        }

        public void Right()
        {
            Console.WriteLine("Car is moving right");
        }
    }
}
