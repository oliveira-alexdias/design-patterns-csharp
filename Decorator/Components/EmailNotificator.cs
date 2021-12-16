using System;

namespace Decorator.Components
{
    // Concrete Component
    public class EmailNotificator : INotificatorComponent
    {
        public virtual void Send()
        {
            Console.WriteLine("Send Email message...");
        }
    }
}