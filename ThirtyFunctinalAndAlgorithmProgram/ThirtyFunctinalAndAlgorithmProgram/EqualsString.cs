using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class EqualsString
    {
        public bool isequal()
        {
            Console.WriteLine("enter 1st  string");
            String s1 = Console.ReadLine();
            Console.WriteLine("enter 2nd  string");
            String s2 = Console.ReadLine();
            if (s1 == null || s2 == null)
            { 
                   return false;
             }
             if (s1.Length! == s2.Length)
            {
                return false;
            }
             if(s1.Equals(s2))
            {
                return false;
            }
            

                return true;
            
            
                
        }
    }
}
