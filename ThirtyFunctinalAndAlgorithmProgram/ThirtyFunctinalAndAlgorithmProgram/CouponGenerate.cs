// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CouponGenerate.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// CouponGenerate is a class where isCoupon is a method
    /// </summary>
    class CouponGenerate
    {

        /// <summary>
        /// Determines whether the specified maximum is coupon.
        /// </summary>
        /// <param name="max">The maximum.</param>
        public void isCoupon(int max)
        {

             string coup = " ";
             Random random = new Random();

             for (int i = 0; i < max; i++)
             {

                    string coupon = random.Next( max).ToString();

                     coup = coupon + "," + coup;


             }
             Console.WriteLine("generated coupon are:" + coup);
             Console.WriteLine("\t");


            
           
        }
        

    }
}
