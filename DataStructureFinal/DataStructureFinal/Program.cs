using System;
using System.Collections;
using static DataStructure.MyCollection;
using static DataStructure.MyCollection.CircularLinkedList;
//using static DataStructure;
//using static DataStructure.MyCollection.SinglyLinkedList.CircularLinkedList;
//using static System.Collections.Queue;
namespace DataStructure
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Queue......................");
            MyCollection.Queue que = new MyCollection.Queue();

            MyCollection.Queue.Enqueue(1);
            que.Enqueue(10);
            que.Enqueue(100);





            MyCollection.SinglyLinkedList.Node head = new MyCollection.SinglyLinkedList.Node(1);
            MyCollection.SinglyLinkedList.Node second = new MyCollection.SinglyLinkedList.Node(2);
            MyCollection.SinglyLinkedList.Node third = new MyCollection.SinglyLinkedList.Node(3);
            MyCollection.SinglyLinkedList.Node fourth = new MyCollection.SinglyLinkedList.Node(4);

            head.next = second;
            second.next = third;
            third.next = fourth;

            MyCollection list = new MyCollection();
            MyCollection.SinglyLinkedList.display(head);
            MyCollection.SinglyLinkedList.Count(head);


            Console.WriteLine(" add begin new list is ....");

            MyCollection.SinglyLinkedList.AddBegin(head, 12);
            MyCollection.SinglyLinkedList.display(head);


            Console.WriteLine("insert at last new list is....");
             MyCollection.SinglyLinkedList.AddLast(head, 22);
            MyCollection.SinglyLinkedList.display(head);

            Console.WriteLine(" GivenAfter new list is....");
            MyCollection.SinglyLinkedList.GivenAfter(head, 29);
            MyCollection.SinglyLinkedList.display(head);


            Console.WriteLine(" AddPosition new list is....");
             MyCollection.SinglyLinkedList.AddPosition(head, 66, 3);
            MyCollection.SinglyLinkedList.display(head);


            Console.WriteLine(" deleted node is....");
            MyCollection.SinglyLinkedList.DeleteFirst(head);
            MyCollection.SinglyLinkedList.display(head);



            //Console.WriteLine(" deleted last node is....");
            //MyCollection.Node newhead5 = MyCollection.SinglyLinkedList.DeleteLast(head);
            //MyCollection.SinglyLinkedList.display(newhead5);


            //Console.WriteLine(" deleted position node is....");
            //MyCollection.Node newhead6 = MyCollection.SinglyLinkedList.DeletePosition(head, 3);
            //MyCollection.SinglyLinkedList.display(newhead6);


            Console.WriteLine("  search node is....");
           MyCollection.SinglyLinkedList.Search(head, 2);
            MyCollection.SinglyLinkedList.display(head);


            Console.WriteLine("  reverse list is....");
         MyCollection.SinglyLinkedList.Reverse(head);
            MyCollection.SinglyLinkedList.display(head);


            Console.WriteLine("stack ........................");
            System.Collections.Stack stk = new System.Collections.Stack();
            stk.Push(10);
            Console.WriteLine(stk.Peek());
            stk.Push(20);
            Console.WriteLine(stk.Peek());
            stk.Push(30);
            Console.WriteLine(stk.Peek());
            stk.Push(40);
            Console.WriteLine(stk.Peek());


            Console.WriteLine("circular linked list.........");
            CircularLinkedList crlr = new CircularLinkedList();
            Node hh = (crlr.creatCircularList());
            crlr.Display();

            Console.WriteLine("circular linked list add begenning........");
            CircularLinkedList addbeg = new CircularLinkedList();
            addbeg.InsertBeg(34);
            addbeg.InsertBeg(50);
            addbeg.InsertBeg(60);
            addbeg.Display();

            Console.WriteLine("circular linked list add last........");
            CircularLinkedList addlast = new CircularLinkedList();
            addlast.AddLast(34);
            addlast.AddLast(50);
            addlast.AddLast(60);
            addlast.Display();

            Console.WriteLine(" conatain and create loop of circular linked list.........");
            CircularLinkedList loop = new CircularLinkedList();
            loop.Creatloop();
            Console.WriteLine(loop.ContainLoop());



        }
    } 
}
