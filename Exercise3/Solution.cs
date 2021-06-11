using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        int A, b;
        public int square(int A, int B)
        {

            int count = 0;
           for(int i = A; i <= B; i++)
            {
                if(Math.Sqrt(i) % 1 == 0)
                {
                    count += 1;
                }
            }

            return count;

        }

    }
}
