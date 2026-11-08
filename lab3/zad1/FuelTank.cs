using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class FuelTank : IVisitPort
    {
        private Fuel fuel;
        private double Cost
        {
            get
            {
                if (fuel.Type == "diesel") {
                    return 7.2;
                } else if (fuel.Type == "nuclear") {
                    return 5000;
                }
                throw new InvalidOperationException("Invalid fuel type: " + fuel.Type);
            }
        }
        public double MaxCapacity { get; }
        public double Volume
        {
            get { return fuel.Volume; }
            set { fuel.Volume = value; }
        }
        public double Weight
        {
            get { return fuel.Weight; }
            set { fuel.Weight = value; }
        }

        public FuelTank(double maxCapacity, Fuel fuel)
        {
            MaxCapacity = maxCapacity;
            this.fuel = fuel;
        }

        public double VisitPort()
        {
            double visitCost = (MaxCapacity - Volume) * Cost;
            Volume = MaxCapacity;

            return visitCost;
        }

        public string GetFuelType()
        {
            return fuel.Type;
        }
    }
}
