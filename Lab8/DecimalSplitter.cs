using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class DecimalSplitter
    {
        public static int GetWhole(double Number)
        {
            int int_part = (int)Number;
            return int_part;
            
        }

   
        public static double GetFraction(double Number)
        {
            int int_part = (int)Number;
            return (Number-(int_part));
            
        }

       
        //public static bool IsOdd(double Number)
        //{
        //}
    }
}
