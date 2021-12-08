namespace FactoryMethod.Account
{
    // Concrete Product
    public class RedAccount : BankAccount
    {
        public RedAccount(float overdraftFee, decimal overdraftLimit, decimal monthlyFee) 
            : base(overdraftFee, overdraftLimit, monthlyFee)
        {
        }
    }
}