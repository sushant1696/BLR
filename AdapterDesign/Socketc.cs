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
    /// create a Socket class 
    /// </summary>
    public class Socketc
    {
        /// <summary>
        /// The voltage
        /// </summary>
        public Voltsc voltage;
        /// <summary>
        /// Initializes a new instance of the <see cref="Socketc"/> class.
        /// </summary>
        public Socketc()
        {
            voltage = new Voltsc();
        }
        public Socketc(int volt)
        {
            voltage = new Voltsc(volt);//// paramiterazige constractor assign to voltage
        }
        public Voltsc GetSocket()
        {
            return this.voltage;
        }
    }
}
