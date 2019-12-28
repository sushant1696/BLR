using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class DecimalToBinary
    {
        public void isbinary()
        {
            int[] rem = new int[10];
            //string rem = " ";
          int index = 0;
            int n = 16;
            while (n > 0)
            {
                rem[index] = n % 2;
                index++;
                n =n / 2;
                Console.WriteLine(rem[index]);
            }

            /*for( index = 0; n>0; index++)
            {
                String rem1 = (n % 2).ToString();
              rem=rem+ ""+rem1;
                n = n / 2;
            }*/

            for(int i = (index - 1); i > 0; i--)
            {
                Console.Write(rem[i]);
            }
        }
    }
}
