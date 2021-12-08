namespace FactoryMethod.Account
{
    // Concrete Product
    public class BlueAccount : BankAccount
    {
        public BlueAccount(float overdraftFee, decimal overdraftLimit, decimal monthlyFee)
            : base(overdraftFee, overdraftLimit, monthlyFee)
        {
        }
    }
}