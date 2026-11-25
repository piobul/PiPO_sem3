using System;
using System.Collections.Generic;

namespace WaterDrop
{
    // Kontekst wzorca STAN: kropla wody przechowuje swój aktualny stan
    // i deleguje do niego decyzję o możliwych przejściach.
    public class Drop
    {
        // Aktualny stan kropli (publiczny odczyt, zmiana tylko przez Advance)
        public DropState State { get; private set; }

        public Drop()
        {
            State = new Cloud(); // kropla zaczyna swoją historię w chmurze
        }

        // Wykonuje jeden krok symulacji: losuje jedno z przejść dostępnych
        // w aktualnym stanie i zmienia stan kropli. Zwraca nazwę wykonanego procesu.
        public string Advance(Random rng)
        {
            List<Transition> options = State.GetTransitions(); // stan sam mówi, dokąd można przejść
            Transition t = options[rng.Next(options.Count)];   // losowy wybór jednego przejścia
            State = t.Create();                                // utworzenie i ustawienie nowego stanu
            return t.Name;
        }
    }
}