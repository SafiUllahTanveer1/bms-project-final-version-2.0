using System;
namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
   public class Checking_Account : BankAccount, IBankAccount, ITransaction
   {
       public int account_type = 2;

        public Checking_Account(string person_name, int acc_num, double bal) : base(person_name, acc_num, bal, 2)
        {

        }

        public override void deposit(double deposited)
        {
            Console.WriteLine("\tCHECKING ACCOUNTS DEPOSIT FUNCTION.");
            Console.WriteLine("Amount for deposit is : " + deposited);
            Console.WriteLine("Balance before from account holder " + AccountHolder_name + " deposit is : " + balance);
            balance += deposited;
            Console.WriteLine("Balance after from account holder " + AccountHolder_name + "deposit is " + balance);
        }

        public override void withdraw(double withdrawl_amount)
        {
            Console.WriteLine("\tCHECKING ACCOUNTS WITHDRAW FUNCTION.");
            if (withdrawl_amount <= balance)
            {
                Console.WriteLine("Amount to withdrawn is : " + withdrawl_amount);
                Console.WriteLine("Balance before from account holder " + AccountHolder_name + " withdraw is : " +
                                  balance);
                balance -= withdrawl_amount;
                Console.WriteLine("Balance after from account holder " + AccountHolder_name + " withdraw is : " +
                                  balance);
                DisplayAccountInfo();
            }
            else
            {
                Console.WriteLine("You don't have sufficient amount");
                DisplayAccountInfo();
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine(AccountHolder_name);
            Console.WriteLine(Account_number);
            Console.WriteLine(balance);
        }

        public override void Execute_Transaction(double amount, int transaction_type)
        {
            // Console.WriteLine("Enter the transaction type \nEnter 1 for deposit and 0 for withdrawl : ");
            // int transaction_type = int.Parse(Console.ReadLine());
            if (transaction_type == 1)
            {
                deposit(amount);
                Print_Transaction(transaction_type, amount);
            }
            else if (transaction_type == 0)
            {
                withdraw(amount);
                Print_Transaction(transaction_type, amount);
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
            // throw new NotImplementedException();
        }

        public override void Print_Transaction(int transaction_type, double transaction_amount)
        {
            string my_transaction_type = "";
            if (transaction_type == 1)
            {
                my_transaction_type = "Deposit";
            }
            else
            {
                my_transaction_type = "Withdrawl";
            }
            Console.WriteLine("Transaction was done from Account number : " + Account_number + ". Transaction type " +
                              "is " + my_transaction_type + ". Transaction amount is : " + transaction_amount + "" +
                              ". Now updated balance is " + balance);
            // throw new NotImplementedException();
        }
    }
}