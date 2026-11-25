using System.Collections.Generic;

namespace WaterDrop
{
    // Stan: studnia (kropla w wodach gruntowych)
    public class Well : DropState
    {
        public override string Info() => "Well: the drop sits in groundwater at a depth of about 15 m.";

        // Ze studni wodę może wypić tylko człowiek
        public override List<Transition> GetTransitions() => new List<Transition>
        {
            new Transition("drinking", () => new Human())
        };
    }
}