using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            OneChain node = new OneChain(1);
            head = node;

            OneChain node2= new OneChain(2);

            head.next = node2;

            OneChain node3= new OneChain(3);

            node2.next = node3;
            node3.next = null;

            OneChain item = head;
            while (item!=null)
            {
                Console.WriteLine(item.data);
                item = item.next;
            }

            Console.ReadKey();
        }
    }
}
