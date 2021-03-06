﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SquareRoot.cs" company="Bridgelabz">
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
    /// SquareRoot is class where IsSquare is a method square root class.
    /// </summary>
    class SquareRoot
    {
        /// <summary>
        /// Determines whether this instance is square.
        /// </summary>
        public static void IsSquare()
        {
            double delta = 0, a = 1, b = 3, c = 5,r1,r2;
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                r1 = -b + (Math.Sqrt(delta)) / 2 * a;
                r2 = -b - (Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine(r1);
                Console.WriteLine(r1);
            }
            else if (delta == 0)
            {
                r1 = -b / 2 * a;
                r2 = -b / 2 * a;
                Console.WriteLine(r1);
            }
            else
            {
                double real = -b / 2 * a;
                double img = Math.Sqrt(-delta) / 2 * a;
                Console.WriteLine(real);
                Console.WriteLine(img);
            }
                    
        }
    }
}
