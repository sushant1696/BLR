using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPattern
{
   public class clients
    {
        
           
            public void ClientProxyMethod(ISubject sub)
            {
         

                sub.Request();

                
            }
        
    }
}
