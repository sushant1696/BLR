using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class ReverseANumber
    {
       
        public void isreverse(int n)
           
        {
            int rev =0, sum =0;

            while (n > 0)
            {
                rev = n % 10;
                sum = sum * 10 + rev;
                n = n / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
