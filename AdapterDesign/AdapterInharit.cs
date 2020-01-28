// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterDesignPtern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesign
{
    /// <summary>
    /// Creat a AdapterInharit Class to impliment the interface 
    /// </summary>
    /// <seealso cref="DesignPattern.AdapterDesign.Socketc" />
    /// <seealso cref="DesignPattern.AdapterDesign.ISocketVolt" />
    class AdapterInharit : Socketc, ISocketVolt
    {
        /// <summary>
        /// Converts the volts.
        /// </summary>
        /// <param name="volt">The volt.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public Voltsc ConvertVolts(Voltsc volt, int i)
        {
            return new Voltsc(volt.GetVolts() / i);
        }
        /// <summary>
        /// creat a method to get 220 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get220Volts()
        {
            return new Voltsc();
        }
        /// <summary>
        /// creat a method to get 320 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get320Volts()
        {
            Voltsc voltobj = new Voltsc();
            return ConvertVolts(voltobj, 2);
        }
        /// <summary>
        /// creat a method to get 50 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get50Volts()
        {
            Voltsc voltobj = new Voltsc();
            return ConvertVolts(voltobj, 40);
        }
    }


}

