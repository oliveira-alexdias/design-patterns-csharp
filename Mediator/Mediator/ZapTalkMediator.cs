using System.Collections.Generic;
using Mediator.Client;

namespace Mediator.Mediator
{
    public class ZapTalkMediator : IMediator
    {
        private readonly IList<User> _listOfUser = new List<User>();

        public void Send(User sender, User to, string message)
        {
            if (!to.Name.Equals("All"))
            {
                to.Receive(sender, message);
                return;
            }

            foreach (var user in _listOfUser)
            {
                if (user.Name == sender.Name) continue;
                user.Receive(sender, message);
            }
        }

        public IMediator Register(User user)
        {
            _listOfUser.Add(user);
            return this;
        }
    }
}