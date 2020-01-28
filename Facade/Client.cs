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
    /// 
    // The client code works with complex subsystems through a simple
    // interface provided by the Facade. When a facade manages the lifecycle
    // of the subsystem, the client might not even know about the existence
    // of the subsystem. This approach lets you keep the complexity under
    // control.
    /// </summary>
    class Client
    {
        /// <summary>
        /// Clients the method.
        /// </summary>
        /// <param name="facobj">The facobj.</param>
        public static void ClientMethod(Facade facobj)
        {
            Console.Write(facobj.FacadeOperationMethod());
        }
    }
}
