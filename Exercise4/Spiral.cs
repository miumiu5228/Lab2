using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Spiral
    {
        public void DisplayMatrix(int[,] matrix)
        {
          
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                
            }
        }

    }
}
