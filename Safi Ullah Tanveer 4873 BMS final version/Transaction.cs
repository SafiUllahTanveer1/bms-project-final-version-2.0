using System;
namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
    public abstract class Transaction
    {
        private int transaction_id;
        public int transaction_id_gs { get; set; }
        private int transaction_type;
        public int transaction_type_gs { get; set; }
        private double transaction_amount;
        public double transaction_amount_gs { get; set; }
        private int transaction_account;
        public int transaction_account_gs { get; set; }

        public Transaction()
        {
            
        }
        public Transaction(int transactionId,int transactionType, double transactionAmount, int transactionAccount)
        {
            transaction_id_gs = transactionId;
            transaction_type_gs = transactionType;
            transaction_amount_gs = transactionAmount;
            transaction_account_gs = transactionAccount;

        }

        public abstract void print_transaction();

    }
    
    public class actualTransaction:Transaction{
        public actualTransaction()
        {
            
        }
        public actualTransaction(int transactionId, int transactionType, double transactionAmount, int transactionAccount):base(transactionId, transactionType, transactionAmount, transactionAccount)
        {
            
        }
        public override void print_transaction()
        {
            Console.WriteLine("Transaction done by account is : " + transaction_account_gs + "Transaction id is : " + transaction_id_gs + ". Transaction type is : " + transaction_type_gs
                              + ". Transaction amount is : " + transaction_amount_gs);
        }
    }

}