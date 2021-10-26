using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks1");
            int Marks1 = CustomConsole.ReadInt();
            Console.WriteLine("enter marks2");
            int Marks2 = CustomConsole.ReadInt();
            Console.WriteLine("enter marks3");
            int Marks3 = CustomConsole.ReadInt();

            ResultFinder Finder = new ResultFinder();
            Finder.Marks1 = Marks1;
            Finder.Marks2 = Marks2;
            Finder.Marks3 = Marks3;

          
            Console.WriteLine("Marks entered------------- ");
            Finder.DisplayMarks();
            Console.WriteLine("Total : " + Finder.GetTotal());
            Console.WriteLine("Average : " + Finder.GetAverage());
            Console.WriteLine("Result : " + Finder.GetResult());

            Console.ReadLine();
        }
    }
}
