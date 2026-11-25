using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: rzeka. (kropla może stąd pójść w trzech kierunkach)
    public class River : DropState
    {
        public override string Info() => "River: the drop flows downstream at about 5 km/h.";

        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("flowing into", () => new Ocean()),  // rzeka uchodzi do oceanu
            new Transition("evaporation", () => new Cloud()),   // woda paruje do chmury
            new Transition("drinking", () => new Animal())      // zwierzę pije wodę z rzeki
        };
    }
}