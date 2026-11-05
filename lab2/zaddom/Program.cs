/*
 * Hierarchia klas w projekcie
 * 
 * Resident
 * ├── Civilian
 * └── Defender
 *      ├── Crossbowman
 *      └── Pikeman
*/

using System;
using System.Collections.Generic;

// Interfejs dla metody ReadyToFight, bo każdy obrońca musi mieć tą metode
// zaimplementowaną

public interface IReadyToFight
{
    string ReadyToFight();
}

// Klasa bazowa mieszkaniec, abstrakcyjna bo nie ma potrzeby tworzenia obiektów
// tej klasy (obiekty tworzymy z klas pochodnych)

public abstract class Resident
{
    protected string name;
    protected int foodUnits;

    // Konstruktor dla mieszkańca z walidacją danych
    public Resident(string name, int foodUnits)
    {
        if(foodUnits < 0)
        {
            throw new ArgumentException("Food units cannot be negative");
        }

        this.name = name;
        this.foodUnits = foodUnits;
    }

    // Eat() nie jest virtual bo jest takie samo dla wszystkich klas

    public int Eat()
    {
        return foodUnits;
    }

    // override bo ToString() nadpisuje metode z klasy object

    public override string ToString()
    {
        return "Resident " + name;
    }
}

// Klasa cywil dziedzicząca po mieszkańcu

public class Civilian : Resident
{
    public Civilian(string name, int foodUnits) : base(name, foodUnits) { }

    public override string ToString()
    {
        return "Civilian " + name;
    }
}

// Klasa obrońca dziedzicząca po mieszkańcu z interfejsem IReadyToFight, nie
// jest abstrakcyjna bo mogą istnieć inni obrońcy

public class Defender : Resident, IReadyToFight
{
    protected string weapon;
    public Defender(string name, int foodUnits, string weapon) : base(name, foodUnits) 
    {
        this.weapon = weapon;
    }

    // virtual daje domyślny komunikat, który inni obrońcy nadpisują

    public virtual string ReadyToFight()
    {
        return "My " + weapon + " is ready to conquer, sir!";
    }

    public override string ToString()
    {
        return "Defender " + name;
    }
}

public class Crossbowman : Defender
{
    public Crossbowman(string name, int foodUnits, string weapon) : base(name, foodUnits, weapon) { }
    public override string ReadyToFight()
    {
        return "My " + weapon + " is ready for piercing, sir!";
    }

    public override string ToString()
    {
        return "Crossbowman, " + base.ToString();
    }
}

public class Pikeman : Defender
{
    public Pikeman(string name, int foodUnits, string weapon) : base(name, foodUnits, weapon) { }
    public override string ReadyToFight()
    {
        return "My " + weapon + " is ready for thrusting, sir!";
    }

    public override string ToString()
    {
        return "Pikeman, " + base.ToString();
    }
}

class Program
{
    static void Main()
    {
        // W poniższych listach te same obiekty trafiają do różnych list, bo np
        // Leokadiusz jest kusznikiem, obrońcą i mieszkańcem.

        // Kusznicy
        Crossbowman c1 = new Crossbowman("Leokadiusz", 30, "Przeklęta Kusza");
        Crossbowman c2 = new Crossbowman("Arkadiusz", 20, "Kusza Cierpienia");
        Crossbowman c3 = new Crossbowman("Mariusz", 10, "Kusza Znachora");

        // Pikinierzy
        Pikeman p1 = new Pikeman("Bogumił", 25, "Włócznia Gromu");
        Pikeman p2 = new Pikeman("Cyprian", 22, "Pika Zagłady");
        Pikeman p3 = new Pikeman("Dobromir", 18, "Długa Pika");

        // Obrońca
        Defender d1 = new Defender("Mareczek", 10, "Mieczor Spustoszenia");

        // Cywile
        Civilian v1 = new Civilian("Eustachy", 15);
        Civilian v2 = new Civilian("Fryderyka", 12);
        Civilian v3 = new Civilian("Genowefa", 14);

        List<Crossbowman> crossbowmenList = new List<Crossbowman> {c1, c2, c3};

        List<Defender> defenderList = new List<Defender>();
        defenderList.AddRange(crossbowmenList);
        defenderList.Add(p1);
        defenderList.Add(p2);
        defenderList.Add(p3);
        defenderList.Add(d1);

        List<Resident> residentList = new List<Resident>();
        residentList.AddRange(defenderList);
        residentList.Add(v1);
        residentList.Add(v2);
        residentList.Add(v3);

        // Wyświetlenie mieszkańców
        Console.WriteLine("   Mieszkańcy");
        foreach (Resident r in residentList)
        {
            Console.WriteLine(r + " | food units: " + r.Eat());
        }

        // Wyświetlenie ekipy kuszników
        Console.WriteLine("\n   Kusznicy");
        foreach(Crossbowman c in crossbowmenList)
        {
            Console.WriteLine(c.ReadyToFight());
        }

        // Wyświetlenie ekipy obrońców, d ma typ Defender, ale wywoła się wersja
        // z klasy rzeczywistej obiektu.

        Console.WriteLine("\n   Obrońcy");
        foreach(Defender d in defenderList)
        {
            Console.WriteLine(d.ReadyToFight());
        }
    }
}