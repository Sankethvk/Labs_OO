using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter Cache max_capacity");
            int capacity = CustomConsole.ReadInt();
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());
		    Cache.SetMethodCapacity(capacity);
		
		    Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

		    
            Console.WriteLine("MAX_CAPACITY is " + Cache.GetMaxCapacity());

            Console.ReadLine();
        }
    }
}
