using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class HP:Computer
    {
		
        public override void Charging()
        {
            Console.WriteLine("HP is now charging !!!");
        }
        public override void NotCharging()
        {
            Console.WriteLine("HP not charging now !!!");
        }
        public override void Running()
        {
            Console.WriteLine("Now running the HP ");
        }

    }
}
