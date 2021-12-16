using Decorator.Components;

namespace Decorator.Decorator
{
    // Decorator  
    public class NotifyDecorator : INotificatorComponent
    {
        private readonly INotificatorComponent notificator;

        public NotifyDecorator(INotificatorComponent notificator)
        {
            this.notificator = notificator;
        }

        public virtual void Send()
        {
            notificator.Send();
        }
    }
}