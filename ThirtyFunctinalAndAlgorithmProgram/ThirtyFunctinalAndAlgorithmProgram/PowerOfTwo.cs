// --------------------------------------------------------------------------------------------------------------------
// <copyright file= PowerOfTwo.cs" company="Bridgelabz">
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
    /// PowerOfTwo is the class and Ispower is the method.
    /// </summary>
    class PowerOfTwo
    {
        /// <summary>
        /// Ispowers this instance.
        /// </summary>
        public void Ispower()
        {
            Console.WriteLine("enter the value of n");

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int a=(int)Math.Pow(2,i);
                Console.WriteLine(a);
            }
            
        }
    }
}
