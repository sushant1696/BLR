// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TwoDArray.cs" company="Bridgelabz">
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
    /// TwoDArray Is a class where IaArray is the method
    /// </summary>
    class TwoDArray
    {
        /// <summary>
        /// Determines whether this instance is array.
        /// </summary>
        public static void IsArray()
        {
            int[,] array = new int[3, 3] ;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0} and {1}",i, j);

                }

                
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}",array[i,j]);
                   // array[i, j] = Convert.ToInt32(Console.ReadLine());


                }

                Console.WriteLine("\n");

            }
        }
    }
}
