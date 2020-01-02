using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class InsertionSort
    {
        public static void insertion()
        {
            int temp;
            int j;
            int[] a = { 5, 1, 4, 3, 6 };
            for(int i = 1; i < a.Length; i++)
            {
                temp = a[i];
                j = i;
                while (j > 0 && a[j - 1] > temp)
                {
                    a[j] = a[j - 1];
                    j = j - 1;
                }
                a[j] = temp;

            }
            for ( j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }

    }
}
