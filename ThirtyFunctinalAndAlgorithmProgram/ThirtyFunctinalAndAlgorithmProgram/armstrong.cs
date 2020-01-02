// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Armstrong.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// Armstrong is the class where isArmstrong is a method for armstrong
    /// </summary>
    class armstrong
    {
        /// <summary>
        /// Determines whether this instance is angstrong.
        /// </summary>
        /// <returns></returns>
        public static int isAngstrong()
        {
            int sum = 0;
          int temp;
            Console.WriteLine("enter the value of n");
           int n=int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
               int rem = n % 10;
                sum =sum + (rem * rem * rem);
                n = n / 10;
            }
            if (temp == sum)
            
                Console.WriteLine("the number is armstrom");
            
            else
            
                Console.WriteLine("the number is not armstrom");
            return 0;//return 0 becouse retun type i have taken int
        }
    }
}
