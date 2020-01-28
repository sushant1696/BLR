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
    /// Create a class named Facade whic facad the all subsystem
    /// </summary>
    class Facade
    {
        private SubSystem1 subsys1;

        private SubSystem2 subsys2;
        /// <summary>
        /// Initializes a new instance of the <see cref="Facade"/> class.
        /// </summary>
        /// <param name="subsys1">The subsys1.</param>
        /// <param name="subsys2">The subsys2.</param>
        public Facade(SubSystem1 subsys1, SubSystem2 subsys2)
        {
            this.Subsys1 = subsys1;
            this.Subsys2 = subsys2;
        }

        internal SubSystem1 Subsys1 { get => this.subsys1; set => this.subsys1 = value; }
        internal SubSystem2 Subsys2 { get => this.subsys2; set => this.subsys2 = value; }
        /// <summary>
        /// Facades the operation method.
        /// </summary>
        /// <returns></returns>
        public string FacadeOperationMethod()
        {
            string result = "Facade initializes subsystems:\n";
            result += this.Subsys1.operation1();
            result += this.Subsys2.operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this.Subsys1.operationN();
            result += this.Subsys2.operationZ();
            return result;
        }
    }
}
