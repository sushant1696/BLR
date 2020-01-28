// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FactoryDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// /create a class named Accer which inherit the Computer superclass
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Computer" />
    class Accer : Computer
    {
        /// <summary>
        /// Chargings this instance.
        /// </summary>
        public override void Charging()
        {
            Console.WriteLine("charging the Accer !!!");
        }
        /// <summary>
        /// Nots the charging.
        /// </summary>
        public override void NotCharging()
        {
            Console.WriteLine("charging the Accer !!!");
        }
        /// <summary>
        /// Runnings this instance.
        /// </summary>
        public override void Running()
        {
            Console.WriteLine("running the Accer !!!");
        }
    }	
}
