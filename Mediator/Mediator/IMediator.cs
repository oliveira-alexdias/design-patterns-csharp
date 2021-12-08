using Mediator.Client;

namespace Mediator.Mediator
{
    public interface IMediator
    {
        void Send(User sender, User to, string message);
        IMediator Register(User user);
    }
}