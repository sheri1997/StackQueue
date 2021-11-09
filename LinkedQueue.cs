using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class LinkedQueue
    {
        Node head = null;
        internal void enQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)//if the queue is empty
            {
                head = node;//initialize data entered as head.
            }
            else
            {
                Node temp = head;//it will assign a temporay variable as head.
                while (temp.next != null)//till it finds an empty node
                {
                    temp = temp.next;//data will be assigned to it.
                }
                temp.next = node;//the next value will be assigned as tail.
            }
            Console.WriteLine(node.data);//will print the queue.
        }
        internal void Display()//method used to display the Stack.
        {
            Node temp = this.head;//inintialize the pointer to head.
            if (temp == null)//if the head is empty then the stack is empty.
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)//will check till the empty node is found.
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
