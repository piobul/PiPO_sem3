/*
    Employee                        (Name, employeeID)
        Operator                    (licenceLevel)
            ReactorOperator         (assignedReactor)
            ShiftSupervisor         (teamSize)
        SafetyInspector             (inspectionsDone)
            RadiationInspector      (maxDoseLimit)
 
 */


using System;

public class Employee
{
    public string Name { get; set; }
    protected int employeeId;

    public Employee(string name, int id)
    {
        Name = name;
        employeeId = id;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"Pracownik: {Name} (ID: {employeeId})");
    }
}

public class Operator : Employee
{
    protected int licenseLevel;

    public Operator(string name, int id, int license)
        : base(name, id)
    {
        licenseLevel = license;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"  Operator, poziom licencji: {licenseLevel}");
    }
}

public class ReactorOperator : Operator
{
    private string assignedReactor;

    public ReactorOperator(string name, int id, int license, string reactor)
        : base(name, id, license)
    {
        assignedReactor = reactor;
    }

    public void MonitorReactor()
    {
        Console.WriteLine($"{Name} monitoruje reaktor {assignedReactor}.");
    }
}

public class ShiftSupervisor : Operator
{
    private int teamSize;

    public ShiftSupervisor(string name, int id, int license, int team)
        : base(name, id, license)
    {
        teamSize = team;
    }

    public void StartShift()
    {
        Console.WriteLine($"{Name} rozpoczyna zmianę z zespołem {teamSize} osób.");
    }
}

public class SafetyInspector : Employee
{
    protected int inspectionsDone;

    public SafetyInspector(string name, int id, int inspections)
        : base(name, id)
    {
        inspectionsDone = inspections;
    }

    public void Inspect()
    {
        inspectionsDone++;
        Console.WriteLine($"{Name} przeprowadził inspekcję nr {inspectionsDone}.");
    }
}

public class RadiationInspector : SafetyInspector
{
    private double maxDoseLimit;

    public RadiationInspector(string name, int id, int inspections, double doseLimit)
        : base(name, id, inspections)
    {
        maxDoseLimit = doseLimit;
    }

    public void MeasureRadiation(double measured)
    {
        string status = measured <= maxDoseLimit ? "w normie" : "PRZEKROCZONA NORMA";
        Console.WriteLine($"{Name}: pomiar {measured} mSv (limit {maxDoseLimit}) - {status}.");
    }
}

class Program
{
    static void Main()
    {
        ReactorOperator op = new ReactorOperator("Jan Kowalski", 101, 3, "Reaktor A");
        ShiftSupervisor sup = new ShiftSupervisor("Anna Nowak", 102, 5, 12);
        RadiationInspector rad = new RadiationInspector("Piotr Zieliński", 201, 7, 20.0);

        op.Describe();
        op.MonitorReactor();

        sup.StartShift();

        rad.Inspect();
        rad.MeasureRadiation(12.5);
        rad.MeasureRadiation(25.0);
    }
}