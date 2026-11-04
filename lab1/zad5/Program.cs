using System;

public class Animal
{
    public string Name { get; set; }
    protected int weight;
    private int age;

    public Animal()
    {
        Name = "Unknown";
        weight = 0;
    }

    public Animal(string name, int weight)
    {
        Name = name;
        this.weight = weight;
    }
}

public class Bird : Animal
{
    protected int numberOfFeathers;

    public Bird() : base()
    {
        numberOfFeathers = 0;
    }

    public Bird(string _name, int _weight, int _feathers) : base(_name, _weight)
    {
        numberOfFeathers = _feathers;
    }

    public void TestAccess()
    {
        Name = "Ćwirek";
        weight = 5;

        // age = 2;         // Błąd kompilacji - brak dostępu do prywatnej zmiennej z klasy bazowej
    }

    public void LayEggs(int eggsNum)
    {
        Console.WriteLine($"Laid eggs. Egg count: {eggsNum}");
    }
}

public class Flamingo : Bird
{
    public Flamingo() : base() { }
    public Flamingo(string _name, int _weight, int _feathers) : base(_name, _weight, _feathers) { }
    public void TestAccess()
    {
        Name = "Różowy Ćwirek";
        weight = 5;

        // age = 2;         // Błąd kompilacji - brak dostępu do prywatnej zmiennej z klasy bazowej
    }

    public void Incubation(int eggsNum, int days)
    {
        LayEggs(eggsNum);
        Console.WriteLine($"Started eggs incubation. New pests in: {days} days.");
    }
}

class Program
{
    static void Main()
    {
        Bird myBigBird = new Bird();
        Flamingo myPinkFlamingo = new Flamingo();

        Bird mySecondBigBird = new Bird("Tweety", 5, 1000);
        Flamingo mySecondPinkFlamingo = new Flamingo("Pinky", 10, 20000);

        mySecondPinkFlamingo.Incubation(2, 30);
    }
}

// Teraz program kompiluje sie, ponieważ każda z klas ma swoje konstruktory