using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Progrm");
            SortedLinkedList list = new SortedLinkedList();
            list.Add(32);
            list.Add(12);
            list.Add(434);
            list.Add(0);
            list.Display();
            System.Console.WriteLine(list.Size());
        }
    }
}

   
