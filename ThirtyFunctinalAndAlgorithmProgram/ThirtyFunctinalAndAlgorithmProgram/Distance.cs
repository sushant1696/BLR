using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{/// <summary>
///This class creat for Euclidean distance from the point (x, y) to the origin (0, 0)
/// </summary>
    class Distance
    {
        /// <summary>
        /// Isdistances this instance.
        /// method creat for calling by main method.
        /// </summary>
        public void isdistance()
        {
            Console.WriteLine("enter the value of  x :");

           double x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value o of y: ");
            double y = double.Parse(Console.ReadLine());

            //print the out put
            double distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("requerd distance is =" + distance);

        }

    }
}
