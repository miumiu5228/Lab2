using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Please enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
               
                nums[i] = number;
            }
          
            
            Solution s = new Solution();
            Console.WriteLine("The most occurs number is " + s.solution(nums));
        }
    }
}
