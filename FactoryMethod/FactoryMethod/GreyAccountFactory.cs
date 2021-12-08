using FactoryMethod.Account;

namespace FactoryMethod.FactoryMethod
{
    // Concrete Creator
    public class GreyAccountFactory : BankAccountFactory
    {
        // Factory Method
        public override BankAccount Create()
        {
            return new GreyAccount(overdraftFee: 10, overdraftLimit: 2000, monthlyFee: 10);
        }
    }
}