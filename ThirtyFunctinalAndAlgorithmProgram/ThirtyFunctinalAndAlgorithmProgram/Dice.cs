// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Dice.cs" company="Bridgelabz">
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
    /// Dice is class where IsDice is the method
    /// </summary>
    class Dice 
    {
        /// <summary>
        /// Determines whether this instance is dice.
        /// </summary>
        public void IsDice(int max)
        {
            int d1=0, d2=0, d3=0, d4=0, d5=0, d6=0;
            Random rand = new Random();
            int face;
        
        for (int roll = 0; roll <= max; roll++)
        {
            face =1+rand.Next(6);
            switch (face)
            {
                case 1:
                     d1++;
                   
                    break;
                case 2:
                    d2++;
                   
                    break;
                case 3:
                    d3++;
                    
                    break;
                case 4:
                    d4++;
                 
                    break;
                case 5:
                    d5++;
                 
                    break;
                case 6:
                    d6++;
                   
                    break;
            }
        }
            Console.WriteLine("the out comes result are");
            Console.WriteLine("the face 1 come:\t "+ d1+"timrs\t,"+"face 2:\t" +d2+"times\t,"+"face 3:\t " +d3+ "times\t,"+ "face 4:\t"+d4+ "times\t," + "face 5:\t" +d5+"times\t,"+"face 5:\t " +d6+"times\t,");

            Console.WriteLine("out put are in percentage: " + d1*100/max + ":" + d2*100/max + ":" + d3*100/max + ":" + d4*100/max + ":" + d5*100/max + ":" + d6);
        }
    }
}
