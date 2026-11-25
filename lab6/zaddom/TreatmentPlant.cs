using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: oczyszczalnia ścieków (kropla jest filtrowana z zanieczyszczeń)
    public class TreatmentPlant : DropState
    {
        public override string Info() => "TreatmentPlant: the drop is filtered and cleaned of wastewater contaminants.";

        // Oczyszczona woda jest odprowadzana do rzeki
        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("purification", () => new River())
        };
    }
}