// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FlipCoin.cs" company="Bridgelabz">
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
    /// FlipCoin is class where IsCoin is the method.
    /// </summary>
    class FlipCoin
    {
        /// <summary>
        /// Determines whether the specified maximum is coin.
        /// </summary>
        /// <param name="max">The maximum.</param>
        public void IsCoin(int max)
        {
            int head = 0;int tail = 0;
            Random rand = new Random();
          // int r= rand.NextInt(max);
            
            for(int i = 0; i < max; i++)
            {
                int r = rand.Next(max);

                if (r < .5)
                {
                    tail++;
                   
                }
                else
                {
                    head++;
                   
                }
               
            }
            int prh = (head * 100) / max;
            int prt = (tail * 100) / max;

            Console.WriteLine("percentage of head {0}", prh);
            Console.WriteLine("percentage of tail {0}", prt);




        }
    }
}
