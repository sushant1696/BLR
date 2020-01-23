using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    class Flipkart
    {
        private string ShareName;
        private int NoOfShare;
        private double SharePrice;

        public string ShareName1 { get => this.ShareName; set => this.ShareName = value; }
        public int NoOfShare1 { get => this.NoOfShare; set => this.NoOfShare = value; }
        public double SharePrice1 { get => this.SharePrice; set => this.SharePrice = value; }

        public static void IsFlipKart()
        {
            CompanyName array = Utility.ReadJsonFile();
            foreach (var item in array.Flipcart)
            {
                Console.WriteLine(item.ShareName);
                Console.WriteLine(item.NoOfShare);
                Console.WriteLine(item.SharePrice);
            }

        }
        public static void AddFlipKartItem(String ShareName, int NoOfShare, double SharePrice)
        {
            CompanyName array = Utility.ReadJsonFile();
            Flipkart obj3 = new Flipkart();
            obj3.ShareName = ShareName;
            obj3.NoOfShare = NoOfShare;
            obj3.SharePrice = SharePrice;
            array.Flipcart.Add(obj3);
            Utility.WriteJsonFile(array);

        }
        public static void DeleteFlipKartItem()
        {
            int j = 1;
            CompanyName array = Utility.ReadJsonFile();
            foreach (var i in array.Flipcart)
            {
                Console.WriteLine(j++ + "=" + i.ShareName1);
            }

            Console.WriteLine("Enter the item no to delete");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            array.Amazon.RemoveAt(itemNumber - 1);
            Utility.WriteJsonFile(array);
        }
    }
}
