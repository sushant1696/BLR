using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesign
{
    /// <summary>
    /// create a ISocketVolt interface
    /// </summary>
    interface ISocketVolt
    {
        /// <summary>
        /// creat a method to get 220 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get220Volts();
        /// <summary>
        /// creat a method to get 320 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get320Volts();
        /// <summary>
        /// creat a method to get 50 votltage
        /// </summary>
        /// <returns></returns>
        public Voltsc Get50Volts();
    }
}
