using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class AccountManager
    {
     
        public void FillAccountData(Account Acc)
        {
            Console.WriteLine("enter acc number");          //This function was populated and input 
            Acc.AccNo = CustomConsole.ReadString();                 //is taken from the user
            Console.WriteLine("enter name");
            Acc.Name = CustomConsole.ReadString();
            Console.WriteLine("enter balance");
            Acc.Balance = CustomConsole.ReadDouble();
            
        }

      
        public void DisplayAccountData(Account Acc)
        {
            Console.WriteLine();
            Console.WriteLine("AccNo : " + Acc.AccNo);
            Console.WriteLine("Name : " + Acc.Name);
            Console.WriteLine("Balance : " + Acc.Balance);
        }
    }
}
