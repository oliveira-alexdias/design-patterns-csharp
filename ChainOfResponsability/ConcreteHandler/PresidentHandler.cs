using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
    public class PresidentHandler : BaseHandler
    {
        public override void Handle(decimal request)
        {
            if (request > 50000) Log(request, this.GetType().Name);
        }
    }
}