// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Even.cs" company="Bridgelabz">
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
    /// Even is a class where  IsEven
    /// </summary>
    class Even
    {
        /// <summary>
        /// Isevens this instance.
        /// </summary>
        public void IsEven()
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
