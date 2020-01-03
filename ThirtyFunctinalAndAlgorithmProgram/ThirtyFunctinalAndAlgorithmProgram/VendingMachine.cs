// --------------------------------------------------------------------------------------------------------------------
// <copyright file=VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    /// <summary>
    /// VendingMachine is class where IsMachine is the method
    /// </summary>
    class VendingMachine
    {
        /// <summary>
        /// Determines whether the specified amount is machine.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void IsMachine(int amount)
        {
            int notes=0;
            Console.WriteLine("amount is :"+amount);
            if (amount == 0)
            {
                return;
            }
            //count of 1000 rs notes
            if (amount >= 1000)
            {
                notes += amount/1000;
                Console.WriteLine("no of 1000 rs notes are:"+notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 1000);

            }
            else if (amount >= 500)
            {
                notes += amount / 500;
                Console.WriteLine("no of 500 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 500);
            }
            else if (amount >= 200)
            {
                notes += amount / 200;
                Console.WriteLine("no of 200 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 200);
            }
            else if (amount >= 100)
            {
                notes += amount / 100;
                Console.WriteLine("no of 100 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 100);
            }
            else if (amount >= 50)
            {
                notes += amount / 50;
                Console.WriteLine("no of 50 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 50);
            }
            else if (amount >= 20)
            {
                notes += amount / 20;
                Console.WriteLine("no of 20 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 20);
            }
            else if (amount >= 100)
            {
                notes += amount / 10;
                Console.WriteLine("no of 10 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 10);
            }
            else if (amount >= 5)
            {
                notes += amount / 5;
                Console.WriteLine("no of 5 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 5);
            }
            else if (amount >= 2)
            {
                notes += amount / 2;
                Console.WriteLine("no of 2 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 2);
            }
            else if  (amount >= 1)
            {
                notes += amount / 1;
                Console.WriteLine("no of 1 rs notes are:" + notes);
                if (amount == 0)
                    return;
                else
                    IsMachine(amount % 1);
            }
        }
    }
}
