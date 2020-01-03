// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Gambler.cs" company="Bridgelabz">
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
    /// Gambler is a class where IsGambler is a method
    /// </summary>
    class Gambler
    {
        /// <summary>
        /// Determines whether this instance is gambler.
        /// </summary>
        public void IsGambler()
        {
            //input from the user
            Console.WriteLine("enter the no of stack");
            int stack=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of goals");
            int goal= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of trial");
            int trial= int.Parse(Console.ReadLine());
            int bets = 0;//total no of bets made
            int wins = 0;//total no of wine

            //repeat no of trials
            for (int t = 0; t < trial; t++)
            {
               
                int cash = stack;
                
                while(cash>0 && cash < goal)
                {
                    bets++;
                    Random random = new Random();
                    if (random.Next() < 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }

                }
                if (cash == goal)
                    wins++;
            }
            //print the result
            Console.WriteLine(wins + "wins of" + trial);
            Console.WriteLine("percentage of game winner "+ 100*wins/trial );
            Console.WriteLine("average of bets"+1.0*bets/trial);



        }
    }
}
