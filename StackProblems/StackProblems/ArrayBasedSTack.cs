using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    public class ArrayBasedStack
    {
        private static int[] arr = new int[100];
        private static int top = -1;

        public void Push(int el)
        {
            if (top != arr.Length - 1)
            {
                top = top + 1;
                arr[top] = el;
            }
            else
            {
                throw new InvalidOperationException("Element can not be inserted");
            }
        }

        public int Pop()
        {
            if (top != -1)
            {
                var temp = arr[top];
                top = top - 1;
                return temp;
            }
            else
            {
                throw new InvalidOperationException("No more element to remove");
            }
        }

        public int Top()
        {
            if (top != -1)
                return arr[top];
            else
                throw new InvalidOperationException("Stack is Empty");
        }

        public void Print()
        {
            Console.WriteLine("Stack: ");
            for (int i = 0; i <= top; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program1
    {
        static void Main1(string[] args)
        {
            try
            {
                ArrayBasedStack stack = new ArrayBasedStack();
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
