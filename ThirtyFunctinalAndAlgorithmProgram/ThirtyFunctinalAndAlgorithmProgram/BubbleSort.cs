// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BubbleSort.cs" company="Bridgelabz">
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
    /// BubbleSort is  class where using a isBubble method to sort.
    /// </summary>
    class BubbleSort
    {
        /// <summary>
        /// Determines whether the specified array is bubble.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="n">The n.</param>
        public static void isBubble(int [] array,int n)
        {
            int temp;
            ////until sorting complete loop will execute
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                //print the out put
                for ( i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
