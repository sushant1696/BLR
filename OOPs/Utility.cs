using Newtonsoft.Json;
using OOPs.InventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOPs
{
    class Utility
    {
        public static InventoryItemName ReadJsonFile()
        {
            if (File.Exists(@"C:\Users\user\source\repos\OOPs\InventoryManagement\InventoryJsonItem.json"))
            {
                string files = File.ReadAllText(@"C:\Users\user\source\repos\OOPs\InventoryManagement\InventoryJsonItem.json");
                InventoryItemName array = JsonConvert.DeserializeObject<InventoryItemName>(files);
                return array;
            }
            else
            {
                Console.WriteLine("path does not exist");
                return new InventoryItemName();
            }
        }

        /// <summary>
        /// Writes the json file.
        /// </summary>
        /// <param name="file">The file.</param>
        public static void WriteJsonFile(InventoryItemName file)
        {
            string json = JsonConvert.SerializeObject(file);
            File.WriteAllText(@"C:\Users\user\source\repos\OOPs\InventoryManagement\InventoryJsonItem.json", json);
        }
       
    }
}
