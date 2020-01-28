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
    class SubSystem1
    {
        /// <summary>
        /// Operation1s this instance.
        /// </summary>
        /// <returns></returns>
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }
        /// <summary>
        /// Operations the n.
        /// </summary>
        /// <returns></returns>
        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}
