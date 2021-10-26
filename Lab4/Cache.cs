using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        private static int MAX_CAPACITY = 0;

        public static void SetMethodCapacity(int max_capacity)
        {
            MAX_CAPACITY = max_capacity;
        }
        

      
        public static int GetMaxCapacity() 
        {
		    Console.WriteLine("Returning MAX_CAPACITY");
            
		    return MAX_CAPACITY;
	    }
    }
}
