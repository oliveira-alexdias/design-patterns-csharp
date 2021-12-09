using FactoryMethod.Account;

namespace FactoryMethod.FactoryMethod
{
    // Creator
    public abstract class BankAccountFactory
    {
        // Factory Method
        public abstract BankAccount Create();
    }
}