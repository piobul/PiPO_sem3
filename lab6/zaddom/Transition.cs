using System;

namespace WaterDrop
{
    // Opisuje jedno przejście między stanami kropli
    // Przechowuje nazwę procesu oraz funkcję, która tworzy obiekt stanu docelowego
    public class Transition
    {
        // Nazwa procesu fizycznego odpowiadająca strzałce na diagramie
        public string Name { get; }

        // Fabryka nowego stanu: nowy obiekt powstaje dopiero w momencie wykonania przejścia
        public Func<DropState> Create { get; }

        public Transition(string name, Func<DropState> create)
        {
            Name = name;
            Create = create;
        }
    }
}