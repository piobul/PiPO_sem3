using System;

namespace C5
{
    abstract class VehicleFactory
    {
        public abstract Vehicle Create();
    }

    class TrainFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            return new Train("electric", 120);
        }
    }

    class BusFactory : VehicleFactory
    {
        public override Vehicle Create()
        {
            return new Bus("electric", 90);
        }
    }

    class CarFactory : VehicleFactory
    {
        private static readonly string[] brands = { "Toyota", "Skoda", "Ford", "Volkswagen", "Tesla" };
        private static readonly string[] engines = { "petrol", "diesel", "hybrid", "electric" };
        private readonly Random random = new Random();

        public override Vehicle Create()
        {
            string brand = brands[random.Next(brands.Length)];
            string engine = engines[random.Next(engines.Length)];
            int year = random.Next(2015, 2025);
            double velocity = random.Next(140, 251);
            return new Car(engine, velocity, 4.5, 5, brand, year);
        }
    }
}