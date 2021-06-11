using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetData();
            double area = rectangle.GetArea();
            double perimeter = rectangle.GetPerimeter();
            Console.WriteLine($"The area of the rectangle is {area}");
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");

        }
    }
}
