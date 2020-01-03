// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReverseANumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// ReverseANumber is a class where IsReverse is a method
    /// </summary>
    class ReverseANumber
    {

        /// <summary>
        /// Determines whether the specified n is reverse.
        /// </summary>
        /// <param name="n">The n.</param>
        public void     IsReverse(int n)
           
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
