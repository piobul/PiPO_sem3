using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class FuelNuclear : Fuel
    {
        public FuelNuclear()
        {
            density = 10.97;
        }

        public override string Type => "nuclear";
    }
}
