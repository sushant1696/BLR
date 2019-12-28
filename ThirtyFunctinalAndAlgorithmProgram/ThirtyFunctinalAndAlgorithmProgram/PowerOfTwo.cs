using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class PowerOfTwo
    {
        public void ispower()

        {
            Console.WriteLine("enter the value of n");

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int a=(int)Math.Pow(2,i);
                Console.WriteLine(a);
            }
            //Console.WriteLine(a);
        }
    }
}
