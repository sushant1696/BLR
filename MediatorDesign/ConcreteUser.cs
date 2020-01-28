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
    /// create a class whic inherit the User class
    /// this class impliment the two method of User class
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesign.User" />
    public class ConcreteUser:User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }
            public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }

    }
}
