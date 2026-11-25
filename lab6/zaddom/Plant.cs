using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: roślina (kropla pobrana przez korzenie)
    public class Plant : DropState
    {
        public override string Info() => "Plant: the drop is absorbed by the roots and carried up the stem.";

        // Roślina oddaje wodę do atmosfery, więc kropla wraca do chmury
        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("breathing", () => new Cloud())
        };
    }
}