// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StopWatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// StopWatch is a class where Main is method for invoked  by main method
    /// </summary>
    class StopWatch
    {

        /// <summary>
        /// Defines the entry point of the application.
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

