using System;
using Adapter.Target;

namespace Adapter.Client
{
    public class MyApp
    {
        private readonly ILegacyApi _legacyApi;

        public MyApp(ILegacyApi legacyApi)
        {
            _legacyApi = legacyApi;
        }

        public void Run()
        {
            var legacy = _legacyApi.Get();

            Console.WriteLine($"Object: {legacy.GetType().Name}. " +
                              $"Quantity: {legacy.str_quantity}. " +
                              $"Type: {legacy.str_type}. " +
                              $"Date: {legacy.str_date}. " +
                              $"Time: {legacy.str_time}.");

            Console.WriteLine("----------------");
        }
    }
}