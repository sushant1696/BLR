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
    /// create a class named ComputerFactory
    /// </summary>
    class ComputerFactory
    {
        /// <summary>
        /// Determines whether [is computer factory] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static Computer IsComputerFactory(string type)
        {
            
            if (type.Equals("Accer"))
                return new Accer();
            else if (type.Equals("Apple"))
                return new Apple();
            else if (type.Equals("HP"))
                return new HP();
            else
                return null;
        }
    }
}
