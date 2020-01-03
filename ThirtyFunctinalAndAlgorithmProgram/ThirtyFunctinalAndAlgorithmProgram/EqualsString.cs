// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EqualsString.cs" company="Bridgelabz">
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
    /// EqualsString is a class where IsEqual is the method
    /// </summary>
    class EqualsString
    {
        /// <summary>
        /// Determines whether this instance is equal.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is equal; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEqual()
        {
            Console.WriteLine("enter 1st  string");
            String s1 = Console.ReadLine();
            Console.WriteLine("enter 2nd  string");
            String s2 = Console.ReadLine();
            if (s1 == null || s2 == null)
            {
                return false;
            }
            if (s1.Length! == s2.Length)
            {
                return false;
            }
            if (s1.Equals(s2))
            {
                return false;
            }


            return true;



        }
    }
}
