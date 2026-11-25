using System;

namespace IceCreamApp
{
    class IceCreamVendor
    {
        private IceCreamFactory factory;

        // The vendor gets a factory but never sets its production mode
        // It doesn't know what ice cream will be produced
        public IceCreamVendor(IceCreamFactory factory)
        {
            this.factory = factory;
        }

        public void OfferSpecialOfTheDay()
        {
            IceCream iceCream = factory.SpecialOfTheDay();
            Console.WriteLine("Special of the day: " + iceCream);
        }
    }
}