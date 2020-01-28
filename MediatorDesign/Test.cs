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
    class Test
    {
        public static void TestMethod()
        {
            FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
            User Dave = new ConcreteUser(facebookMediator, "Dave");
            User Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
            User Sam = new ConcreteUser(facebookMediator, "Sam");
            User Pam = new ConcreteUser(facebookMediator, "Pam");
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            Rajesh.Send("What is Design Patterns? Please explain ");

        }
    }
}
