using System;

namespace C5
{
    class CityTransportFactory : TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "quickest": return new Metro();
                case "cheapest": return new Bicycle();
                default: return new Car("petrol", 180, 4.5, 5, "Skoda", 2022);
            }
        }

        public override Ticket CreateTicket()
        {
            switch (travelMode)
            {
                case "quickest": return new MetroTicket();
                default: return null;
            }
        }
    }

    class IntercityTransportFactory : TransportFactory
    {
        public override Vehicle CreateVehicle()
        {
            switch (travelMode)
            {
                case "cheapest": return new Bus("diesel", 100);
                default: return new Train("electric", 160);
            }
        }

        public override Ticket CreateTicket()
        {
            switch (travelMode)
            {
                case "cheapest": return new BusTicket();
                default: return new TrainTicket();
            }
        }
    }
}