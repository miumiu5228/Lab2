using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiral spiral = new Spiral();
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            spiral.DisplayMatrix(matrix);
        }
    }
}
