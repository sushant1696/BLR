// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrototypeDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// ----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesign
{
    /// <summary>
    /// create a class named IdInfo
    /// </summary>
    public class IdInfo
    {
        public int IdNumber;
        /// <summary>
        /// create constractor
        /// </summary>
        /// <param name="idNumber"></param>
        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}

