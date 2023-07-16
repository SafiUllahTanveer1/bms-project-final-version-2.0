namespace Safi_Ullah_Tanveer_4873_BMS_final_version
{
    public interface ITransaction
    {
        void Execute_Transaction(double amount, int transaction_type);
        void Print_Transaction(int transaction_type, double transaction_amount);
    }

}