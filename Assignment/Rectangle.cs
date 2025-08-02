using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area => Length * Width;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with length {Length} and width {Width} has area {Area:F2}");
        }
    }
}
