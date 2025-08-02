using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Example02Interface
{
    internal class AirPlane : Vehicle, IMoveOnAir, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Airplane is moving backward");
        }

        public void Forward()
        {
           Console.WriteLine("Airplane is moving forward");
        }

        public void Left()
        {
           Console.WriteLine("Airplane is moving left");
        }

        public void Right()
        {
           Console.WriteLine("Airplane is moving right");
        }
        //void IMoveOnAir.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Forward()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Left()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnAir.Right()
        //{
        //    throw new NotImplementedException();
        //}

        //void IMoveOnGround.Right()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
