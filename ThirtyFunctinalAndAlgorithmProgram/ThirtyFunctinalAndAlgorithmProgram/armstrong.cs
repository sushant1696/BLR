using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class armstrong
    {
        public static int isangstrom()
        {
            int sum = 0;
          int temp;
            Console.WriteLine("enter the value of n");
            int n=int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
               int rem = n % 10;
                sum =sum + (rem * rem * rem);
                n = n / 10;
            }
            if (temp == sum)
            
                Console.WriteLine("the number is armstrom");
            
            else
            
                Console.WriteLine("the number is not armstrom");
            return 0;//return 0 becouse retun type i have taken int
        }
    }
}
