using DesignPatern.SingleTonePatern;
using System;

namespace DesignPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTone obj = SingleTone.MyObject();
            obj.MyMethod();
            SingleTone obj1 = SingleTone.MyObject();
            obj1.MyMethod();
        }
    }
}
