using System;
using Adapter.Adaptee;
using Adapter.Target;
using Type = Adapter.Adaptee.Type;

namespace Adapter.Adapter
{
    public class Adapter : ILegacyApi
    {
        private readonly IModernApi _modernApi;

        public Adapter(IModernApi modernApi)
        {
            _modernApi = modernApi;
        }

        public Legacy Get()
        {
            Console.WriteLine("Starting Adapter...");
            
            var modern = _modernApi.GetData();
            
            Console.WriteLine("Ending Adapter...");
            
            return new Legacy
            {
                str_type = modern.Type.ToString("G"),
                str_quantity = modern.Quantity.ToString(),
                str_date = modern.Date.ToString("yyyyMMdd"),
                str_time = modern.Date.ToString("HHmm")
            };
        }
    }
}