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
            newnode.next = null;
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
            balqis = balqis.next;
            if (maharani== null)
                maharani = null;         
        }
        public void Display()
        {
            if(balqis == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            Node display;
            for(display = balqis; display!= null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue qe = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Menambah Data ke dalam List");
                    Console.WriteLine("2. Menghapus Data dari dalam Liat");
                    Console.WriteLine("3. Melihat semua data di dalam List");
                    Console.WriteLine("4. Exit");
                    Console.Write("Masukkan pilihan anda (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            qe.Insert();
                            break;
                        case '2':
                            qe.Delete();
                            break;
                        case '3':
                            qe.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Wrong Option");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value enetred ");
                }
            }
        }
    }
}
