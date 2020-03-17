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
    /// create a class ,this class impliment the FacebookGroupMediator 
    /// abrtact method
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesign.FacebookGroupMediator" />
    class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> usersList = new List<User>();
        /// <summary>
        /// Registers the user.
        /// Register user Resgistered the user 
        /// </summary>
        /// <param name="user">The user.</param>
        
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }
        /// <summary>
        /// Sends the message.
        /// all the message distribute by the SendMessage method to all user
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }

        }      }
    }
