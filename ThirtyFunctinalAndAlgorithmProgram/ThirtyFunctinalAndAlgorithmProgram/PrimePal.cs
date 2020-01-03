using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class PrimePal
    {
        public void IsPrimePal()
        {
            int n = 181, count = 0, r = 0, s = 0;
            int p = n;
            for (int i = 1; i <= n; i++)
            {
                if (p % i == 0)
                {
                    count++;
                }
            }
            while (n != 0)
            {
                r = n % 10;
                s = s * 10 + r;
                n = n / 10;

            }
            if (p == s && count == 2)
            {
                Console.WriteLine("no is prime pal:" + p);
            }
            else
            {
                Console.WriteLine("no is not prime pal:" + p);
            }
        }
    }
}
