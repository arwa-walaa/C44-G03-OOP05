using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession5.Binding
{
    internal class PartTimeEmployee : Employee

    {
        public decimal hourlyRate { get; set; }
        public int hoursWorked { get; set; }
        public new virtual void func01()
        {
            Console.WriteLine("Hello part time Employee");
        }
        public override void func02()
        {
            Console.WriteLine($"Emp ID: {id} | Name: {name} | Age: {age} | Hourly Rate: {hourlyRate} | Hours Worked: {hoursWorked}");
        }
    }
}
