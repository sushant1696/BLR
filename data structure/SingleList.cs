using System;
using System.Collections.Generic;
using System.Text;

namespace LList
{
    class SingleList
    {
        private Nodes start;
        public SingleList()
        {
            start = null;
        }
        public void Display()
        {
            Nodes p;
            if (start == null)
            {
                Console.WriteLine("the list is empty");
                return;
            }
            Console.WriteLine(" the list is....");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info);
                p = p.link;

            }
            Console.WriteLine();

        }
        public void CountNode()
        {
            int n = 0;
            Nodes p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("no of nodes in the list is:" + n);
        }
        public bool Search(int x)
        {
            int position = 1;
            Nodes p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(x + "is not found in the list");
                return false;
            }
            else
            {
                Console.WriteLine(x + "is found in the list" + position);
                return true;
            }

        }
        public void InsertBeg(int data)
        {
            Nodes temp = new Nodes(data);
            temp.link = start;
            start = temp;
            Console.WriteLine(start);
        }
        public void InsertEnd(int data)
        {
            Nodes p;
            Nodes temp = new Nodes(data);
            if (start == null)
            {
                start = temp; ;
                return;
            }
            p = start;
            while (p.link != null)
                p = p.link;
            p.link = temp;
        }
        /*public void CreationList()
        {

            Console.Write("enter the number of nodes");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                return;
            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("enter the element you want to inser ");
                int data = Convert.ToInt32(Console.ReadLine());
                InsertEnd(data);
            }
        }*/
        public void InsertAfter(int data1,int x)
        {
            Console.Write("enter the number of nodes");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                return;
            }
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("enter the element you want to inser ");
                int data = Convert.ToInt32(Console.ReadLine());
                InsertEnd(data);
            }
            Nodes temp = new Nodes(data1);
            Nodes p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;

                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + "not present");
            }
            else
            {

                temp.link = p.link;
                p.link = temp;
            }
        }

        
    }
}
