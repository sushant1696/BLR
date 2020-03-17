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
    /// create a class named Person
    /// </summary>
    public class Person
    {
        public int age;
        public DateTime Date;
        public string Name;
        public IdInfo Idinfo;
        /// <summary>
        /// Shallows the copy.
        /// </summary>
        /// <returns></returns>
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public Person DeepCopy()
        {
          Person clone = (Person)this.MemberwiseClone();
            clone.Idinfo = new IdInfo(Idinfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }
        
    }
}
