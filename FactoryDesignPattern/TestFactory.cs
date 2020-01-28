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
    /// Create a class named TestFactory
    /// </summary>
    class TestFactory
    {
        public static void IsFactory()
        {
            Console.WriteLine("enter computer type");
            string type = Console.ReadLine();
            Computer obj = ComputerFactory.IsComputerFactory(type);
            if (obj != null)
            {
               
                obj.Charging();
                
                obj.NotCharging();
            
                obj.Running();
            }
            else
            {
                
                Console.WriteLine("enter a valid computer type");
            }
        }
    }
}
