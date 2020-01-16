using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagement
{
   public class Manu
    {
        public static void IsManu()
        {
            Console.WriteLine("Select an category");
            Console.WriteLine("1for Rice\n 2 for Wheat\n 3for Pulse");
            int category =Convert.ToInt32(Console.ReadLine());
           

            switch (category)
            {
                case 1:
                    Rice.IsRice();
                    break;
                case 2:
                    Wheat.IsWheat();
                    break;
                case 3:
                    Pulse.IsPulse();
                    break;
                default:
                    break;
            }

            Console.WriteLine("select a operation to perform");
            Console.WriteLine("1.Add\n2.Update\n3.Delete");
            int operation = Convert.ToInt32(Console.ReadLine());
            while (operation != 1 && operation != 2 && operation != 3)
            {
                Console.WriteLine("operation dosent exist");
                operation = Convert.ToInt32(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    Action.Insert(category);
                    break;
                case 2:
                    Action.Update(category);
                    break;
                case 3:
                    Action.Delete(category);
                    break;
                default:
                    break;
            }
        }
    }
    
}
