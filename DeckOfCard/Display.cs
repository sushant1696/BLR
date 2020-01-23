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
    /// This class is created for displaying the all out put among the player
    /// where Dislay is the class and IsDisplay is the method
    /// </summary>
    class Display
    {
        public  void IsDisplay()
        {
            string[,] Card = new string[4, 13];
            string[,] Number = new string[4, 13];
            string[] Suit = { "Club", "Diamond", "Heart", "Spade" };
            string[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            Utility.Initialize(Card, Suit, Rank);
            Utility.Suffle(Card);
            Utility.Distribute(Card, Number);
            Utility.Print2DArray(Number);

        }
    }
}
