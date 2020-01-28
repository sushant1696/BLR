// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediatorDesignPtern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ----------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorDesign
{
    /// <summary>
    /// create a abstract class which have two abstract method
    /// send and Receive
    /// </summary>
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;
        public User(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
