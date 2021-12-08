namespace FactoryMethod.Account
{
    // Concrete Product
    public class GreyAccount : BankAccount
    {
        public GreyAccount(float overdraftFee, decimal overdraftLimit, decimal monthlyFee)
            : base(overdraftFee, overdraftLimit, monthlyFee)
        {
        }
    }
}