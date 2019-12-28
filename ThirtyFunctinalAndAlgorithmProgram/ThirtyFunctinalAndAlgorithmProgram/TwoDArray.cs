using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class TwoDArray
    {
        public static void isarray()
        {
            int[,] array = new int[3, 3] ;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0} and {1}",i, j);

                }

                
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}",array[i,j]);
                   // array[i, j] = Convert.ToInt32(Console.ReadLine());


                }

                Console.WriteLine("\n");

            }
        }
    }
}
