// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Temperature.cs" company="Bridgelabz">
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
    /// Temperature is class where IsTemperature is the method
    /// </summary>
    class Temperature
    {
        /// <summary>
        /// Determines whether this instance is temperature.
        /// </summary>
        public void IsTemperature()
        {
            Console.WriteLine("enter the nvalue of c");
            
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the nvalue of f");
            int f= int.Parse(Console.ReadLine());

            //print the out put.
            Console.WriteLine("requered out put are....");
           
            int  cf= (c * 9 / 5) +32;
            Console.WriteLine("temperature in  fahrenheit" + cf);
           
            int  fc=(f-32) * 5 / 9;
            Console.WriteLine("temperature in celcius"+fc);
        }
    }
}
