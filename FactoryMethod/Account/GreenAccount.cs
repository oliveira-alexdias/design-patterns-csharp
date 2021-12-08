namespace FactoryMethod.Account
{
    // Concrete Product
    public class GreenAccount : BankAccount
    {
        public GreenAccount(float overdraftFee, decimal overdraftLimit, decimal monthlyFee)
            : base(overdraftFee, overdraftLimit, monthlyFee)
        {
        }
    }
}