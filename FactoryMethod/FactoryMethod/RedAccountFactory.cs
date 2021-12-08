using FactoryMethod.Account;

namespace FactoryMethod.FactoryMethod
{
    // Concrete Creator
    public class RedAccountFactory : BankAccountFactory
    {
        // Factory Method
        public override BankAccount Create()
        {
            return new RedAccount(overdraftFee: 5, overdraftLimit: 10350, monthlyFee: 5);
        }
    }
}