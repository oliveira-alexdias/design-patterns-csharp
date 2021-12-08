using System;
using TemplateMethod.Template;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var traditional = new TraditionalHouseBluePrinter();
            traditional.GenerateBluePrint();

            Console.WriteLine("--------------------------------------------------");

            var modern= new ModernHouseBluePrinter();
            modern.GenerateBluePrint();
        }
    }
}
