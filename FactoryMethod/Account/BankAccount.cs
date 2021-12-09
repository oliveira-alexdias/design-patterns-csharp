namespace FactoryMethod.Account
{
    // Product
    public abstract class BankAccount
    {
        protected BankAccount(float overdraftFee, decimal overdraftLimit, decimal monthlyFee)
        {
            OverdraftFee = overdraftFee;
            OverdraftLimit = overdraftLimit;
            MonthlyFee = monthlyFee;
        }

        protected float OverdraftFee { get; private set; }
        protected decimal OverdraftLimit { get; private set; }
        protected decimal MonthlyFee { get; private set; }

        public override string ToString()
        {
            return $"{nameof(OverdraftFee)}: {OverdraftFee}%, " +
                   $"{nameof(OverdraftLimit)}: ${OverdraftLimit}, " +
                   $"{nameof(MonthlyFee)}: ${MonthlyFee}";
        }
    }
}