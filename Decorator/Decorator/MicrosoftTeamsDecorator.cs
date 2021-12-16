using System;
using Decorator.Components;

namespace Decorator.Decorator
{
    // Concrete Decorator
    public class MicrosoftTeamsDecorator : NotifyDecorator
    {
        public MicrosoftTeamsDecorator(INotificatorComponent notificator) : base(notificator)
        {
        }

        public override void Send()
        {
            Console.WriteLine("Sending Microsoft Teams message...");
            base.Send();
        }
    }
}