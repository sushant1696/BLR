using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesign
{
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

