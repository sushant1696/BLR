using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern2
{
    /// <summary>
    /// Adapter class adapted one interface (IDotpen) and a class (colorpen) 
    /// </summary>
    public class Adapter : IDotPen
    {
        /// <summary>
        /// create a instance variable to calling the color pen method
        /// </summary>
        public ColorPen _colorpen;
        public Adapter(ColorPen colorpen)
        {
            this._colorpen = colorpen;
        }
        public void write()
        {
            Console.WriteLine("pen writing something");
            ///invoke color pen method by _color pen 
            _colorpen.colorPenWrite();
        }
    }
}
