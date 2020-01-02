using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class PrimePalindrom
    {
        public void isprime()
        {
            int n=100;
            int h = n;
            int sum = 0, rem = 0; ;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                if (i > 1)
                {
                    for (int j = 2; j <= n-1; j++)
                    {
                        if (i % j == 0)
                        {

                            count++;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine(i + "");
                        }
                    }
                }
            }
            while ( h > 0)
            {
                rem = h % 10;
                 sum = sum + h % 10;
                h = h / 10;
            }
            if (sum ==h)
            {
                Console.WriteLine(sum + "");
            }
        }
    }
}
