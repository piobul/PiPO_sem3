using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    internal class Scientist : Human
    {
        private Equipment equipment;

        public Scientist(Equipment equip)
        {
            equipment = equip;
        }

        public void Work(double time)
        {
            // Interpretacja zbierania danych co 24h - wykonujemy raz na początku podróży i potem co 24h
            int iter = 1 + (int)(time / 24);

            for(int i = 0; i < iter; i++)
            {
                Console.WriteLine(equipment.GatherData());
            }
        }
    }
}
