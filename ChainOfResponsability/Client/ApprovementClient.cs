using System;
using ChainOfResponsability.Handler;

namespace ChainOfResponsability.Client
{
    public class ApprovementClient
    {
        public static void Run(BaseHandler handler)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nType the investiment ($) to be approved:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                decimal.TryParse(Console.ReadLine(), out var investiment);

                handler.Handle(investiment);
            }
        }
    }
}