using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack linkedStack = new LinkedStack();//object of the LinkedStack Class.
            linkedStack.pushElement(70);//this will go in the last.
            linkedStack.pushElement(30);
            linkedStack.pushElement(56);//this will go in the top.
            linkedStack.Display();//this will display.
        }
    }
}
