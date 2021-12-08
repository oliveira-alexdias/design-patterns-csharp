using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
    public class DirectorHandler : BaseHandler
    {
        public override void Handle(decimal request)
        {
            if (request <= 50000) Log(request, this.GetType().Name);
            else base.Handle(request);
        }
    }
}