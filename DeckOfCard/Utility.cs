// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DackOfCard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.DeckOfCard
{
    /// <summary>
    /// This utility class create for intriducing the all requerd method of DackOfCard distributing between 4 player
    /// 
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Initializes the specified card.
        /// </summary>
        /// <param name="Card">The card.</param>
        /// <param name="Suit">The suit.</param>
        /// <param name="Rank">The rank.</param>
        public static void Initialize(string[,] Card, string[] Suit, string[] Rank)
        {
            //// string[] Suit = { "Club", "Diamond", "Heart", "Spade" };
            ////string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card[i, j] = Suit[i] + "-" + Rank[j];
                }
            }
        }
        /// <summary>
        /// Creats the random.
        /// </summary>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static int CreatRandom(int max)
        {

            Random r = new Random();
            return r.Next(max);

        }
        /// <summary>
        /// Suffles the specified number.
        /// </summary>
        /// <param name="Number">The number.</param>
        public static void Suffle(string[,] Number)
        {
            for (int i = 0; i < 52; i++)
            {
                int row1 = CreatRandom(Number.GetLength(0));
                int col1 = CreatRandom(Number.GetLength(1));
                int row2 = CreatRandom(Number.GetLength(0));
                int col2 = CreatRandom(Number.GetLength(1));
                Swaping(Number, row1, col1, row2, col2);
            }

        }
        /// <summary>
        /// Swapings the specified number.
        /// </summary>
        /// <param name="Number">The number.</param>
        /// <param name="row1">The row1.</param>
        /// <param name="col1">The col1.</param>
        /// <param name="row2">The row2.</param>
        /// <param name="col2">The col2.</param>
        public static void Swaping(String[,] Number, int row1, int col1, int row2, int col2)
        {
            string temp = Number[row1, col1];
            Number[row1, col1] = Number[row2, col2];
            Number[row2, col2] = temp;
        }
        /// <summary>
        /// Distributes the specified card.
        /// </summary>
        /// <param name="Card">The card.</param>
        /// <param name="Player">The player.</param>
        public static void Distribute(String[,] Card, string[,] Player)
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Player[i, j] = Card[i, j];
                }

            }


        }
        /// <summary>
        /// Print2s the d array.
        /// </summary>
        /// <param name="Number">The number.</param>
        public static void Print2DArray(String[,] Number)
        {
            ////enter no of row
            int NoOfRow = Number.GetLength(0);
            ////enter no of culumn
            int NoOfCulumn = Number.GetLength(1);
            for (int i = 0; i < NoOfRow; i++)
            {
                for (int j = 0; j < NoOfCulumn; j++)
                {
                    Console.WriteLine(Number[i, j]);
                }
                Console.WriteLine();
            }
        }



    }
}
