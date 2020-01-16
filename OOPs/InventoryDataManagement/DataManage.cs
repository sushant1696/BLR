using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace OOPs.InventoryDataManagement
{
    class DataManage
    {
        public void IsDataManage() {
            StreamReader f = new StreamReader(@"C:\Users\user\source\repos\OOPs\InventoryDataManagement\JsonItem.json");
            var j = f.ReadToEnd();
            var fs = JsonConvert.DeserializeObject<List<InventoryGetSet>>(j);
            foreach (var item in fs)
            {
                Console.WriteLine("name = " + item.Name + "\n weight = " + item.Weight + "\n price per kg =" + item.Price);
                Console.WriteLine();
            }
        }
    }
}
                                                                                                                                                     