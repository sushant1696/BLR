// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
/// This class creat for monthly payment with compound interest where
/// Ispayment is the method.
/// </summary>
    class MonthlyPayment
    {
        /// <summary>
        /// Ispayments the specified p.
        /// </summary>
        /// <param name="P">The p.</param>
        /// <param name="Y">The y.</param>
        /// <param name="R">The r.</param>
        public void Ispayment(double P,int Y,double R)
        {
            //int n = int.Parse(Console.ReadLine());
           int n = Y*12;
            Console.WriteLine("n =" + n);
            double r= R / (12 * 100);
            Console.WriteLine("r =" + r);
            double pmt = (P * r) / (Math.Pow(1 - (1 + r), -n));
            Console.WriteLine("monthly payment is =" + pmt);
        }
        

    }
}
