using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Solution solution = new Solution();
            Console.WriteLine("The number of whole square is " + solution.square(A, B));

        }
    }
}
