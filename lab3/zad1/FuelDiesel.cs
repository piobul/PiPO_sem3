using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class FuelDiesel : Fuel
    {
        public FuelDiesel()
        {
            density = 0.84;
        }

        public override string Type => "diesel";
    }
}
