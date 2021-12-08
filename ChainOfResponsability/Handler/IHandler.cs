namespace ChainOfResponsability.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        void Handle(decimal request);
    }
}