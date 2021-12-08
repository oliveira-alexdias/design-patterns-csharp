using Mediator.Mediator;

namespace Mediator.Client
{
    public abstract class BaseUser
    {
        protected readonly IMediator _mediator;
        
        protected BaseUser(IMediator mediator)
        {
            _mediator = mediator;
        }

        public string Name { get; set; }
        public abstract void Send(User to, string message);
        public abstract void Receive(User from, string message);
        public void SendBrodcast(string message) => Send(new User(_mediator, "All"), message);
    }
}