using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class SquareRoot
    {
        public static void issquare()
        {
            double delta = 0, a = 1, b = 3, c = 5,r1,r2;
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                r1 = -b + (Math.Sqrt(delta)) / 2 * a;
                r2 = -b - (Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine(r1);
                Console.WriteLine(r1);
            }
            else if (delta == 0)
            {
                r1 = -b / 2 * a;
                r2 = -b / 2 * a;
                Console.WriteLine(r1);
            }
            else
            {
                double real = -b / 2 * a;
                double img = Math.Sqrt(-delta) / 2 * a;
                Console.WriteLine(real);
                Console.WriteLine(img);
            }
                    
        }
    }
}
