// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SquareRootOfNonNegativeNo.cs" company="Bridgelabz">
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
    /// SquareRootOfNonNegativeNo is a class where isSquare is method
    /// </summary>
    class SquareRootOfNonNegativeNo
    {
        /// <summary>
        /// Determines whether this instance is squar.
        /// </summary>
        public static void IsSquar()
        {
            Console.WriteLine("enter the value of c");
            double c = int.Parse(Console.ReadLine());
           double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - t / c) > epsilon * t)
            {
                t = (t / c + t) / 2.0;
                Console.WriteLine(t);
            }
        }
    }
}
