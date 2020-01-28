// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FactoryDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// create a class HP whic inharite the Computer class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Computer" />
    class HP :Computer
    {
        /// <summary>
        /// Chargings this instance.
        /// </summary>
        public override void Charging()
        {
            Console.WriteLine("HP is now charging !!!");
        }
        /// <summary>
        /// Nots the charging.
        /// </summary>
        public override void NotCharging()
        {
            Console.WriteLine("HP not charging now !!!");
        }
        /// <summary>
        /// Runnings this instance.
        /// </summary>
/        public override void Running()
        {
            Console.WriteLine("Now running the HP ");
        }

    }
}
