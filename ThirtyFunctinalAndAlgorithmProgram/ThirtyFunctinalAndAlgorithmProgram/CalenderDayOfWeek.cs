// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CalenderDayOfWeek.cs" company="Bridgelabz">
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
    /// CalenderDayOfWeek is class where isDay is method for calculating the day of week.
    /// </summary>
    class CalenderDayOfWeek
    {
        /// <summary>
        /// Determines whether the specified d is day.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="m">The m.</param>
        /// <param name="y">The y.</param>
        public void isDay(int d, int m, int y)
        {


            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = (m + 12 * ((14 - m) / 12) - 2);
            int d0 = (d + x + 31 * m0 / 12) % 7;



            if (d > 31 || m > 12)
            {
                Console.WriteLine("invalid date or month enter");
            }

            else
            {
                switch (d0)
                {

                    case 0:
                        Console.WriteLine("sun day");
                        break;
                    case 1:
                        Console.WriteLine("mon day");
                        break;
                    case 2:
                        Console.WriteLine("tues day");
                        break;
                    case 3:
                        Console.WriteLine("wednes day");
                        break;
                    case 4:
                        Console.WriteLine("thus day");
                        break;
                    case 5:
                        Console.WriteLine("fri day");
                        break;
                    case 6:
                        Console.WriteLine("sater day");
                        break;
                   
                }


            }



        }
    }
}

