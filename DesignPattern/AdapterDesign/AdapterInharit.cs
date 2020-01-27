using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesign
{
    class AdapterInharit : ISocketVolt,Socketc
    {
        public Voltsc Get220Volts()
        {
            return new Voltsc();
        }
        public Voltsc Get110Volts()
        {
            Voltsc volt = new Voltsc();
            return ConvertVolts(volt, 2);
        }
    }


}

