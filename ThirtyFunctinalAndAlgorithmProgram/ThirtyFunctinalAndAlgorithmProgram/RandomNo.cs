// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RandomNo.cs" company="Bridgelabz">
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
    /// RandomNo is a class where IsRandom is a method 
    /// </summary>
    class RandomNo
    {
        /// <summary>
        /// Israndoms the specified minimum.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public double IsRandom(int min,int max)
        {
            
                Random random = new Random();

                return random.Next(min,max);
       
            
        }
    }
}
