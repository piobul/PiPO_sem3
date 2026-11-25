using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Czesc 1: wzorzec Stan ---
            GameApp game = new GameApp();
            game.EnterButton();             // menu -> gra
            game.TabButton();               // gra -> sklep
            game.KeyboardInput("miecz");    // wyszukiwanie itemu
            game.EnterButton();             // sklep -> czat
            game.KeyboardInput("czesc!");   // wiadomosc na czacie
            game.EscapeButton();            // czat -> gra
            game.EscapeButton();            // gra -> menu

            Console.WriteLine();

            // --- Czesc 2: wzorzec Strategia ---
            Sorter mySorter = new Sorter();
            List<int> myList = new List<int>() { 6, 2, 3, 5, 1 };

            mySorter.SetAlgorithm(new InsertionSort());
            foreach (int i in mySorter.Sort(myList)) Console.Write(i + " ");
            Console.WriteLine();

            // podmiana strategii w trakcie dzialania programu
            mySorter.SetAlgorithm(new SelectionSort());
            foreach (int i in mySorter.Sort(myList)) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}