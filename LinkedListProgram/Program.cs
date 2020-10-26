using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Progrm");
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Append(100);
            list.Insert(4, 12);
            System.Console.WriteLine(list.Search(10));
            list.Display();
            
        }
    }
}
