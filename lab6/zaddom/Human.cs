using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: człowiek (kropla wypita i obecna w organizmie)
    public class Human : DropState
    {
        public override string Info() => "Human: the drop was drunk and is part of the body (about 60% of it is water).";

        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("excretion", () => new TreatmentPlant()), // wydalona trafia do oczyszczalni
            new Transition("breathing", () => new Cloud())           // wydychana wraca do chmury
        };
    }
}