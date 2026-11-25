using System;

namespace IceCreamApp
{
    class IceCreamFactory
    {
        private int productionMode = 0; // current production mode (0-6)

        // Sets one of seven production modes (0-6)
        public void SetProductionMode(int i)
        {
            if (i < 0 || i > 6) throw new ArgumentOutOfRangeException(nameof(i), "Available production modes: 0-6");
            productionMode = i;
        }

        // Factory method: the kind (and parameters) of the ice cream depends on the current production mode.
        // Seven modes give seven different specials - none of them repeats,
        // and together they cover all four kinds of ice cream.
        public IceCream SpecialOfTheDay()
        {
            switch (productionMode)
            {
                case 0: return new CreamIceCream(8, "vanilla", true, "caramel", false);
                case 1: return new FruitIceCream(7, "strawberry", false, "chocolate");
                case 2: return new Sorbet(6, "lemon");
                case 3: return new ItalianIceCream(9, "vanilla", true, true);
                case 4: return new CreamIceCream(9, "chocolate", false, null, true);
                case 5: return new FruitIceCream(8, "raspberry", true, null);
                default: return new Sorbet(7, "mango"); // mode 6
            }
        }
    }
}