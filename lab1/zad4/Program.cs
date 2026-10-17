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

        // Bird mySecondBigBird = new Bird("Tweety", 5);                        // Błąd kompilacji - klasy nie dziedziczą bezpośrednio konstruktorów
        // Flamingo mySecondPinkFlamingo = new Flamingo("Pinky", 10);           // Błąd kompilacji - klasy nie dziedziczą bezpośrednio konstruktorów
    }
}