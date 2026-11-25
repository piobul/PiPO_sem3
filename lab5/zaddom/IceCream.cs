using System;

namespace IceCreamApp
{
    abstract class IceCream
    {
        protected int price;
        protected string flavor;

        public IceCream(int price, string flavor)
        {
            if (price < 0) throw new ArgumentException("Price cannot be negative");
            this.price = price;
            this.flavor = flavor;
        }

        public abstract string GetKind();

        protected static string DescribeCone(bool inCone) { return inCone ? "in a cone" : "without a cone"; }
        protected static string DescribeTopping(string topping) { return string.IsNullOrEmpty(topping) ? "none" : topping; }

        public override string ToString()
        {
            return $"{GetKind()}, flavor: {flavor}, price: {price} PLN";
        }
    }

    // Cream ice cream: cone + topping + chocolate sprinkles
    class CreamIceCream : IceCream
    {
        private bool inCone;
        private string topping;      // null or "" means no topping
        private bool chocolateSprinkles;

        public CreamIceCream(int price, string flavor, bool inCone, string topping, bool chocolateSprinkles) : base(price, flavor)
        {
            this.inCone = inCone;
            this.topping = topping;
            this.chocolateSprinkles = chocolateSprinkles;
        }

        public override string GetKind() { return "Cream ice cream"; }

        public override string ToString()
        {
            return base.ToString() + $", {DescribeCone(inCone)}, topping: {DescribeTopping(topping)}, chocolate sprinkles: {(chocolateSprinkles ? "yes" : "no")}";
        }
    }

    // Fruit ice cream: cone + topping (no sprinkles)
    class FruitIceCream : IceCream
    {
        private bool inCone;
        private string topping;

        public FruitIceCream(int price, string flavor, bool inCone, string topping) : base(price, flavor)
        {
            this.inCone = inCone;
            this.topping = topping;
        }

        public override string GetKind() { return "Fruit ice cream"; }

        public override string ToString()
        {
            return base.ToString() + $", {DescribeCone(inCone)}, topping: {DescribeTopping(topping)}";
        }
    }

    // Sorbet: only price and flavor (no cone, topping or sprinkles)
    class Sorbet : IceCream
    {
        public Sorbet(int price, string flavor) : base(price, flavor) { }

        public override string GetKind() { return "Sorbet"; }
    }

    // Italian ice cream: cone + chocolate sprinkles (no topping)
    class ItalianIceCream : IceCream
    {
        private bool inCone;
        private bool chocolateSprinkles;

        public ItalianIceCream(int price, string flavor, bool inCone, bool chocolateSprinkles) : base(price, flavor)
        {
            this.inCone = inCone;
            this.chocolateSprinkles = chocolateSprinkles;
        }

        public override string GetKind() { return "Italian ice cream"; }

        public override string ToString()
        {
            return base.ToString() + $", {DescribeCone(inCone)}, chocolate sprinkles: {(chocolateSprinkles ? "yes" : "no")}";
        }
    }
}