using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPattern
{
  public class RealSubject:ISubject

    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
