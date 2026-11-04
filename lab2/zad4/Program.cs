using System;

public interface IBuyTicket
{
    void BuyTicket();
}

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

public class Car : Vehicle
{
    public Car(string engine, double velocity, double length, int seats) : base(engine, velocity, length, seats) { }
    public override string GetVehicleType()
    {
        return "car";
    }
}
public class Bus : Vehicle, IBuyTicket
{
    public Bus(string engine, double velocity, double length, int seats) : base(engine, velocity, length, seats) { }
    public override string GetVehicleType()
    {
        return "bus";
    }

    public void BuyTicket()
    {
        Console.WriteLine("Bus ticket - bought");
    }
}

class Program
{
    static void Main()
    {
        IBuyTicket ticket = new Bus("diesel", 150.0, 15.0, 54);
        ticket.BuyTicket();
    }
}
