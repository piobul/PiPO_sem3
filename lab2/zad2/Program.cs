using System;

public abstract class Vehicle
{
    public virtual string GetVehicleType()
    {
        return "unspecified vehicle";
    }
}

public class Train : Vehicle
{
    public override string GetVehicleType()
    {
        return "train";
    }
}

class Program
{
    static void Main()
    {
        Train t = new Train();
        Vehicle v = new Train();

        Console.WriteLine(t.GetVehicleType());
        Console.WriteLine(v.GetVehicleType());
    }
}
