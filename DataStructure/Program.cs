using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {
        public Node head; // node is  class pointing to head // creation of head 
        public void Add(int data)
        {
            Node node = new Node(data); // creating obj of class Node for variable node which will insert a value in link list 
            if (this.head == null)
                this.head = node;// if head is equal to null then assigning value of node to head 
            else
            {
                Node temp = head; // holdig head node in temp variable
                while (temp.next != null) // checking if temp.next is not null
                {
                    temp = temp.next; // updating temp with next node address
                }
                temp.next = node; // inserting  new node 
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

    }
    public class Node
    {
        public int data; //i have define two elements overthere
        public Node next; // defining next node

        //constructor
        public Node(int d) // it will take data from user to save in linked list
        {
            data = d;
            next = null; // this constructor will create a head node and assign node.next = null
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Data Structure Program-------");

            LinkedList list = new LinkedList();//creating object of linkedlist class
            list.Add(56);
            list.Add(30);
            list.Add(70);

            Console.Read();
        }
    }
}
