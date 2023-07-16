using System;
namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
   public class Loan_Account : BankAccount, IBankAccount, ITransaction
    {
        public double interestrate;
        public int account_type = 0;
        
        

        public Loan_Account(string person_name, int acc_num, double bal, double interrate) : base(
             person_name, acc_num,  bal, 0)
        {
           
            interestrate = interrate;
           
        }

        public override void deposit(double deposited)
        {
            
            // throw new NotImplementedException();
        }

        public void  deposit(double deposited, double interestrate)
        {
            double interest = 0;
            interest = balance * interestrate;
            balance = balance + interest;
            balance -= deposited;
            Console.WriteLine("Account holder:"+ AccountHolder_name+"has to pay back "+deposited+ "with interest rate"+interestrate+ "and had to pay "+balance+"more money.");

        }

        public override void withdraw(double withdrawl_amount)
        {
            // Console.WriteLine("Tell bank the loan amount");
            // int loanamount = int.Parse(Console.ReadLine());
            // withdrawl_amount = loanamount;
            // balance = withdrawl_amount;
            // Console.WriteLine("The amount of:"+ balance+ "has been withdrawn");

        }

        public override void Execute_Transaction(double amount, int transaction_type)
        {
            // Console.WriteLine("Enter the transaction type \nEnter 1 for deposit and 0 for withdrawl : ");
            // int transaction_type = int.Parse(Console.ReadLine());
            if (transaction_type == 1)
            {
                if (account_type == 0)
                {
                    Console.WriteLine("Your account is Loan account please enter interest rate ");
                    double interest_rate = double.Parse(Console.ReadLine());
                    deposit(amount, interest_rate);
                }
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
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine(AccountHolder_name);
            Console.WriteLine(Account_number);
            Console.WriteLine(balance);
        }
    }


}