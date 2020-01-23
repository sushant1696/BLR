using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagement
{
    class Action
    {
        /// <summary>
        /// Inserts the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public static void Insert(int category)
        {
            Console.WriteLine("enter name");
            string name =Console.ReadLine();
            Console.WriteLine("enter weight");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter price per kg");
            double price = Convert.ToInt32(Console.ReadLine());
            if (category == 1)
            {
                Rice.AddRice(name, weight, price);
            }
            else if (category == 2)
            {
                Wheat.AddWheat(name, weight, price);
            }
            else if (category == 3)
            {
                Pulse.AddPulse(name, weight, price);
            }

            Console.WriteLine("item is added");
        }

        /// <summary>
        /// Updates the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public static void Update(int category)
        {
            if (category == 1)
            {
                Rice.UpdateRice();
            }
            else if (category == 2)
            {
                Wheat.UpdateWheat();
            }
            else if (category == 3)
            {
                Pulse.UpdatePulse();
            }
        }

       /// <summary>
       /// deleting process
       /// </summary>
       /// <param name="category"></param>
        public static void Delete(int category)
        {
            if (category == 1)
            {
                Rice.DeleteRice();
            }
            else if (category == 2)
            {
                Wheat.DeleteWheat();
            }
            else if (category == 3)
            {
                Pulse.DeletePulse();
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public static void Print()
        {
            InventoryItemName array = Utility.ReadJsonFile();
            Console.WriteLine("Rice:");
            foreach (var i in array.Rice)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }

            Console.WriteLine("Wheat:");
            foreach (var i in array.Wheat)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }

            Console.WriteLine("Pulse:");
            foreach (var i in array.Pulse)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
            }
        }
    }
}
