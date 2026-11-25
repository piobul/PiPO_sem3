using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class PlayingState : GameState
    {
        public PlayingState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("[Gra] Otwieram czat.");
            parentApp.ChangeState(new ChatState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("[Gra] Wychodze do menu.");
            parentApp.ChangeState(new MenuState(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("[Gra] Otwieram sklep.");
            parentApp.ChangeState(new ShopState(parentApp));
        }

        public override void KeyboardInput(string s) { }
    }
}