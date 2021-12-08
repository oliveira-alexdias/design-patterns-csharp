using System;

namespace TemplateMethod.Template
{
    public class TraditionalHouseBluePrinter : HouseBluePrinter
    {
        protected override void AddWindow()
        {
            Console.WriteLine("Adding a wood window...");
        }

        protected override void AddDoor()
        {
            Console.WriteLine("Adding a wood door...");
        }
    }
}