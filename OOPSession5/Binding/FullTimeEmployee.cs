using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Binding
{
    internal class FullTimeEmployee : Employee

    {
        public decimal salary { get; set; }

        public override void func01()
        {
            Console.WriteLine("Hello full time Employee");
        }
        public override void func02()
        {
            Console.WriteLine($"Emp ID: {id} | Name: {name} | Age: {age} | salary: {salary}");

        }
    }
}
