using System;
using System.Threading;
using Console = System.Console;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // It will be always the same value. Here it is the Singleton.
            Console.WriteLine($"App Running Id: {MyApplication.GetRunningId()} (singleton)");

            // It will change every time
            Console.WriteLine($"App Request Id: {MyApplication.GetRequestId()}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------");
            
            Thread.Sleep(5000);

            Main();
        }
    }
}
