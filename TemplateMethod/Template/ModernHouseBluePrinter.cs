using System;

namespace TemplateMethod.Template
{
    public class ModernHouseBluePrinter : HouseBluePrinter
    {
        protected override void AddWindow()
        {
            Console.WriteLine("Adding a glass window...");
        }

        protected override void AddDoor()
        {
            Console.WriteLine("Adding a glass door...");
        }

        protected override void AddBath()
        {
            Console.WriteLine("Adding a bath...");
        }

        protected override void AddGarage()
        {
            Console.WriteLine("Adding a garage with light sensor...");
        }
    }
}