using System;
namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
     public class SavingsAccount : BankAccount, IBankAccount, ITransaction
    {
        public double my_Interest_Rate;
        public int my_time = 0;
        public int account_type = 1;

        public SavingsAccount(string person_name, int acc_num, double bal, double Interest_Rate, int time) : base(
            person_name, acc_num, bal, 1)
        {
            Console.WriteLine("Person name is : " + person_name);
            my_Interest_Rate = Interest_Rate;
            my_time = time;

        }

        public override void deposit(double deposited)
        {
            // base.Deposit(deposit);
            Console.WriteLine("\tSAVING ACCOUNTS DEPOSIT FUNCTION.");
            Console.WriteLine("Amount for deposit is : " + deposited);
            Console.WriteLine("Balance before from account holder " + AccountHolder_name + " deposit is : " + balance);
            balance += deposited * my_Interest_Rate * my_time;
            Console.WriteLine("Balance after from account holder " + AccountHolder_name + " deposit is : " + balance);
        }

        public override void withdraw(double withdrawl_amount)
        {
            Console.WriteLine("\tSAVING ACCOUNTS WITHDRAW FUNCTION.");
            double balance = 1000;
            if (withdrawl_amount < balance)
            {
                balance -= withdrawl_amount;
                Console.WriteLine("aBalance in account after withdrawl is:" + balance);
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
                Console.WriteLine("In execute transaction function of saving account " +
                                  "deposit amount is " + amount);
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