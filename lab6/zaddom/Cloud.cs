using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: chmura (z chmury kropla spada jako opad)
    public class Cloud : DropState
    {
        public override string Info() => "Cloud: the drop floats as water vapour at an altitude of about 2 km.";

        // Z chmury są trzy możliwe opady: na roślinę, do studni lub do rzeki
        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("precipitation", () => new Plant()),
            new Transition("precipitation", () => new Well()),
            new Transition("precipitation", () => new River())
        };
    }
}