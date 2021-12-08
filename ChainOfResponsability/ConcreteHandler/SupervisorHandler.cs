using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
    public class SupervisorHandler : BaseHandler
    {
        public override void Handle(decimal request)
        {
            if (request <= 1000) Log(request, this.GetType().Name);
            else base.Handle(request);
        }
    }
}