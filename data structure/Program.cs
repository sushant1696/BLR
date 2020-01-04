using System;

namespace LList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleList obj = new SingleList();
            obj.InsertEnd(5);


            Console.WriteLine("1 display");
            Console.WriteLine("2 coun6t the no of node");
            Console.WriteLine("3. insert element for search");
            Console.WriteLine("4. insert a node at begenning");
            Console.WriteLine("5.insert end");
            Console.WriteLine("6. creation list");
            Console.WriteLine("7. insert after ");




            Console.WriteLine("choice your number");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Display();
                    break;
                case 2:
                    obj.CountNode();
                    break;
                case 3:
                    Console.WriteLine("enter the element for search");
                    int data = Convert.ToInt32(Console.ReadLine());
                    obj.Search(data);
                    break;
                case 4:
                    obj.InsertBeg(3);
                    break;
                case 5:
                    obj.InsertEnd(4);
                    break;
                case 6:
                    obj.CreationList();
                    break;
                case 7:
                    obj.InsertAfter(56,2);
                    break;
            }
        }
    }
}
