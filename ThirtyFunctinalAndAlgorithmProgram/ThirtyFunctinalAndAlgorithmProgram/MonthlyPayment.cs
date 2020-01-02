using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
/// This class creat for monthly payment with compound interest.
/// 
/// </summary>
    class MonthlyPayment
    {
        public void ispayment(double P,int Y,double R)
        {
            //int n = int.Parse(Console.ReadLine());
           int n = Y*12;
            Console.WriteLine("n =" + n);
            double r= R / (12 * 100);
            Console.WriteLine("r =" + r);
            double pmt = (P * r) / (Math.Pow(1 - (1 + r), -n));
            Console.WriteLine("monthly payment is =" + pmt);
        }
        

    }
}
