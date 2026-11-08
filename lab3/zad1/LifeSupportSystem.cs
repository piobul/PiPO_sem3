using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class LifeSupportSystem
    {
        private const double FoodPerPersonHour = 2.0;
        private const double OxygenPerPersonHour = 5.0;
        private const double WastePerPersonHour = 0.2;
        private List<OxygenBottle> oxygenBottles;
        private List<Human> crew;
        private FoodContainer foodContainer;
        private Waste waste;

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            double neededOxygen = crew.Count * travelTime * OxygenPerPersonHour;
            double neededFood = crew.Count * travelTime * FoodPerPersonHour;
            double availableOxygen = 0;

            foreach (OxygenBottle oxB in oxygenBottles)
            {
                availableOxygen += oxB.Volume;
            }

            return availableOxygen >= neededOxygen && foodContainer.Volume >= neededFood;
        }

        public void Run(double travelTime)
        {
            double neededOxygen = crew.Count * travelTime * OxygenPerPersonHour;
            double neededFood = crew.Count * travelTime * FoodPerPersonHour;

            double remainingOxygen = neededOxygen;
            foreach (OxygenBottle oxB in oxygenBottles)
            {
                double taken = Math.Min(remainingOxygen, oxB.Volume);
                oxB.Volume -= taken;
                remainingOxygen -= taken;
            }

            double foodTaken = Math.Min(neededFood, foodContainer.Volume);
            foodContainer.Volume -= foodTaken;
            waste.Volume += crew.Count * travelTime * WastePerPersonHour;
        }
    }
}
