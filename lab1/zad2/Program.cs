using System;

public class Animal
{
    public string Name { get; set; }
    protected int weight;
    private int age;
}

public class Bird : Animal
{
    public void TestAccess()
    {
        Name = "Ćwirek";
        weight = 5;

        // age = 2;         // Błąd kompilacji - brak dostępu do prywatnej zmiennej z klasy bazowej
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
}

class Program
{
    static void Main()
    {
        Flamingo myPinkFlamingo = new Flamingo();

        myPinkFlamingo.Name = "Donald";

        // myPinkFlamingo.weight = 10;      // Błąd kompilacji - brak dostępu do chronionej zmiennej z klasy bazowej
        // myPinkFlamingo.age = 3;          // Błąd kompilacji - brak dostępu do prywatnej zmiennej z klasy bazowej
    }
}