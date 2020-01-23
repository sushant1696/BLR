using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.StockAccountManagement
{
    class MenuOfCompany
    {
        public static void IsManu()
        {
            Console.WriteLine("Select an category..........\n");
            Console.WriteLine("1 ->for amazon\n 2 ->for flipkart\n 3-> for Tcs ");
            int category = Convert.ToInt32(Console.ReadLine());


            switch (category)
            {
                case 1:
                    Amazon.IsAmazon();
                    break;
                case 2:
                    Flipkart.IsFlipKart();
                    break;
                case 3:
                    Tcs.IsTcs(); 
                    break;
                default:
                    break;
            }
            Console.WriteLine("select a operation to perform.......\n");
            Console.WriteLine("1.Add\n2.Delete");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    ActionPerform.Insert(category);
                    break;
                case 2:
                    ActionPerform.DeletCatagory(category);
                    break;
            }
        }
      
    }

}
