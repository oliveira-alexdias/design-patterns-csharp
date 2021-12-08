using System;

namespace ChainOfResponsability.Handler
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual void Handle(decimal request)
        {
            _nextHandler?.Handle(request);
        }

        protected void Log(decimal request, string approver)
        {
            Console.WriteLine($"The investiment of $ {request} has been approved by {approver.Replace("Handler", string.Empty)}");
        }
    }
}