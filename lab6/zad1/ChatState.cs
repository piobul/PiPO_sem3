using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class ChatState : GameState
    {
        public ChatState(GameApp app) : base(app) { }

        public override void EnterButton()
        {
            Console.WriteLine("[Czat] Zamykam czat.");
            parentApp.ChangeState(new PlayingState(parentApp));
        }

        public override void EscapeButton()
        {
            Console.WriteLine("[Czat] Zamykam czat.");
            parentApp.ChangeState(new PlayingState(parentApp));
        }

        public override void TabButton() { }

        public override void KeyboardInput(string s)
        {
            Console.WriteLine("[Czat] Wiadomosc: " + s);
        }
    }
}