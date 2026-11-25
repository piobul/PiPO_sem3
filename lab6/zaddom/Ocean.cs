using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: ocean (kropla zmieszana ze słoną wodą)
    public class Ocean : DropState
    {
        public override string Info() => "Ocean: the drop mixes with salt water, salinity about 3.5%.";

        // Z oceanu paruje do chmury
        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("evaporation", () => new Cloud())
        };
    }
}