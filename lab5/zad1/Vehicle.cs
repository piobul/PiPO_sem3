using System;

namespace C5
{
    public abstract class Vehicle
    {
        protected string engineType;
        protected double maxVelocity;
        protected double length;
        protected int maxSeats;

        public Vehicle(string engine, double velocity, double len, int seats)
        {
            if (velocity < 0) throw new ArgumentException("Velocity cannot be negative");
            if (len < 0) throw new ArgumentException("Length cannot be negative");
            if (seats < 0) throw new ArgumentException("Seats number cannot be negative");

            engineType = engine;
            maxVelocity = velocity;
            length = len;
            maxSeats = seats;
        }

        public virtual string GetVehicleType()
        {
            return "unspecified vehicle";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + ". Engine: " + engineType + ", max velocity: " + maxVelocity + " km/h, length: " + length + " m, seats: " + maxSeats;
        }
    }

    public class Train : Vehicle
    {
        public Train(string engine, double velocity, double length, int seats) : base(engine, velocity, length, seats) { }
        public Train(string engine, double velocity) : this(engine, velocity, 250.0, 400) { }
        public override string GetVehicleType() { return "train"; }
    }

    public class Bus : Vehicle
    {
        public Bus(string engine, double velocity, double length, int seats) : base(engine, velocity, length, seats) { }
        public Bus(string engine, double velocity) : this(engine, velocity, 12.0, 50) { }
        public override string GetVehicleType() { return "bus"; }
    }

    public class Car : Vehicle
    {
        private string brand;
        private int year;

        public Car(string engine, double velocity, double length, int seats, string brand = "unknown", int year = 0)
            : base(engine, velocity, length, seats)
        {
            this.brand = brand;
            this.year = year;
        }
        public Car(string engine, double velocity) : this(engine, velocity, 4.5, 5) { }

        public override string GetVehicleType() { return "car"; }

        public override string ToString()
        {
            return base.ToString() + ", brand: " + brand + ", year: " + year;
        }
    }

    public class Metro : Vehicle
    {
        public Metro() : base("electric", 80, 110.0, 900) { }
        public override string GetVehicleType() { return "metro"; }
    }

    public class Bicycle : Vehicle
    {
        public Bicycle() : base("none (human powered)", 25, 1.8, 1) { }
        public override string GetVehicleType() { return "bicycle"; }
    }
}