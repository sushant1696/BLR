using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class RandomNo
    {
        /// <summary>
        /// Israndoms the specified minimum.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public double israndom(int min,int max)
        {
            
                Random random = new Random();

                return random.Next(min,max);
       
            
        }
    }
}
