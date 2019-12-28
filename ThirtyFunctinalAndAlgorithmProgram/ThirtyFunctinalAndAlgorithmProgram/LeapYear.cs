using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class LeapYear
    {
        public void isleap()
        {
            int year;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());
            if(year%4==0 && year % 400==0)
            {
                Console.WriteLine("the year is leap year");
            }
            else
            {
                Console.WriteLine("the year is not a leap year");
            }
        }
    }
}
