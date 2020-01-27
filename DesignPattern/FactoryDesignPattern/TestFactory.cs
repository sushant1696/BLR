using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class TestFactory
    {
        public static void IsFactory()
        {
            Console.WriteLine("enter computer type");
            string type = Console.ReadLine();
            Computer obj = ComputerFactory.IsComputerFactory(type);
            if (obj != null)
            {
               
                obj.Charging();
                
                obj.NotCharging();
            
                obj.Running();
            }
            else
            {
                
                Console.WriteLine("enter a valid computer type");
            }
        }
    }
}
