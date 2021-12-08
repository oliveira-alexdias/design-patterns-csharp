using System;
using Mediator.Mediator;

namespace Mediator.Client
{
    public class User : BaseUser
    {
        public User(IMediator mediator, string name) : base(mediator)
        {
            Name = name;
        }

        public override void Send(User to, string message)
        {
            Console.WriteLine($"Message from {Name} will be sent to {to.Name}");
            _mediator.Send(this, to, message);
        }

        public override void Receive(User from, string message)
        {
            Console.WriteLine($"{Name} received the following message from {from.Name}: {message}");
        }
    }
}