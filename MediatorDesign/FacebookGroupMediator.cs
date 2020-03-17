// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MediatorDesignPtern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MediatorDesign
{
    /// <summary>
    /// create a interface which have two abstrac method SendMessage
    /// and RegisterUser
    /// </summary>
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
