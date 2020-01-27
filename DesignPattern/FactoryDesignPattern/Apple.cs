using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    public class Apple:Computer
    {
        public override void Charging()
        {
            Console.WriteLine("Apple is now charging !!!");
        }
        public override void NotCharging()
        {
            Console.WriteLine("Apple is not charging !!!");
        }
        public override void Running()
        {
            Console.WriteLine("Apple is now running !!!");
        }
    }
}
