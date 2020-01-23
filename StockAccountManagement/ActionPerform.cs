using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    class ActionPerform
    {
        public static void Insert(int category)
        {
            Console.WriteLine("enter sharname\t");
            string sharename = Console.ReadLine();
            Console.WriteLine("enter no of share\t");
            int NoofShares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter shareprice");
            double shareprice = Convert.ToInt32(Console.ReadLine());
            if (category == 1)
            {
                Amazon.AddAmazonItem(sharename, NoofShares, shareprice);
            }
            else if (category == 2)
            {
               Flipkart.AddFlipKartItem(sharename, NoofShares, shareprice);
            }
            else if (category == 3)
            {
                Tcs.AddTcsItem(sharename, NoofShares, shareprice);
            }
            

            Console.WriteLine("item is added");
        }
        public static void DeletCatagory(int catagory)
        {
            if (catagory == 1)
            {
                Amazon.DeleteAmazon();
            }
            else if (catagory == 2)
            {
                Flipkart.DeleteFlipKartItem();
            }
            else if (catagory == 3)
            {
                Tcs.DeleteTcsItem();
            }
            Console.WriteLine("item is deleted from the json file");
        }
        /// <summary>
        /// Prints this instance.
        /// Print the all JsonFile content
        /// </summary>
        public static void Print()
        {
            CompanyName array = Utility.ReadJsonFile();
            Console.WriteLine("amazon...........\t");
            foreach (var i in array.Amazon)
            {
                Console.WriteLine("AmazonShareName =" + i.ShareName1);
                Console.WriteLine("no of Share =" + i.NoOfShare1);
                Console.WriteLine("SharePrice =" + i.SharePrice1);
            }

            Console.WriteLine("FlipKart..............\t");
            foreach (var i in array.Flipcart)
            {
                Console.WriteLine("FlipKartShareName =" + i.ShareName1);
                Console.WriteLine("NOfShare =" + i.NoOfShare1);
                Console.WriteLine("Price =" + i.SharePrice1);
            }

            Console.WriteLine("Tcs......................\t");
            foreach (var i in array.Tcs)
            {
                Console.WriteLine("TcsShareName =" + i.ShareName1);
                Console.WriteLine("no of share =" + i.NoOfShare1);
                Console.WriteLine("Price =" + i.SharePrice1);
            }
        }
    }
}
