// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DecimalToBinary.cs" company="Bridgelabz">
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
    /// DecimalToBinary is a class where IsBinery is the method for decimal to binary convert
    /// </summary>
    class DecimalToBinary
    {
        /// <summary>
        /// IsBinaries this instance.
        /// </summary>
        public void IsBinary()
        {
            //// memory size for storing the binary number
            int[] rem = new int[10];
            //string rem = " ";
          int index = 0;
            int n = 16;
            while (n > 0)
            {
                rem[index] = n % 2;
                index++;
                n =n / 2;
                Console.WriteLine(rem[index]);
            }

            /*for( index = 0; n>0; index++)
            {
                String rem1 = (n % 2).ToString();
              rem=rem+ ""+rem1;
                n = n / 2;
            }*/

            //// print the out put

            for(int i = (index - 1); i > 0; i--)
            {
                Console.Write(rem[i]);
            }
        }
    }
}
