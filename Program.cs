using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue linkedQueue = new LinkedQueue();//object of LinkedQueue created.
            linkedQueue.enQueue(56);
            linkedQueue.enQueue(30);
            linkedQueue.enQueue(70);
            linkedQueue.Display();
        }
    }
}
