using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class BubbleSort
    {
        public static void isbubble(int [] array,int n)
        {
            int temp;
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                for ( i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
