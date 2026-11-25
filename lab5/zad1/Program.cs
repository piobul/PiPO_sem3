using System;
using System.Collections.Generic;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Bus("electric", 90));
            myVehicles.Add(new Car("hybrid", 150));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);

            Console.WriteLine();
            List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(),
                new BusFactory(), new CarFactory() };
            foreach (VehicleFactory factory in factories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }

            Console.WriteLine();
            CarRentalService service = new CarRentalService(new CarFactory());
            for (int i = 0; i < 3; i++) service.Rent();

            Console.WriteLine();
            List<TransportFactory> transportFactories = new List<TransportFactory>()
                { new CityTransportFactory(), new IntercityTransportFactory() };
            string[] modes = { "quickest", "cheapest", "convenient" };

            foreach (TransportFactory tf in transportFactories)
            {
                Console.WriteLine("=== " + tf.GetType().Name + " ===");
                foreach (string mode in modes)
                {
                    tf.TravelMode = mode;
                    Vehicle vehicle = tf.CreateVehicle();
                    Ticket ticket = tf.CreateTicket();
                    Console.WriteLine($"[{mode}] {vehicle.GetVehicleType()} | ticket: {(ticket == null ? "none (null)" : ticket.ToString())}");
                }
            }
        }
    }
}