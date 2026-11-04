using System;

public abstract class Vehicle
{
    protected string engineType;
    protected double maxVelocity;
    protected double length;
    protected int maxSeats;

    public Vehicle(string engine, double velocity, double len, int seats)
    {
        if (velocity < 0)
        {
            throw new ArgumentException("Velocity cannot be negative");
        }

        if (len < 0)
        {
            throw new ArgumentException("Length cannot be negative");
        }

        if (seats < 0)
        {
            throw new ArgumentException("Seats number cannot be negative");
        }

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
    public override string GetVehicleType()
    {
        return "train";
    }
}

class Program
{
    static void Main()
    {
        Train t = new Train("electric", 120.0, 250.0, 2);
        Vehicle v = new Train("diesel", 90.0, 10.0, 3);

        Console.WriteLine(t);
        Console.WriteLine(v);
    }
}
