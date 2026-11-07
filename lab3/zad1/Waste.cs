using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Waste : IVisitPort
    {
        protected double volume;
        protected double weight;
        protected double density = 0.01057;
        protected double cost = 200;

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

        public Waste()
        {

        }

        public double VisitPort()
        {
            double visitCost = Volume * cost;
            Volume = 0;

            return visitCost;
        }
    }
}
