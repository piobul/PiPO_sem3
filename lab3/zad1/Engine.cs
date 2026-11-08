using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Engine
    {
        private const double VelocityConstant = 44000.0;
        private const double FuelPerHour = 0.1;
        private const double WastePerFuel = 0.5;

        private FuelTank tank;
        private Waste waste;

        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            return VelocityConstant/submarineWeight;
        }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            return (tank.Volume >= (travelTime * FuelPerHour));
        }

        public void Travel(double travelTime)
        {
            double usedFuel = Math.Min(travelTime * FuelPerHour, tank.Volume);
            tank.Volume -= usedFuel;
            waste.Volume += usedFuel * WastePerFuel;
        }
    }
}
