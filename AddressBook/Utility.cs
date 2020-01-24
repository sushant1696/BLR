
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OPPS.AddresBook
{
    class Utility
    {

        public static PersonList ReadJsonFile()
        {
            if (File.Exists(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\AddressBook\json1.json"))
            {
                string files = File.ReadAllText(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\AddressBook\json1.json");
                PersonList array = JsonConvert.DeserializeObject<PersonList>(files);
                return array;
            }
            else
            {
                Console.WriteLine("path does not found");
                return new PersonList();
            }
        }

        /// <summary>
        /// Writes the json file.
        /// </summary>
        /// <param name="file">The file.</param>
        public static void WriteJsonFile(PersonList file)
        {
            string json = JsonConvert.SerializeObject(file);
            File.WriteAllText(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\AddressBook\json1.json", json);
        }

    }
}
