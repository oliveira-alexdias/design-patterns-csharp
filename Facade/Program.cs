using System;
using Facade.Entity;
using Facade.Facade;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var buyer = GetBuyer();
            var product = GetProduct();
            
            Console.WriteLine($"Creating a payment for {product.Name} by {buyer.FirstName}");

            var paymentFacade = new PaymentFacade();
            paymentFacade.Pay(buyer, product);

            Console.WriteLine($"Payment for {product.Name} by {buyer.FirstName} has been completed");
        }

        private static Buyer GetBuyer()
        {
            return new Buyer(Guid.NewGuid(), "John", "O'Brien", "john.obrien@email.com",
                   new Address("Rua São José de Anchieta", "8", "Vitória", "Espírito Santo", "24123-999"));
        }

        private static Product GetProduct()
        {
            return new Product("Hat", 1, 20);
        }
    }
}
