using System;

namespace StackProblems
{
    internal class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
    }

    internal class LinkedList
    {
        public Node Head { get; set; } = null;

        public void Insert(int data)
        {
            var node = new Node() { data = data, Next = null };
            if (Head == null)
                Head = node;
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

        public int Delete()
        {
            if (Head == null)
                throw new InvalidOperationException("List is empty !!!");
            var temp = Head.data;
            Head = Head.Next;
            return temp;
        }

        public void Print()
        {
            var list = Head;
            Console.Write("Elements: ");
            while (list != null)
            {
                Console.Write(list.data + " ");
                list = list.Next;
            }
            Console.WriteLine();
        }
    }

    public class LinkedListBasedStack
    {
        LinkedList list = new LinkedList();
        internal void Push(int v)
        {
            list.Insert(v);
        }

        internal void Print()
        {
            list.Print();
        }

        internal void Pop()
        {
            list.Delete();
        }
    }

    internal class Program2
    {
        private static void Main(string[] args)
        {
            try
            {
                LinkedListBasedStack stack = new LinkedListBasedStack();
                stack.Push(10);
                stack.Print();
                stack.Push(20);
                stack.Print();
                stack.Pop();
                stack.Print();
                stack.Push(30);
                stack.Print();
                stack.Push(40);
                stack.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}