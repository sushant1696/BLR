﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
///This class creat for Euclidean distance from the point (x, y) to the origin (0, 0)
///where IsDistance is the method
/// </summary>
    class Distance
    {
        /// <summary>
        /// Isdistances this instance.
        /// method creat for calling by main method.
        /// </summary>
        public void IsDistance()
        {
            Console.WriteLine("enter the value of  x :");

           double x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value o of y: ");
            double y = double.Parse(Console.ReadLine());

            //print the out put
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("requerd distance is =" + distance);

        }

    }
}
