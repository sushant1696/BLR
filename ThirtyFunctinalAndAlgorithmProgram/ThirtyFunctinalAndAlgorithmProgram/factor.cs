// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Factor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// Factor is a class where isFactor is a method.
    /// </summary>
    class Factor
    {
        /// <summary>
        /// Determines whether the specified n is Factor.
        /// </summary>
        /// <param name="n">The n.</param>
        public void IsFactor(int n)
        {
            int fact=1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;

                Console.WriteLine(fact);
            }
        }
          
    }
}
