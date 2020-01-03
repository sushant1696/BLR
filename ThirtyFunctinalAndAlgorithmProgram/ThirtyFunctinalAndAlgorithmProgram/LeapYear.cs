// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LeapYear.cs" company="Bridgelabz">
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
    /// LeapYear is a class and Isleap is the method
    /// </summary>
    class LeapYear
    {
        /// <summary>
        /// Isleaps this instance.
        /// </summary>
        public void Isleap()
        {
            int year;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());
            if(year%4==0 && year % 400==0)
            {
                Console.WriteLine("the year is leap year");
            }
            else
            {
                Console.WriteLine("the year is not a leap year");
            }
        }
    }
}
