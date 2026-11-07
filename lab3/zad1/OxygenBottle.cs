using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class OxygenBottle : IVisitPort
    {
        protected double volume;
        protected double weight;
        protected double density = 0.001429;
        protected double cost = 250;
        public double MaxCapacity { get; }

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

        public OxygenBottle(double maxCapacity)
        {
            MaxCapacity = maxCapacity;
        }

        public double VisitPort()
        {
            double visitCost = (MaxCapacity - Volume) * cost;
            Volume = MaxCapacity;

            return visitCost;
        }
    }
}
