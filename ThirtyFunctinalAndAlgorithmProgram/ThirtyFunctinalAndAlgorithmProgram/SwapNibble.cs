// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SwapNibble.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
/// SwapNibble is a class where IsSwap is the method
/// </summary>
    class SwapNibble
    {
        /// <summary>
        /// Determines whether the specified x is swap.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public int IsSwap(int x)
                   
        {
           
            //given value perform AND operation with haxadecimal 0F and F0
            //and perform left shift and right shift ,finally both number perform OR operation
            return ((x & 0xF0)<<4| ((x & 0x0F) << 4));
            

        }
    }
}
