using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    class Tcs
    {
        private string ShareName;
        private int NoOfShare;
        private double SharePrice;

        public string ShareName1 { get => this.ShareName; set => this.ShareName = value; }
        public int NoOfShare1 { get => this.NoOfShare; set => this.NoOfShare = value; }
        public double SharePrice1 { get => this.SharePrice; set => this.SharePrice = value; }
        public static void IsTcs()
        {
            CompanyName array = Utility.ReadJsonFile();
            foreach (var item in array.Tcs)
            {
                Console.WriteLine(item.ShareName);
                Console.WriteLine(item.NoOfShare);
                Console.WriteLine(item.SharePrice);
            }

        }
        public static void AddTcsItem(String ShareName, int NoOfShare, double SharePrice)
        {
            CompanyName array = Utility.ReadJsonFile();
           Tcs obj2 = new Tcs();
            obj2.ShareName = ShareName;
            obj2.NoOfShare = NoOfShare;
            obj2.SharePrice = SharePrice;
            array.Tcs.Add(obj2);
            Utility.WriteJsonFile(array);

        }
        public static void DeleteTcsItem()
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
