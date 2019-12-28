using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
/// this class created for to calculate the temperature in the form of 
/// celsious or fahrenheit
/// </summary>
    class Temperature
    {
        /// <summary>
        /// Istemperatures this instance.
        /// mathod creat for calling by main method.
        /// </summary>
        public void istemperature()
        {
            Console.WriteLine("enter the nvalue of c");
            
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the nvalue of f");
            int f= int.Parse(Console.ReadLine());

            //print the out put.
            Console.WriteLine("requered out put are....");
           
            int  cf= (c * 9 / 5) +32;
            Console.WriteLine("temperature in  fahrenheit" + cf);
           
            int  fc=(f-32) * 5 / 9;
            Console.WriteLine("temperature in celcius"+fc);
        }
    }
}
