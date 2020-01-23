using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagement
{
    class Display
    {
        public void IsDisplay()
        {
            Manu.IsManu();
            Action.Print();
            Console.WriteLine("do you want to exit(y/n)");
            string obj2 = Console.ReadLine();

            ////Repeating the function again
            while (obj2 == "Y" || obj2 == "N")
            {
                Manu.IsManu();
                Console.WriteLine("do you want to exit(y/n)");
                obj2 = Console.ReadLine();
            }
        }
    }
}
