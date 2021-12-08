using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
    public class ManagerHandler : BaseHandler
    {
        public override void Handle(decimal request)
        {
            if (request <= 10000) Log(request, this.GetType().Name);
            else base.Handle(request);
        }
    }
}