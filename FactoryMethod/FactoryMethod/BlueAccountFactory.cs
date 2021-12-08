using FactoryMethod.Account;

namespace FactoryMethod.FactoryMethod
{
    // Concrete Creator
    public class BlueAccountFactory : BankAccountFactory
    {
        // Factory Method
        public override BankAccount Create()
        {
            return new BlueAccount(overdraftFee: 1, overdraftLimit: 30000, monthlyFee: 0);
        }
    }
}