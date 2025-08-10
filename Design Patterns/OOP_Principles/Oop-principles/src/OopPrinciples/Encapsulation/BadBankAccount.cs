namespace OopPrinciples.Encapsulation
{
    public class BadBankAccount
    {
        // public decimal Balance;
        private decimal Balance;

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
                
            }
            Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount < 0 || amount >= Balance)
            {
                throw new InvalidOperationException("Withdrawal amount must be positive and less than or equal to the balance.");
            }
            Balance -= amount;
            return Balance;
        }
    }
}