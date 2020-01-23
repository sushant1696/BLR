using OOPs.InventoryDataManagement;
using OOPs.InventoryManagement;
using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice");
            Console.WriteLine("1-> json read write");
            Console.WriteLine("2-> Inventory Management ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    DataManage dm = new DataManage();
                    dm.IsDataManage();
                    break;
                case 2:
                    Display ob = new Display();
                    ob.IsDisplay();
                    break;
            }
        }
    }
}
