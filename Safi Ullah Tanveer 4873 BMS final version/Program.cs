using System;
using System.Collections.Generic;

namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
   
    class GlobalVariables
    {
        public static int MyGlobalVariable = 1; // The global variable is taken for sequencing of transaction IDs
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bank bank2 = new Bank();
            bank2.Add_Account(); // here the bank object show the polymorphism as it stores diff. types of bank accounts in the bank object.
            bank2.Add_Account();// These func show the perfect example of dependency of bank acc objects on bank obejct.
            bank2.Add_Account();
            bank2.deposit(1000);
            bank2.withdraw(1000);
            bank2.deposit(1000);
            Console.WriteLine("\tTransaction History is as follow : ");
            bank2.print_transaction_history();
            bank2.print_bank_accounts();
        }
    }
}
