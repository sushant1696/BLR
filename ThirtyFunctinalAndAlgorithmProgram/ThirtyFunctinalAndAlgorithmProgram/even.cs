using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// 
    /// </summary>
    class even
    {
        /// <summary>
        /// Isevens this instance.
        /// </summary>
        public void iseven()
        {
            Console.WriteLine("enter the number of n");
            int n = int.Parse(Console.ReadLine());
            ////
            if (n % 2 == 0)
            {
                Console.WriteLine("the number is even number");

            }
            else
            {
                Console.WriteLine("not a even number");
            }
        }
    }
}
