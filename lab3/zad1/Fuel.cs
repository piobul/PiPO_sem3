using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal abstract class Fuel : ITransportable
    {
        protected double volume;
        protected double weight;
        protected double density;
        public abstract string Type { get; }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density;
            }
        }
    }
}
