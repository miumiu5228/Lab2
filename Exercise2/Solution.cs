using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        
        public int solution(int[] A)
        {
            Dictionary<int, int> myDictionary = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++) 
            {
                if (myDictionary.ContainsKey(A[i]))
                {
                    myDictionary[A[i]] = myDictionary[A[i]] + 1;
                }
                else
                {
                    myDictionary.Add(A[i], 1);
                }
               
            }

            int maxValue = 0;
            int mostOccur = 0;
            foreach (KeyValuePair<int, int> kvp in myDictionary)
            {
                if(kvp.Value > maxValue)
                {
                    maxValue = kvp.Value;
                    mostOccur = kvp.Key;

                }
            
            }

            return mostOccur;
        }
    }
}
