using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {

        //Creating a node head, which will be pointing to the first element in linkedlist
        public Node head;
        public void InsertLast(int new_data)//creat method InserTlast 
        {
            Node node = new Node(new_data);//Creating obj of class node for variable node which will insert a value of link list

            //fills the first position in linkedlist, when head points to nothing
            if (this.head == null) 
            {
                this.head = node; // if head is equal to null then assigning value of node to head
            }
            else
            {
                //get last node method is called to find out last node

                Node lastNode = GetLastNode(); // updating lastnode with next node address
                lastNode.next = node; // inserting new node
            }
            Console.WriteLine("inserted into list" + node.data);

        }

        /// finds out the last node 
        public Node GetLastNode()
        {
            Node temp = this.head;
            //if address in the temp node is not null, loop continues
            while (temp.next != null)
            {
                temp = temp.next;
            }

            //when temp.next ==null, means last element is reached, temp is returned
            return temp;
        }

        /// <summary>
        /// Data is inserted at left side of head
        /// </summary>
        /// <param name="data"></param>
        public void InsertFront(int new_data)
        {
            //object is created for adding data in node class

            Node new_node = new Node(new_data);

            //head address is added in newly created node, hence the initial head is coming at last, and data is inserted at left
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted into front" + new_node);
        }

        internal Node DeleteFirstNode() // method to get head node which will be deleted 
        {
            if (this.head == null) // checking if head node is null then return null
            {
                return null;
            }
            this.head = this.head.next; // pointer will shift to next node
            return this.head; // returning head node
        }

        public Node DeleteLastNode() // method to delete last node
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null) // if checking 2nd node will be null.
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null) //  checking 2nd last node will be not null
            {
                newNode = newNode.next; // pointing new node to new.next node
            }
            newNode.next = null; // if last element is eleminated then 2nd last element should be null
            return newNode; // rtuning new node
        }
        internal void Display()
        {
            //assigns head to 1st node.
            //temp becomes first node of linkedlist
            Node temp = this.head;

            //if temp is null, then linkedlist is null
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                //if temp contains data, then loop is iterated and values are printed

                while (temp.next != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }


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
            next = null; // this constructor will create a head node and assign next.node = null
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Data Structure Program-------");

            LinkedList list = new LinkedList();//creating object of linkedlist class


            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);

            list.DeleteLastNode();

            list.Display();

            Console.Read();

        }
    }
}
