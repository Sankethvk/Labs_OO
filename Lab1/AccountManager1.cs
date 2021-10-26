using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class AccountManager1
    {
     
        public void FillAccountData(Account Acc)
        {
            Acc.AccNo = "004701";  // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
            Acc.Name = "Nitesh";   // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
            Acc.Balance = 45000.0; // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
        }

     
        public void DisplayAccountData(Account Acc) 
        {
		    Console.WriteLine("AccNo : " + Acc.AccNo); // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
            Console.WriteLine("Name : " + Acc.Name);   // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
            Console.WriteLine("Balance : " + Acc.Balance);   // Removed _ so that it is assigned properly to property AccNo not a variable _AccNo
	    }
    }
}
