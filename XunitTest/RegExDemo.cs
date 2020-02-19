using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UnitTest
{
   public class RegexDemo
    {
        public static string PhoneNumber(string PhonNo)
        {
            string pattern = @"^([\d]+){10}$";
            Regex rx = new Regex(pattern);
           if(rx.IsMatch(PhonNo))
            {
                return PhonNo;
            }
            else
            {
                return null;
            }
        }
        public static string FirstName(string fname)
        {
            string pattern = "^[A-Z]{1}[a-zA-Z]*$";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(fname))
            {
                return fname;
            }
            else
            {
                return null;
            }
        }
        public static string LastName(string lname)
        {
            string pattern = "^[A-Z]{1}[a-zA-Z]*$";
            Regex rgx1 = new Regex(pattern);
            if (rgx1.IsMatch(lname))
            {
                return lname;
            }
            else
            {
                return null;
            }
        }
        public static string Email(string eml)
        {
            string pattern2=@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[com]{3}$";
            Regex rgx = new Regex(pattern2);
            if (rgx.IsMatch(eml))
            {
                return eml;
            }
            else
            {
                return null;
            }
        }
        public static string Password(string pswd)
        {
            string pattern = @"^[a-z,A-Z,0-9,#%^*]{8,}]]$";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(pswd))
            {
                return pswd;
            }
            else
            {
                return null;
            }
        }

    }
}
