using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class LinkedStack
    {
        private Node top;
        public LinkedStack()
        {
            this.top = null;//initialely the top value will be null.
        }
        internal void pushElement(int value)//method for adding elements in the stack.
        {
            Node node = new Node(value);
            if(this.top==null)//if the stack is empty.
            {
                node.next = null;//the next value will also become null.
            }
            else
            {
                node.next = this.top;//the next node will become the null value.
            }
            this.top = node;//this will set the top value as the pointer.
        }
        internal void peakOperation()
        {
            if(this.top==null)//if there is no elemnt in the stack
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Top Element = "+this.top.data);//display the top elemnent.
            }
        }
        internal void popOperation()//Pop Method is written
        {
            if (this.top == null)//if there is no element in the Stack.
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Value Popped = " + this.top.data);//amd return the top postion.
            this.top = this.top.next;//increment the top position to point to the next node.
        }
        internal void isEmpty()//this method is used to display both peak and pop
        {
            while(this.top!=null)//if the stack is not empty.
            {
                peakOperation();
                popOperation();
            }
        }
        internal void Display()//method used to display the Stack.
        {
            Node temp = this.top;//inintialize the pointer to top.
            if (temp == null)//if the head is empty then the stack is empty.
            {
                Console.WriteLine("Linked List is Empty");
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
