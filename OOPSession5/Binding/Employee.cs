using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Binding
{
    internal class Employee
    {
        public int id { get; set; }

        public string? name { get; set; }
        public int age { get; set; }

        public virtual void func01()
        {
            Console.WriteLine("Hello Employee");
        }
        public virtual void func02()
        {
            Console.WriteLine($"Emp ID: {id} | Name: {name} | Age: {age}");

        }

    }
}
