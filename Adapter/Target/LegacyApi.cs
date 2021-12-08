using System;

namespace Adapter.Target
{
    public class LegacyApi : ILegacyApi
    {
        public Legacy Get()
        {
            Console.WriteLine("Getting data from ## old ## endpoint...");

            return new Legacy
            {
                str_quantity = "75",
                str_type = "A",
                str_date = "2011-11-20",
                str_time = "11:20"
            };
        }
    }
}