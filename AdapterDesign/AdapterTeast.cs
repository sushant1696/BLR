// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterDesignPtern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesign
{
    /// <summary>
    /// create a Adapter test class
    /// </summary>
    class AdapterTeast
    {
        /// <summary>
        /// Adapters the test method.
        /// </summary>
        public static void AdapterTestMethod()
        {
            AdapterInharit obj = new AdapterInharit();
            Voltsc volt220obj = obj.Get220Volts();
            Voltsc volt320obj = obj.Get320Volts();
            Voltsc volt50obj = obj.Get50Volts();
            ////print all the values
            Console.WriteLine(" volts : " + volt50obj.GetVolts());
            Console.WriteLine(" volts : " + volt220obj.GetVolts());
            Console.WriteLine(" volts : " + volt320obj.GetVolts());
        }
    }
}
