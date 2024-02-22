using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0216p2

{
    internal class Program
    {

        public static OneChainList head;
        internal class OneChainList
        {
            public string data;
            public OneChainList next;

            public OneChainList(string value)
            {
                data = value;
            }
        }

        static void Main(string[] args)
        {
            head = null;

            

            Add(new OneChainList("1"));
            Add(new OneChainList("2"));
            Add(new OneChainList("3"));
            Add(new OneChainList("4"));

            OneChainList item = head;
            Console.WriteLine("Törlés előtt");
            while (item != null)
            {
                Console.WriteLine(item.data);
                item = item.next;
            }

            Remove("1");

            Console.WriteLine("Törlés után");
            item = head;
            while (item != null)
            {
                Console.WriteLine(item.data);
                item = item.next;
            }


            Console.ReadKey();
        }


        public static void Add(OneChainList newNode)
        {
          
            if (head == null)
            {
                head = newNode;
            }
            else
            {
               
                OneChainList lastNode = head;
                while (lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = newNode;
            }
        }

        public static void Remove(string value)
        {
           
            if (head.data == value)
            {
                head = head.next;

            }
          
            OneChainList currentNode = head;
            while (currentNode.next != null && currentNode.next.data != value)
            {
                currentNode = currentNode.next;
            }


            if (currentNode.next != null)
            {
               
                currentNode.next = currentNode.next.next;
            }
        }


    }
}