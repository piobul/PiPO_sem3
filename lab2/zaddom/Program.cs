using System;
using System.Collections.Generic;

public interface IReadyToFight
{
    string ReadyToFight();
}

public abstract class Resident
{
    protected string name;
    protected int foodUnits;

    public Resident(string name, int foodUnits)
    {
        if(foodUnits < 0)
        {
            throw new ArgumentException("Food units cannot be negative");
        }

        this.name = name;
        this.foodUnits = foodUnits;
    }

    public int Eat()
    {
        return foodUnits;
    }
}

public class Civilian : Resident
{
    public Civilian(string name, int foodUnits) : base(name, foodUnits) { }
}

public abstract class Defender : Resident, IReadyToFight
{
    protected string weapon;
    public Defender(string name, int foodUnits, string weapon) : base(name, foodUnits) 
    {
        this.weapon = weapon;
    }
    public abstract string ReadyToFight();
}

public class Crossbowman : Defender
{
    public Crossbowman(string name, int foodUnits, string weapon) : base(name, foodUnits, weapon) { }
    public override string ReadyToFight()
    {
        return "My crossbow is ready for piercing, sir!";
    }
}

public class Pikeman : Defender
{
    public Pikeman(string name, int foodUnits, string weapon) : base(name, foodUnits, weapon) { }
    public override string ReadyToFight()
    {
        return "My spear is ready for thrusting, sir!";
    }
}

class Program
{
    static void Main()
    {

    }
}