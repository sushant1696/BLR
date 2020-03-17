using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPattern
{
    class Final
    {
        public static void FinalMethod()
        {
            clients clintobj = new clients();

            Console.WriteLine(" Executing the client code with a real subject:");
            RealSubject obj = new RealSubject();
            clintobj.ClientProxyMethod(obj);

            Console.WriteLine();

            Console.WriteLine("Executing the same client code with a proxy:");
            Proxy obj2 = new Proxy(obj);
            clintobj.ClientProxyMethod(obj2);
        }
    }
}
