﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkListStack
    {
        private Node top;
        public LinkListStack()
        {
            this.top = null;
        }
        internal void Push(int Value)
        {
            Node node = new Node(Value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;

            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", Value);

        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
