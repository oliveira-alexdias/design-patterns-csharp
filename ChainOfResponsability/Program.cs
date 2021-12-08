using ChainOfResponsability.Client;
using ChainOfResponsability.ConcreteHandler;

namespace ChainOfResponsability
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Supervisor is the first handler in the Chain
            var supervisor = new SupervisorHandler();
            var manager = new ManagerHandler();
            var director = new DirectorHandler();
            var president = new PresidentHandler();

            // Chain of Responsability
            supervisor.SetNext(manager)
                      .SetNext(director)
                      .SetNext(president);

            ApprovementClient.Run(supervisor);
        }
    }
}
