using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class MenuState : GameState
    {
        public MenuState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("[Menu] Rozpoczynam gre.");
            parentApp.ChangeState(new PlayingState(parentApp));
        }

        public override void EscapeButton() { }
        public override void TabButton() { }
        public override void KeyboardInput(string s) { }
    }
}