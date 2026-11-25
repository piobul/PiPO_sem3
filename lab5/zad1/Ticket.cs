namespace C5
{
    abstract class Ticket { }

    class MetroTicket : Ticket
    {
        public override string ToString() { return "metro ticket"; }
    }

    class TrainTicket : Ticket
    {
        public override string ToString() { return "train ticket"; }
    }

    class BusTicket : Ticket
    {
        public override string ToString() { return "bus ticket"; }
    }
}