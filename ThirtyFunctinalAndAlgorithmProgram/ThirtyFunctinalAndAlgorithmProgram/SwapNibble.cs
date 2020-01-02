using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
/// created by: sushanta das(student of bridgelabz)
/// date:31.12.2019
/// This class create for swap the nible of byte
/// </summary>
    class SwapNibble
    {
 
        //method for swaping the nibble.
        public int isswap(int x)
                   
        {
           
            //given value perform AND operation with haxadecimal 0F and F0
            //and perform left shift and right shift ,finally both number perform OR operation
            return ((x & 0xF0)<<4| ((x & 0x0F) << 4));
            

        }
    }
}
