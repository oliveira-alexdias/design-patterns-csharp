using System;
using Command.Command;

namespace Command.Invoker
{
    public class OldestKidInvoker
    {
        private ICommand _chocolateCakeCommand;

        public OldestKidInvoker(ICommand chocolateCakeCommand)
        {
            _chocolateCakeCommand = chocolateCakeCommand;
        }

        public void Execute()
        {
            Console.WriteLine($"The oldest kid received the following command {_chocolateCakeCommand?.GetType().Name} " +
                              $"and once he does now know how to cook it, he will ask grandmother do cook it...\n");

            _chocolateCakeCommand?.Execute();
        }
    }
}