// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WindChill.cs" company="Bridgelabz">
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
    /// WindChill is the class where IsWindchil is the method.
    /// </summary>
    class WindChill
    {
        /// <summary>
        /// Determines whether this instance is windchil.
        /// </summary>
        public void  IsWindchil()
        {

            //while ((t > 50) && (3 < v < 250))
            Console.WriteLine("enter the value of t which is greater than 50");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of v which is greater than 3 or less than 250");
            int v = int.Parse(Console.ReadLine());

            double w = 35.74 + 0.6215 * t + (.4275 * t - 35.75) * Math.Pow(v, 0.16);

            Console.WriteLine("the value of t:" + t);
            Console.WriteLine("the value of v:" + v);
            Console.WriteLine("out put of the wind chil is"+ w);
        }
    }
}
