using System;
using Adapter.Adaptee;
using Adapter.Client;
using Adapter.Target;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[L]egacy or [M]odern?");
            var type = Console.ReadLine();

            if (type == "L")
            {
                new MyApp(new LegacyApi()).Run();
            }
            else if (type == "M")
            {
                Console.WriteLine("Getting data through Apapter...");
                new MyApp(new Adapter.Adapter(new ModernApi())).Run();
            }

            Main(null);
        }
    }
}
