using System;
using Decorator.Components;

namespace Decorator.Decorator
{
    // Concrete Decorator
    public class SmsDecorator : NotifyDecorator
    {
        public SmsDecorator(INotificatorComponent notificator) : base(notificator)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Sending SMS...");
            base.Send();
        }
    }
}