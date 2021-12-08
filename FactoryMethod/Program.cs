using System;
using FactoryMethod.Account;
using FactoryMethod.FactoryMethod;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var clientName = GetClientName();
            var salary = GetSalary();

            var bankAccount = BankAccountService.GetAccount(salary);

            ShowResult(clientName, bankAccount);

            Main(null);
        }

        private static string GetClientName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nClient's First Name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            return Console.ReadLine();
        }

        private static decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSalary:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal.TryParse(Console.ReadLine(), out var salary);
            return salary;
        }

        private static void ShowResult(string clientName, BankAccount bankAccount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{clientName} has a {bankAccount.GetType().Name}. Account details: {bankAccount}\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------");
        }
    }
}
