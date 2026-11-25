using System.Collections.Generic;

namespace WaterDrop
{
    // Klasa abstrakcyjna wspólna dla wszystkich stanów (wzorzec STAN)
    // Każdy konkretny stan dziedziczy po niej i sam decyduje,
    // jakie informacje zwraca oraz do jakich stanów kropla może z niego przejść
    public abstract class DropState
    {
        // Zwraca wybrane informacje o stanie jako napis
        public abstract string Info();

        // Zwraca listę możliwych przejść ze stanu
        public abstract List<Transition> GetTransitions();
    }
}