// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Anagram.cs" company="Bridgelabz">
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
    /// Anagram is class where isAnagram is the method of Anagram class.
    /// </summary>
    class Anagram
    {
        /// <summary>
        /// Determines whether this instance is anagram.
        /// </summary>
       public void isAnagram()
        {
            // string s1 = "abcd";
            // string s2 = "cdab";
            Console.WriteLine("enter the 1st string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter the 2nd string");
            string s2 = Console.ReadLine();
            //conver the string into character form and lower case 
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string sr1 = new string(ch1);
            string sr2 = new string(ch2);
            //check both the string equal or not
            if (sr1 == sr2)
            {
                Console.WriteLine("yes.....  both of string are anagram");

            }
            else
            {
                Console.WriteLine("sorry two string are not anagram");

            }
        }
    }
}
