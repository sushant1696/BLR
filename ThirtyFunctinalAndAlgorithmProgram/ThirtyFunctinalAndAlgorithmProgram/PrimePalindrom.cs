using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class PrimePalindrom
    {
        public void isprime()
        {
            
            for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                if (i > 1)
                {
                    for (int j = 2; j <= 99; j++)
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
           // while (n > 0)
            {

            }
        }
    }
}
