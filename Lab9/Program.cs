using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] Employees = new Employee[4];
            
            Employee emp = null;
            

            string EmpId, Name, ReportDate;
            double AllowancePercentage, Basic, HRA,Allowance;
            int Role;

        
            Console.WriteLine("Enter employee information");

            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine("Employee No : " + (i+1));
                Employees[i] = new Employee();
                Console.Write("Id : ");
                //EmpId = CustomConsole.ReadString();
                Employees[i].EmpId = CustomConsole.ReadString();
                

                Console.Write("Name : ");
                //Name = CustomConsole.ReadString();
                Employees[i].Name = CustomConsole.ReadString();

                Console.Write("Basic : ");
                //Basic = CustomConsole.ReadDouble();
                Employees[i].Basic = CustomConsole.ReadDouble();

                Console.Write("HRA : ");
                //HRA = CustomConsole.ReadDouble();
                Employees[i].HRA = CustomConsole.ReadDouble();

                Console.Write("Percentage of Allowance : ");
                //AllowancePercentage = CustomConsole.ReadDouble();
                Employees[i].AllowancePercentage = CustomConsole.ReadDouble();

                
                
                Console.WriteLine("Enter Role Id : ");
                Console.WriteLine(Roles.DEVELOPER + ". " + RoleBuilder.GetRoleDescription(Roles.DEVELOPER));
                Console.WriteLine(Roles.TEST_ENGINEER + ". " + RoleBuilder.GetRoleDescription(Roles.TEST_ENGINEER));
                Console.WriteLine(Roles.SR_DEVELOPER + ". " + RoleBuilder.GetRoleDescription(Roles.SR_DEVELOPER));
                Console.WriteLine(Roles.DESIGNER + ". " + RoleBuilder.GetRoleDescription(Roles.DESIGNER));
                Employees[i].Role = CustomConsole.ReadInt();

                
            }

            Console.Write("Enter the date of the report (dd/mm/yyyy) : ");
            ReportDate = CustomConsole.ReadString();

            EmployeeReport Report = new EmployeeReport();
            Report.ReportDate = ReportDate;
            Report.DisplayEmployees(Employees);
           
            

            Console.ReadLine();

        }
    }
}
