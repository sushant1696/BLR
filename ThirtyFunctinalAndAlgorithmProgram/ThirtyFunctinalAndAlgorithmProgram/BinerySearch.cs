using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class BinerySearch
    {
        public int isbinary(int[] arr, int li, int hi, int x)
        {


            if (li <= hi)
            {
                int mi = (li + hi) / 2;

                if (arr[mi] == x)
                {
                    return mi;
                }
                if (arr[mi] > x)
                {
                    return isbinary(arr, 0, mi - 1, x);
                }
                else
                    return isbinary(arr, mi + 1, hi, x);
            }
            return -1;
        }
    }
}
        

