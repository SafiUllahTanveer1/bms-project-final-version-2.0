using System;

namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
    public abstract class BankAccount : IBankAccount //The abstract class is the general class that 
    {
        private string Account_Holder_name; // This is the encapsultaion(encap types are pro, priv)
        public string AccountHolder_name { get; set; }//getter & setter is used to call the variable in other classes.

        private int accountNumber;
        public int Account_number { get; set; }

        private double Balance;
        public double balance { get; set; }

        private int account_type;
        public int account_type_gs { get; set; }


        // public BankAccount() // this is empty or non-parameter construtor is made to initialize the objects 
        // {
        //
        // }

        public BankAccount(string person_name, int acc_num, double bal, int accountType)
        {
            Console.WriteLine("Person name in Bank account is : " + person_name +
                              " and bank balance is : " + bal);
            AccountHolder_name = person_name;
            Account_number = acc_num;
            balance = bal;
            account_type_gs = accountType;
            Console.WriteLine("After assignment in bank account class : " + 
                              "person name is : " + AccountHolder_name + 
                              " account number is " + Account_number + " balance is : " 
                              + balance);
        }

        public abstract void deposit(double deposited);


        public abstract void withdraw(double withdrawl_amount);


        public abstract void DisplayAccountInfo();
        
        public abstract void Execute_Transaction(double amount, int transaction_type);
        
        public abstract void Print_Transaction(int transaction_type, double transaction_amount);
        
        



    }

}