using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);
            Console.ReadLine();
        }

        static void StoreData(Employee Emp)
        {
            Console.WriteLine("enter employee id");
            Emp.ID = CustomConsole.ReadInt();
            Console.WriteLine("enter employee name");
            Emp.Name = CustomConsole.ReadString();
            Console.WriteLine("enter gender");
            Emp.Gender = CustomConsole.ReadString();
            Console.WriteLine("enter Address1");
            Emp.Address1 = CustomConsole.ReadString();
            Console.WriteLine("enter Address2");
            Emp.Address2 = CustomConsole.ReadString();
            Console.WriteLine("enter City");
            Emp.city = CustomConsole.ReadString();
            Console.WriteLine("enter Pin Code");
            Emp.pincode = CustomConsole.ReadInt();
            
        }

        static void ShowData(Employee Emp)
        {
            //----------------Display the employee information
            Console.WriteLine("Employee Id : "+  Emp.ID);
            Console.WriteLine("Employee Name : " + Emp.Name);
            Console.WriteLine("Employee Gender : " + Emp.Gender);

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : "+Emp.Address1);
            Console.WriteLine("Address 2 : "+Emp.Address2);
            Console.WriteLine("City : "+Emp.city);
            Console.WriteLine("PinCode : "+Emp.pincode);
            Console.WriteLine("----------------------------------");

        }
    }
}
