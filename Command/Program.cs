using Command.Client;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // CLIENT: Group of kids
            // INVOKER: The oldest kid
            // RECEIVER: Grandmother
            // COMMAND: Cook a chocolate cake
            GroupOfKidsClient.Run();
        }
    }
}
