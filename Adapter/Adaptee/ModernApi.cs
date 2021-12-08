using System;

namespace Adapter.Adaptee
{
    public class ModernApi : IModernApi
    {
        public Modern GetData()
        {
            Console.WriteLine("Getting data from ## new ## endpoint...");

            return new Modern
            {
                Quantity = new Random().Next(0, 100),
                Type = new Random().Next(2) == 0 ? Type.A : Type.B,
                Date = DateTime.Now
            };
        }
    }
}