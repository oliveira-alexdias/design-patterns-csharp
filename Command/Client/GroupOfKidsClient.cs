using System;
using Command.Command;
using Command.Invoker;
using Command.Receiver;

namespace Command.Client
{
    public static  class GroupOfKidsClient
    {
        public static void Run()
        {
            Console.WriteLine("A group of kids wants a chocolate cake and " +
                              "the oldest kid is the one who will make this happen.\n");
            
            var receiver = new GrandmotherReceiver();
            var command = new ChocolateCakeCommand(receiver);
            var invoker = new OldestKidInvoker(command);

            invoker.Execute();
        }
    }
}
