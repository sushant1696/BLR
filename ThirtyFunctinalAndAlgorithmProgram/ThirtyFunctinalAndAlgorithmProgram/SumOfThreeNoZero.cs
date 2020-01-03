// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SumOfThreeNoZero.cs" company="Bridgelabz">
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
    /// SumOfThreeNoZero is class where IsZero is the method
    /// </summary>
    class SumOfThreeNoZero
    {
        /// <summary>
        /// Determines whether this instance is zero.
        /// </summary>
        public void IsZero() 
        { 

        int[] array = { 0,1, 3, 5, 6, 7, 8, -8 };
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    for (int k = j + 1; k< array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine("the pairs are");
                            Console.WriteLine( array[i]);
                            Console.WriteLine( array[j]);
                            Console.WriteLine( array[k]);
                        }
                    }
                }
            }

            
        }   
    }
}
