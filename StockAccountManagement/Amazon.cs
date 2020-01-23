using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    class Amazon
    {
        private string ShareName;
        private int NoOfShare;
        private double SharePrice;

        public string ShareName1 { get => this.ShareName; set => this.ShareName = value; }
        public int NoOfShare1 { get => this.NoOfShare; set => this.NoOfShare = value; }
        public double SharePrice1 { get => this.SharePrice; set => this.SharePrice = value; }
        /// <summary>
        /// IsAmazon Method display the previous added content
        /// Determines whether this instance is amazon.
        /// </summary>
        public static void IsAmazon()
        {
            CompanyName array = Utility.ReadJsonFile();
            foreach (var item in array.Amazon)
            {
                Console.WriteLine(item.ShareName);
                Console.WriteLine(item.NoOfShare);
                Console.WriteLine(item.SharePrice);
            }

        }

        public static void AddAmazonItem(String ShareName,int NoOfShare,double SharePrice)
        {
            CompanyName array = Utility.ReadJsonFile();
            Amazon obj2 = new Amazon();
            obj2.ShareName = ShareName;
            obj2.NoOfShare = NoOfShare;
            obj2.SharePrice = SharePrice;
            array.Amazon.Add(obj2);
           Utility.WriteJsonFile(array);

        }
        public static void DeleteAmazon()
        {
            int j = 1;
            CompanyName array = Utility.ReadJsonFile();
            foreach (var i in array.Amazon)
            {
                Console.WriteLine(j++ + "=" + i.ShareName);
            }

            Console.WriteLine("Enter the item no to delete");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            array.Amazon.RemoveAt(itemNumber - 1);
            Utility.WriteJsonFile(array);
        }

    }
}
