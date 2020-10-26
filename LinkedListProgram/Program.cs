using System;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Progrm");
            Node head = new Node(56);
            head.next = new Node(30);
            head.next.next = new Node(70);
        }
    }
}
