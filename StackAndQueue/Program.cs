using System;
using StackAndQueue;

class program
{
    static void Main(string[] args)
    {
       // LinkListStack linkedListStack = new LinkListStack();
        //linkedListStack.Push(70);
        //linkedListStack.Push(30);
        //linkedListStack.Push(56);
        //linkedListStack.Display();
        //linkedListStack.peek();
        //linkedListStack.pop();
        //linkedListStack.isEmpty();
        //linkedListStack.Display();

        LinkListQueue linkedListQueue = new LinkListQueue();
        linkedListQueue.Enqueue(56);
        linkedListQueue.Enqueue(30);
        linkedListQueue.Enqueue(70);
        linkedListQueue.Display();
        linkedListQueue.Dequeue();
        linkedListQueue.Display();
    }
}


