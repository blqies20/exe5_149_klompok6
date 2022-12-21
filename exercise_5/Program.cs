using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        public Node balqis, maharani;

        public Queue()
        {
            balqis = null;
            maharani = null;
        }
        public void Insert()
        {
            string add;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element :");
            add = Console.ReadLine();
            newnode.name = add;
            newnode.next = balqis;
            if(maharani == null )
            {
                balqis= newnode;
                maharani = newnode;
                return;
            }
            maharani.next = newnode;
            maharani = newnode;
        }
        public void Delete()
        {
            if(maharani == null ) 
            {
                Console.WriteLine("\nList is Empty");
                return;
            }
        }
    }
}
