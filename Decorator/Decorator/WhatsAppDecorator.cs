using System;
using Decorator.Components;

namespace Decorator.Decorator
{
    // Concrete Decorator
    public class WhatsAppDecorator : NotifyDecorator
    {
        public WhatsAppDecorator(INotificatorComponent notificator) : base(notificator)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Sending WhatsApp message...");
            base.Send();
        }
    }
}