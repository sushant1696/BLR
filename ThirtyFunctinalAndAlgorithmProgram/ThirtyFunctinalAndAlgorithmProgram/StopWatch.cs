using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
namespace ThirtyFunctinalAndAlgorithmProgram
{
    class StopWatch
    {

        /// <summary>
        /// Shis class created for the stopwatch.To measured the elapsed time.
        /// "System.Diagnostics" 
        /// namespace at the top. This is where the Stopwatch class is
        /// defined in the Framework.ry point of the application.
        /// </summary>
        public void Main()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}

