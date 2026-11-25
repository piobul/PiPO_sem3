using System;

namespace IceCreamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            IceCreamFactory factory = new IceCreamFactory();
            IceCreamVendor vendor = new IceCreamVendor(factory);

            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"=== {days[day]} ===");
                factory.SetProductionMode(day); // new day = new production mode
                for (int customer = 0; customer < 3; customer++)
                {
                    vendor.OfferSpecialOfTheDay();
                }
                Console.WriteLine();
            }
        }
    }
}