using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class ComputerFactory
    {
        public static Computer IsComputerFactory(string type)
        {
            
            if (type.Equals("Accer"))
                return new Accer();
            else if (type.Equals("Apple"))
                return new Apple();
            else if (type.Equals("HP"))
                return new HP();
            else
                return null;
        }
    }
}
