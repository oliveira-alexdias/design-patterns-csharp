using FactoryMethod.Account;

namespace FactoryMethod.FactoryMethod
{
    // Concrete Creator
    public class GreenAccountFactory : BankAccountFactory
    {
        // Factory Method
        public override BankAccount Create()
        {
            return new GreenAccount(overdraftFee: 7, overdraftLimit: 3200, monthlyFee: 7);
        }
    }
}