using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> mylist = new LinkedList<string>();

            for (int i = 0; i < 5; i++)
            {
                mylist.Add(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mylist.Get(i));
            }
            mylist.Reverse();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mylist.Get(i));
            }

            Console.ReadKey();
        }
    }
}