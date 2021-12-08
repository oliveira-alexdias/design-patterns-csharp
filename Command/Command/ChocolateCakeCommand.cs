using System;
using Command.Receiver;

namespace Command.Command
{
    public class ChocolateCakeCommand : ICommand
    {
        private readonly GrandmotherReceiver _grandmotherReceiver;

        public ChocolateCakeCommand(GrandmotherReceiver grandmotherReceiver)
        {
            this._grandmotherReceiver = grandmotherReceiver;
        }
        public void Execute()
        {
            Console.WriteLine("Grandmother is just about to cook a chocolate cake...\n");
            _grandmotherReceiver.CookChocolateCake();
        }
    }
}