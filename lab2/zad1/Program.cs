using System;

public abstract class Vehicle
{
    public virtual string GetVehicleType()
    {
        return "unspecified vehicle";
    }
}

/*      
        override -> train, train                typ obiektu w pamięci
        new -> train, unspecified               typ zmiennej
        {brak} -> train, unspecified            typ zmiennej + warning
*/

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
