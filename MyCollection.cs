using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

    public class MyCollection
    {

        //public class Node
        //{
        //    public int data;
        //    public Node next;




        //    public Node(int data) //// node constructor
        //    {
        //        this.data = data;

        //    }
        //}



        //public class SinglyLinkedList
        //{
        //    public Node head;

        //    public SinglyLinkedList(Node head)
        //    {
        //        this.head = head;
        //        //this.data = data;
        //    }

        //    public static void display(Node head)
        //    {
        //        if (head == null)
        //        {
        //            return;//node is empty
        //        }
        //        Node temp = head;
        //        while (temp != null)
        //        {
        //            Console.WriteLine(temp.data);
        //            temp = temp.next;
        //        }
        //        Console.WriteLine(temp);
        //    }
        //    //method for count the node
        //    public static void count(Node head)
        //    {
        //        Node temp = head;////current refference pointing the head at first
        //        int count = 0;////creat counter variable to count the node
        //                      ////loop for each element and increament the count
        //        while (temp != null)
        //        {
        //            count++;
        //            temp = temp.next;
        //        }
        //        Console.WriteLine("number of nodes is" + count);
        //    }
        //    public static Node AddBegin(Node head, int data)
        //    {
        //        Node newnode = new Node(data);
        //        newnode.next = head;//in newnode next part add the head ,now become it first node
        //        head = newnode;
        //        return head;//this head will be the new head having new node at beginning
        //    }

        //    public static Node AddLast(Node head, int data)
        //    {
        //        Node newnode = new Node(22);
        //        Node temp = head;
        //        ////loop for each element and increament

        //        while (temp.next != null)
        //        {
        //            temp = temp.next;


        //        }
        //        temp.next = newnode; //newly created newnode connected to the list
        //        return head;//newly created head 
        //    }



        //     ////method for insert a node after a given node
        //     public static Node GivenAfter(Node previous, int data)

        //     {
        //         if (previous == null)
        //         {
        //             Console.WriteLine("the given previous node can not be null");
        //             return previous;
        //         }
        //         Node newnode = new Node(data);
        //         newnode.next = previous.next;
        //         previous.next = newnode;
        //         return previous;
        //     }
        //     public static Node AddPosition(Node head, int data, int position)
        //     {
        //         Node newnode = new Node(data);//creat a new node
        //         Node p = head;//take a refrence variable which indicate the head at initial
        //         int count = 1; //a counter for count the position
        //         while (count < position - 1)
        //         {
        //             p = p.next;
        //             count++;
        //         }
        //         Node temp = new Node(data);  ////create current node
        //         newnode.next = temp;//// before current node add the new node
        //         p.next = newnode; ////
        //         return head;
        //     }
        //     public static Node DeleteFirst(Node head)
        //     {
        //         Node temp = head; ////create a temp variable which pointing the head
        //         head = head.next; //// moved head first node to second node
        //         temp.next = null; //// temp node next part assign with the null for separete the node
        //         return temp;
        //     }
        //     //public static Node DeleteLast(Node head)

        //     //{
        //     //    Node temp = head;//// create a temp reference node variable which pointing the head
        //     //    Node previousToLast = null; ////create a another node variable which assign with null
        //     //    while (temp.next != null)
        //     //    {
        //     //        previousToLast = temp; //// previousToLast node variablr pointing the head
        //     //        temp = temp.next;   //// increament/moved the temp node variable
        //     //    }
        //     //    previousToLast.next = null; //// PreviousToLast node variable next part Assign with null
        //     //    return temp;
        //     //}
        //     //public static Node DeletePosition(Node head, int position)
        //     //{
        //     //    Node temp = head;
        //     //    int count = 1;
        //     //    while (count < position - 1)
        //     //    {
        //     //        temp = temp.next;
        //     //        count++;
        //     //    }
        //     //    Node current = temp.next;
        //     //    current.next = null;
        //     //    return temp;
        //     //}
        //     public static Node Search(Node head, int kay)
        //     {
        //         int Position = 1;
        //         Node temp = head;
        //         while (temp != null)
        //         {
        //             if (temp.data == kay)
        //             {
        //                 Position++;
        //                 break;
        //             }
        //             temp = temp.next;
        //             if (temp == null)
        //             {
        //                 Console.WriteLine(kay + "key is not found");
        //             }
        //             else
        //             {

        //                 Console.WriteLine(kay + "key found as at position" + Position);

        //             }

        //         }
        //         return temp;
        //     }
        //     public static Node Reverse(Node head)
        //     {
        //         Node temp = head;
        //         Node previous = null;
        //         Node next = null;
        //         while (temp != null)
        //         {
        //             next = temp.next;//// next node start moved where initialy  next assign with null
        //             temp.next = previous; ////next part of temp assign with previous
        //             previous = temp; //// previous point to temp
        //             temp = next;    ////temp pointing to next

        //         }
        //         return previous;//// previous become head
        //     }

        //}
        /// <summary>
        /// This class created for DoublyLinked list
        /// </summary>
        public class Stack
        {
            public Node top;

            public int length;

            public class Node
            {
                public int data;
                public Node next;

                public Node(int data)  //// constructor for the Node class
                {
                    this.data = data;
                }
            }
            public Stack() ////constructor for DoublyLinkedList class
            {
                top = null;

                length = 0;
            }
            public int IsEmpty()
            {
                return length;
            }
            public int Length()
            {
                return length;
            }

            public void push(int data)
            {
                Node temp = new Node(data);
                {
                    temp.next = top;
                    top = temp;

                    length++;

                }

            }

            public int Pop()
            {

                int result = top.data;
                top = top.next;
                length--;
                return result;
            }
            public int peek()
            {
                return top.data;
            }


        }

        /// <summary>
        /// This class created for circular linked list
        /// </summary>
        public class CircularLinkedList
        {
            public Node last;
            public int length;

            /// <summary>
            /// This class created for creating the node
            /// of circular lingked list
            /// </summary>
            public class Node
            {
                
                public Node next;
                public int data;
               
                public Node(int data)
                {
                    this.data = data;
                }
            }

            public CircularLinkedList()
            {
                length = 0;
                last = null;
            }
            public int Length()
            {
                return length;
            }
            public Boolean IsEmpty()
            {
                return length==0;
            }
            public Node creatCircularList()
            {
                Node first = new Node(1);
                Node second = new Node(2);
                Node third = new Node(3);
                Node fourth = new Node(4);

                first.next = second;
                second.next = third;
                third.next = fourth;
                fourth.next = first;
                last = fourth;
                return last;

            }
            public void Display()
            {
                if (last == null)
                {
                    return;
                }
                Node first = last.next;
                while (first != last)
                {
                    Console.WriteLine(first.data);
                    first = first.next;
                }
                Console.WriteLine(first.data);
            }

        }

    }
}

