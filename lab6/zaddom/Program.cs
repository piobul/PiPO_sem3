using System;
using System.Collections.Generic;

namespace WaterDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Drop drop = new Drop();

            // Zbiór nazw odwiedzonych stanów
            // Count mówi, ile różnych stanów kropla już odwiedziła
            HashSet<string> visited = new HashSet<string>();

            Console.WriteLine("Water drop history:");
            Console.WriteLine("Start -> " + drop.State.Info());
            visited.Add(drop.State.GetType().Name);

            int step = 0;
            // Symulujemy, aż kropla odwiedzi co najmniej 5 różnych stanów
            while (visited.Count < 5 || step < 8)
            {
                string process = drop.Advance(rng); // kolejny losowy krok kropli
                step++;
                visited.Add(drop.State.GetType().Name);
                Console.WriteLine($"Step {step} ({process}) -> {drop.State.Info()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Distinct states visited ({visited.Count}): {string.Join(", ", visited)}");
        }
    }
}