using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] Employees = new Employee[4];
            Employee emp = null;

            string EmpId, Name, dTReport;
            double AllowancePercentage, Basic, HRA;
            int Role;

        
            Console.WriteLine("Enter employee information");

            for (int i = 0; i < Employees.Length; i++)
            {
                Employees[i] = new Employee();
                Console.WriteLine("Employee No : " + (i+1));
                Console.Write("Id : ");
                Employees[i].EmpId = CustomConsole.ReadString();

                Console.Write("Name : ");
                Employees[i].Name = CustomConsole.ReadString();

                Console.Write("Basic : ");
                Employees[i].Basic = CustomConsole.ReadDouble();

                Console.Write("HRA : ");
                Employees[i].HRA = CustomConsole.ReadDouble();

                Console.Write("Percentage of Allowance : ");
                Employees[i].AllowancePercentage = CustomConsole.ReadDouble();

                Console.WriteLine("Enter Role Id : ");
                Console.WriteLine(Roles.DEVELOPER + ". " + EmployeeReport.RoleDesc((int)Roles.DEVELOPER));
                Console.WriteLine(Roles.TEST_ENGINEER + ". " + EmployeeReport.RoleDesc((int)Roles.TEST_ENGINEER));
                Console.WriteLine(Roles.SR_DEVELOPER + ". " + EmployeeReport.RoleDesc((int)Roles.SR_DEVELOPER));
                Console.WriteLine(Roles.DESIGNER + ". " + EmployeeReport.RoleDesc((int)Roles.DESIGNER));
                Role = CustomConsole.ReadInt();

                
            }

            Console.Write("Enter the date of the report (dd/mm/yyyy) : ");
            dTReport = CustomConsole.ReadString();

            EmployeeReport Report = new EmployeeReport(dTReport);
            

            Report.DisplayEmployees(Employees);

            Console.ReadLine();

        }
    }
}
