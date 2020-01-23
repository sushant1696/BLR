using Newtonsoft.Json;
using System;
using System.IO;

namespace OPPS.StockAccountManagement
{
    class Utility
    {
        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <returns></returns>
        public static CompanyName ReadJsonFile()
        {

            if (File.Exists(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\StockAccountManagement\CompanyInJsonFile.json"))
            {
                string files = string.Empty;
                try
                {
                    files = File.ReadAllText(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\StockAccountManagement\CompanyInJsonFile.json");

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                CompanyName array = JsonConvert.DeserializeObject<CompanyName>(files);
                    return array;
            }


            else
            {
                Console.WriteLine("path does not found");
                return new CompanyName();
            }

        }
            
            /// <summary>
            /// Writes the json file.
            /// </summary>
            /// <param name="ser">The ser.</param>
            public static void WriteJsonFile(CompanyName serialize)
            {
                string json = JsonConvert.SerializeObject(serialize);

                ////File is a static class that provides different functionalities like copy,
                ///create, move, delete, open for reading or /writing, encrypt or decrypt, 
                ///check if a file exists, append lines or text to a file’s content, get last access time, etc.
                File.WriteAllText(@"C:\Users\Bridgelabz\source\repos\OPPS\OPPS\StockAccountManagement\CompanyInJsonFile.json", json);
            }

        }
    } 
