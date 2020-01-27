using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class Accer : Computer
    {
        public override void Charging()
        {
            Console.WriteLine("charging the Accer !!!");
        }
        public override void NotCharging()
        {
            Console.WriteLine("charging the Accer !!!");
        }
        public override void Running()
        {
            Console.WriteLine("running the Accer !!!");
        }
    }	
}
