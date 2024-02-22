using System;

namespace _0216p2
{
    internal class Program
    {
        class OneChain
        {
            public int data;
            public OneChain next = null;

            public OneChain(int value)
            {
                data = value;
            }
        }

        static void Main(string[] args)
        {
            OneChain head = null;

            
            Add(ref head, new OneChain(1));
            Add(ref head, new OneChain(2));
            Add(ref head, new OneChain(3));
            Add(ref head, new OneChain(4));

           
            PrintList(head);

           
            Remove(ref head, 2);

        
            PrintList(head);

            Console.ReadKey();
        }

       
        static void Add(ref OneChain head, OneChain newNode)
        {
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                OneChain current = head;
                while (current.next != null && current.next.data < newNode.data)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }

        
        static void Remove(ref OneChain head, int value)
        {
            if (head == null)
                return;

            if (head.data == value)
            {
                head = head.next;
                return;
            }

            OneChain current = head;
            while (current.next != null)
            {
                if (current.next.data == value)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }

       
        static void PrintList(OneChain head)
        {
            OneChain current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
