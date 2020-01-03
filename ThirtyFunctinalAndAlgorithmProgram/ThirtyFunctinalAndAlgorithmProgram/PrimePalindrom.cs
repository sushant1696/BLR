// --------------------------------------------------------------------------------------------------------------------
// <copyright file= PrimePalindrom.cs" company="Bridgelabz">
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
    ///  PrimePalindrom is a class where Isprime is the method.
    /// </summary>
    class PrimePalindrom
    {
        /// <summary>
        /// Isprimes this instance.
        /// </summary>
        public void Isprime()
        {
            int count = 0, sum = 0, r = 0;
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = n,i;
            for ( i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
            }
                    while (p != 0)
                    {
                        r = p % 10;
                        sum = sum * 10 + r;
                        p = p / 10;

                    }

                    if (sum == p && count == 0)
                    {
                        Console.WriteLine(i);

                    }

                
            
        }
    }
}          
    

