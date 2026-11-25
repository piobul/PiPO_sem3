using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: zwierzę (kropla wypita z rzeki i obecna w organizmie zwierzęcia)
    public class Animal : DropState
    {
        public override string Info() => "Animal: the drop was drunk by an animal and circulates in its body.";

        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("excretion", () => new River()), // wydalona wraca do rzeki
            new Transition("breathing", () => new Cloud())  // wydychana wraca do chmury
        };
    }
}