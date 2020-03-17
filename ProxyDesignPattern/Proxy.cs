using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPattern
{
   public class Proxy:ISubject
    {
        private RealSubject realSub;
        public Proxy(RealSubject realSubject)
        {
            this.realSub = realSubject;
        }
        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access  real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
        public void Request()
        {
            if (this.CheckAccess())
            {
                this.realSub = new RealSubject();
                this.realSub.Request();

                this.LogAccess();
            }
        }
    }
}

