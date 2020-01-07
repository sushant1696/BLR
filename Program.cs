using System;
using static DataStructure.MyCollection;
using static DataStructure.MyCollection.CircularLinkedList;

namespace DataStructure
{
    class Program
    {
       

        static void Main(string[] args)
        {



            // MyCollection.Node head = new MyCollection.Node(1);
            // MyCollection.Node second = new MyCollection.Node(2);
            // MyCollection.Node third = new MyCollection.Node(3);
            // MyCollection.Node fourth = new MyCollection.Node(4);

            // head.next = second;
            // second.next = third;
            // third.next = fourth;

            // MyCollection list = new MyCollection();
            // MyCollection.SinglyLinkedList.display(head);
            // MyCollection.SinglyLinkedList.count(head);


            // Console.WriteLine(" add begin new list is ....");

            // MyCollection.Node newhead = MyCollection.SinglyLinkedList.AddBegin(head, 12);
            // MyCollection.SinglyLinkedList.display(newhead);


            // Console.WriteLine("insert at last new list is....");
            // MyCollection.Node newhead1 = MyCollection.SinglyLinkedList.AddLast(head, 22);
            // MyCollection.SinglyLinkedList.display(newhead1);

            // Console.WriteLine(" GivenAfter new list is....");
            // MyCollection.Node newhead2 = MyCollection.SinglyLinkedList.GivenAfter(head, 29);
            // MyCollection.SinglyLinkedList.display(newhead2);


            // Console.WriteLine(" AddPosition new list is....");
            // MyCollection.Node newhead3 = MyCollection.SinglyLinkedList.AddPosition(head, 66,3);
            // MyCollection.SinglyLinkedList.display(newhead3);


            // Console.WriteLine(" deleted node is....");
            // MyCollection.Node newhead4 = MyCollection.SinglyLinkedList.DeleteFirst(head);
            // MyCollection.SinglyLinkedList.display(newhead4);



            ////Console.WriteLine(" deleted last node is....");
            //// MyCollection.Node newhead5 = MyCollection.SinglyLinkedList.DeleteLast(head);
            //// MyCollection.SinglyLinkedList.display(newhead5);


            // //Console.WriteLine(" deleted position node is....");
            // //MyCollection.Node newhead6 = MyCollection.SinglyLinkedList.DeletePosition(head, 3);
            // //MyCollection.SinglyLinkedList.display(newhead6);


            //  Console.WriteLine("  search node is....");
            // MyCollection.Node newhead7 = MyCollection.SinglyLinkedList.Search(head, 2);
            // MyCollection.SinglyLinkedList.display(newhead7);


            // Console.WriteLine("  reverse list is....");
            // MyCollection.Node newhead8 = MyCollection.SinglyLinkedList.Reverse(head);
            // MyCollection.SinglyLinkedList.display(newhead8);


            Console.WriteLine("stack ........................");
            Stack stk = new Stack();
            stk.push(10);
            Console.WriteLine(stk.peek());
            stk.push(20);
            Console.WriteLine(stk.peek());
            stk.push(30);
            Console.WriteLine(stk.peek());
            stk.push(40);
            Console.WriteLine(stk.peek());


            Console.WriteLine("circular linked list.........");
            CircularLinkedList crlr = new CircularLinkedList();
         Node hh=(crlr.creatCircularList());
            crlr.Display();
        }
       
            
    }
}