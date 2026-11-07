using zad1;
using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal abstract class Human : ITransportable
    {
        protected double volume;
        protected double weight;

        public Human()
        {
            Volume = 0.08;
        }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 1.05; // assume density equal to 1050 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 1.05; // assume density equal to 1050 kg/m^3 (arbitrary number)
            }
        }
    }
}
