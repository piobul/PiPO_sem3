using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class ShopState : GameState
    {
        public ShopState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("[Sklep] Otwieram czat.");
            parentApp.ChangeState(new ChatState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("[Sklep] Zamykam sklep.");
            parentApp.ChangeState(new PlayingState(parentApp));
        }

        public override void TabButton()
        {
            Console.WriteLine("[Sklep] Zamykam sklep.");
            parentApp.ChangeState(new PlayingState(parentApp));
        }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine("[Sklep] Szukam itemu: " + s);
        }
    }
}