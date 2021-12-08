using System;

namespace TemplateMethod.Template
{
    public abstract class HouseBluePrinter
    {
        public void GenerateBluePrint()
        {
            Console.WriteLine($"Generating blueprint for {this.GetType().Name}...");

            AddRoom();
            AddBathroom();
            AddCorridor();
            AddGarage();
            
            Console.WriteLine("Blueprint has been generate successfuly!");
        }

        protected void AddRoom()
        {
            Console.WriteLine("Adding room...");
            AddWindow();
            AddDoor();
        }

        protected abstract void AddWindow();

        protected abstract void AddDoor();

        protected void AddBathroom()
        {
            AddBath();
        }

        // Hook method
        protected virtual void AddBath()
        {
        }

        protected void AddCorridor()
        {
            Console.WriteLine("Adding corridor...");
        }

        // Hook method
        protected virtual void AddGarage()
        {
        }
    }
}