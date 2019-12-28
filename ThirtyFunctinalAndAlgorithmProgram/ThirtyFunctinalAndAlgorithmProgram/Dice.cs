using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class Dice 
    {
        public void isdice()
        {
            int d1=0, d2=0, d3=0, d4=0, d5=0, d6=0;
            Random rand = new Random();
            int face;
        
        for (int roll = 0; roll <= 100; roll++)
        {
            face =1+rand.Next(6);
            switch (face)
            {
                case 1:
                     d1++;
                    Console.WriteLine("output of 1",+d1);
                    break;
                case 2:
                    d2++;
                    Console.WriteLine(d2);
                    break;
                case 3:
                    d3++;
                    Console.WriteLine(d3);
                    break;
                case 4:
                    d4++;
                    Console.WriteLine(d4);
                    break;
                case 5:
                    d5++;
                    Console.WriteLine(d5);
                    break;
                case 6:
                    d6++;
                    Console.WriteLine(d6);
                    break;
            }
        }

            
        }
    }
}
