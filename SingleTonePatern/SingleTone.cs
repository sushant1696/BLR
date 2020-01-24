// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Singletone.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatern.SingleTonePatern
{
    /// <summary>
    /// Creat a class named Singletone of dwsign patern
    /// </summary>
    sealed class SingleTone
    {
        public static int count = 0;
        public static SingleTone Instance;
        private SingleTone()
        {
            count++;
            Console.WriteLine(count);
        }

        /// <summary>
        /// Mies the object.
        /// </summary>
        /// <returns></returns>
        public static SingleTone MyObject()
        {
            if (Instance == null)
            {
                return new SingleTone();
            }
            return Instance;
        }
        /// <summary>
        /// Mies the method.
        /// </summary>
        public void MyMethod()
        {
            Console.WriteLine("this my method");
        }
    }
}
