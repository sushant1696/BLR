﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.InventoryManagement
{
    class Rice
    {
        /// <summary>
        /// name
        /// </summary>
        private string name;
        /// <summary>
        /// price
        /// </summary>
        private double price;
        /// <summary>
        /// weight
        /// </summary>
        private double weight;
        /// <summary>
        /// get or set of name
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }
        /// <summary>
        /// get or set of price
        /// </summary>
        public double Price { get => this.price; set => this.price = value; }
        /// <summary>
        /// get or set of weight
        /// </summary>
        public double Weight { get => this.weight; set => this.weight = value; }
        public static void IsRice()
        {
            InventoryItemName array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine("name =" + i.Name);
                Console.WriteLine("weight =" + i.Weight);
                Console.WriteLine("Price =" + i.Price);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Inserts the rice.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="price">The price.</param>
        public static void AddRice(string name, double weight, double price)
        {
            InventoryItemName array = Utility.ReadJsonFile();
            Rice obj = new Rice();
            obj.Name = name;
            obj.Weight = weight;
            obj.Price = price;
            array.Rice.Add(obj);
            Utility.WriteJsonFile(array);
        }

        /// <summary>
        /// Updates the rice.
        /// </summary>
        public static void UpdateRice()
        {
            int j = 1;
            InventoryItemName array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine(j++ + "=" + i.Name);
            }

            Console.WriteLine("Enter the item");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            string name = array.Rice[itemNumber - 1].Name;
            foreach (var item in array.Rice)
            {
                if (item.Name != name)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("name = " + item.Name + "\nweight = " + item.Weight + "\nprice per kg =" + item.Price);
                }
            }

            Console.WriteLine("enter 1 to edit rice name");
            Console.WriteLine("enter 2 to edit rice weight");
            Console.WriteLine("enter 3 to edit rice price");

            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("enter a proper choice");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter any new rice name");
                    string newName = Console.ReadLine();
                    array.Rice[itemNumber - 1].Name = newName;
                    break;
                case 2:
                    Console.WriteLine("enter the new weight");
                    double newWeight = Convert.ToInt32(Console.ReadLine());
                    array.Rice[itemNumber - 1].Weight = newWeight;
                    break;
                case 3:
                    Console.WriteLine("enter the new price");
                    double newPrice = Convert.ToInt32(Console.ReadLine());
                    array.Rice[itemNumber - 1].Price = newPrice;
                    break;
            }

            Utility.WriteJsonFile(array);
        }

        /// <summary>
        /// Deletes the rice.
        /// </summary>
        public static void DeleteRice()
        {
            int j = 1;
            InventoryItemName array = Utility.ReadJsonFile();
            foreach (var i in array.Rice)
            {
                Console.WriteLine(j++ + "=" + i.Name);
            }

            Console.WriteLine("Enter the item to delete");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            array.Rice.RemoveAt(itemNumber - 1);
            Utility.WriteJsonFile(array);
        }

    }
}
