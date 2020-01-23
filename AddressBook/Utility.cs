
using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.AddresBook
{
    class Utility
    {
       

        public static string ReadString()
        {
            return Console.ReadLine();
        }
        
       public static void ChooseOption()
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        Utility.AddPerson();
                        break;
                    //case "remove":
                    //   Utility.Delet();
                    //    break;
                   
                }
            }
        }

        public static void ListPeople()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Choose()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void RemovePerson()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddPerson()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
