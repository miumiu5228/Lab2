using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle
    {
        double length = 1;
        double width = 1;
        public void GetData()
        {
            bool isValid = true;
            while (isValid)
            {
                Console.WriteLine("Please enter length: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter width: ");
                width = Convert.ToInt32(Console.ReadLine());

                if (width < 0 || width > 20 || length < 0 || length > 20)
                {
                    isValid = true;
                    Console.WriteLine("Length and width are between 0 and 20! Please enter valid input.");
                }
                else
                {
                    isValid = false;
                }
            }
        }

        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

    }
}
