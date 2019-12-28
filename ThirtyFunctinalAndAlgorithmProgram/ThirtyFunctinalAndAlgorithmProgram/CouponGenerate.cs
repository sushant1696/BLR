using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ThirtyFunctinalAndAlgorithmProgram
{
    class CouponGenerate
    {
        
        
        public void iscoupon(int max)
        {

             string coup = " ";
             Random random = new Random();

             for (int i = 0; i < max; i++)
             {

                    string coupon = random.Next( max).ToString();

                     coup = coupon + "," + coup;


             }
             Console.WriteLine("generated coupon are:" + coup);
             Console.WriteLine("\t");


            
           
        }
        

    }
}
