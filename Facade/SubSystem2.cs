// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FacadeDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    ///Create a Subsystem2 class
    /// </summary>
    class SubSystem2
    {
        /// <summary>
        /// Operation1s this instance.
        /// </summary>
        /// <returns></returns>
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }
        /// <summary>
        /// Operations the z.
        /// </summary>
        /// <returns></returns>
        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }

}   }
