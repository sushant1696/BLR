// --------------------------------------------------------------------------------------------------------------------
// <copyright file=BinerySearch.cs" company="Bridgelabz">
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
    /// BinerySearch is a class where isBinery is the method for Binery search.
    /// </summary>
    class BinerySearch
    {
        /// <summary>
        /// Determines whether the specified arr is binary.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="li">The li.</param>
        /// <param name="hi">The hi.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public int isBinary(int[] arr, int li, int hi, int x)
        {

            //// li=lower index of the array
            ////hi= highst index of the array
            /////mi=middle index
            ////x = searching element
            if (li <= hi)
            {
                int mi = (li + hi) / 2;

                if (arr[mi] == x)
                {
                    return mi;
                }
                if (arr[mi] > x)
                {
                    return isBinary(arr, 0, mi - 1, x);
                }
                else
                    return isBinary(arr, mi + 1, hi, x);
            }
            return -1;
        }
    }
}
        

