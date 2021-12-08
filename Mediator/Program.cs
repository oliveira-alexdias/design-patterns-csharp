using System;
using Mediator.Client;
using Mediator.Mediator;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mediator = new ZapTalkMediator();
            
            var john = new User(mediator, "John");
            var sebastian = new User(mediator, "Sebastian");
            var monica = new User(mediator, "Monica");
            var sabrina = new User(mediator, "Sabrina");

            mediator.Register(john)
                    .Register(sebastian)
                    .Register(monica)
                    .Register(sabrina);

            Console.ForegroundColor = ConsoleColor.Green;
            john.SendBrodcast("Hi Guys! I created this group so we can organize our party.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            monica.Send(sabrina, "Hey, Sabrina. I'm on my way.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            sabrina.Send(john, "Hi, John! Monica has just messaged me. She will be here in some minutes.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
