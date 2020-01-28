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
    /// create a voltsc class 
    /// </summary>
    public class Voltsc
    {
        /// <summary>
        /// The volt
        /// </summary>
        public int volt;
        /// <summary>
        /// default constractor
        /// </summary>
/        public Voltsc()
        {
            this.volt = 220;
        }
        /// <summary>
        /// parameterize constractor
        /// </summary>
        /// <param name="volt"></param>
        public Voltsc(int voltt)
        {
            this.volt = voltt;
        }
        /// <summary>
        /// get method
        /// </summary>
        /// <returns></returns>
        public int GetVolts()
        {
            return this.volt;
        }
        /// <summary>
        /// set method
        /// </summary>
        /// <param name="volt"></param>
        public void SetVolts(int volt)
        {
            this.volt = volt;
        }
    }
}
