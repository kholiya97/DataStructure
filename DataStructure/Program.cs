using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {
        public Node head;
        public void InsertLast(int new_data)//creat method InserTlast 
        {
            Node node = new Node(new_data);//
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = node;
            }
            Console.WriteLine("inserted into list" + node.data);

        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
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
        public Node next;

        //constructor
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To Data Structure Program-------");

            LinkedList list = new LinkedList();//creating object of linkedlist class
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            list.Display();

            Console.Read();
        }
    }

}


