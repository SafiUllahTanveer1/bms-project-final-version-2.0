using System;
using System.Collections.Generic;

namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
    public class Bank
    {
        public List<BankAccount> BankAccounts; 
        public List<Transaction> transactions;

        public Bank()
        {
            BankAccounts = new List<BankAccount>(); 
            transactions = new List<Transaction>();
        }

        public void Add_Account() // The add account function makes a composition relationship as the bank accounts
        {
            Console.WriteLine("Enter the account holder name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the account number : ");
            int acc_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initial balance : ");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account type. \n Enter 1 for saving account and 0 for checking account and 2 for loan account:");
            int type = int.Parse(Console.ReadLine());
            // here this data storage and data manipulation show the association relation b/w the bank and bank accounts class.
            if (type == 1)
            {
                Console.WriteLine("Enter the interest rate : ");
                double interest = double.Parse(Console.ReadLine());
                Console.WriteLine("Give the time of interest deposits:");
                int time = int.Parse(Console.ReadLine());
                BankAccount accounts = new SavingsAccount(name, acc_num, balance, interest, time);
                BankAccounts.Add(accounts);
                Console.WriteLine("Account info is : ");
                accounts.DisplayAccountInfo();
            }

            if (type == 0)
            {
                BankAccount accounts = new Checking_Account(name, acc_num, balance );
                BankAccounts.Add(accounts);
            }

            if (type == 2)
            {
                double interestrate = 0.1;

                BankAccount accounts = new Loan_Account(name, acc_num, balance, interestrate);
                BankAccounts.Add(accounts);
            }

        }







        public void deposit(double deposited)
        {
            Console.WriteLine("Deposit amount in bank account function deposit : " + deposited);
            Console.WriteLine("Give the Account Number for deposits:");
            int acc = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < BankAccounts.Count; i++)
            {
                if (acc == BankAccounts[i].Account_number)
                {
                    
                    // Console.WriteLine("Enter the amount for deposit : ");
                    // double amount = double.Parse(Console.ReadLine());
                    BankAccounts[i].Execute_Transaction(deposited, 1);
                    Transaction t = new actualTransaction(GlobalVariables.MyGlobalVariable, 1, deposited, acc);
                    // The t object is storing the transaction data is composition we have declared and initialzed the list in the bank class, and transaction memory existenece is dependent on the 
                    // t.transaction_id_gs = GlobalVariables.MyGlobalVariable;
                    GlobalVariables.MyGlobalVariable++;
                    // t.transaction_account_gs = acc;
                    // t.transaction_type_gs = 1;
                    // t.transaction_amount_gs = deposited; 
                    Console.WriteLine("Printing transaction just before adding it in list" +
                                      " ");
                    t.print_transaction();
                    transactions.Add(t);
                }

            }
        }

        public void withdraw(double withdrawl_amount)
        {
            
            Console.WriteLine("Give the Account Number for withdrawl:");
            int acc = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < BankAccounts.Count; i++)
            {
                if (acc == BankAccounts[i].Account_number)
                {
                    // Console.WriteLine("Enter the amount for deposit : ");
                    // double amount = double.Parse(Console.ReadLine());
                    BankAccounts[i].Execute_Transaction(withdrawl_amount, 0);
                    Transaction t = new actualTransaction(GlobalVariables.MyGlobalVariable, 0, withdrawl_amount, acc);
                    // t.transaction_id_gs = GlobalVariables.MyGlobalVariable;
                    GlobalVariables.MyGlobalVariable++;
                    // t.transaction_amount_gs = withdrawl_amount;
                    // t.transaction_account_gs = acc;
                    // t.transaction_type_gs = 0;
                    // t();
                    transactions.Add(t);
                }
            }
        }

        public void print_bank_accounts()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                string accounttype = "";
                if (BankAccounts[i].account_type_gs == 0)
                {
                    accounttype = "Loan Account";
                }
                else if (BankAccounts[i].account_type_gs == 1)
                {
                    accounttype = "Saving Account";
                }
                else
                {
                    accounttype = "Checking Account";
                }
                myDictionary.Add(BankAccounts[i].Account_number, "Account holder is : " + BankAccounts[i].AccountHolder_name
                + " and Account type is : " + accounttype + " and Balance is : " + BankAccounts[i].balance);
            }

            foreach (KeyValuePair<int, string> pair in myDictionary)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

        }
        public void print_transaction_history()
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                transactions[i].print_transaction();
            }
        }
    }
}