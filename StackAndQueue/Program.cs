using System;
using StackAndQueue;

class program
{
    static void Main(string[] args)
    {
        LinkListStack linkedListStack = new LinkListStack();
        linkedListStack.Push(70);
        linkedListStack.Push(30);
        linkedListStack.Push(56);
        linkedListStack.Display();
    }
}
