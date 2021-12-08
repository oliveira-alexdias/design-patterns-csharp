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
            Console.WriteLine("We are getting data without Apapter...");
            new MyApp(new LegacyApi()).Run();

            Console.WriteLine("Now we are getting data WITH Apapter...");
            new MyApp(new Adapter.Adapter(new ModernApi())).Run();

            Console.ReadLine();
            Main(null);
        }
    }
}
