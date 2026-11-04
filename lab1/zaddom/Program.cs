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
        Console.WriteLine($"Employee: {Name} (ID: {employeeId})");
    }
}

public class Operator : Employee
{
    protected int licenseLevel;
    public Operator(string name, int id, int license) : base(name, id)
    {
        licenseLevel = license;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"    Operator, license level: {licenseLevel}");
    }
}

public class ReactorOperator : Operator
{
    public string assignedReactor;

    public ReactorOperator(string name, int id, int license, string reactor) : base(name, id, license)
    {
        assignedReactor = reactor;
    }

    public void MonitorReactor()
    {
        Console.WriteLine($"{Name} is monitoring reactor {assignedReactor}.");
    }
}

public class ShiftSupervisor : Operator
{
    private int teamSize;

    public ShiftSupervisor(string name, int id, int license, int team) : base(name, id, license)
    {
        teamSize = team;
    }

    public void StartShift()
    {
        Console.WriteLine($"{Name} started shift with team of {teamSize} people.");
    }
}

public class SafetyInspector : Employee
{
    protected int inspectionsDone;

    public SafetyInspector(string name, int id, int inspections) : base(name, id)
    {
        inspectionsDone = inspections;
    }

    public void Inspect()
    {
        inspectionsDone++;
        Console.WriteLine($"{Name} has done an inspection no.{inspectionsDone}.");
    }
}

public class RadiationInspector : SafetyInspector
{
    private double maxDoseLimit;

    public RadiationInspector(string name, int id, int inspections, double doseLimit) : base(name, id, inspections)
    {
        maxDoseLimit = doseLimit;
    }

    public void MeasureRadiation(double measured)
    {
        string status = measured <= maxDoseLimit ? "OK" : "TOO HIGH RADIATION";
        Console.WriteLine($"    {Name} measured {measured} mSv (limit {maxDoseLimit}) - {status}.");
    }
}

class Program
{
    static void Main()
    {
        ReactorOperator op = new ReactorOperator("Wojciech Szczęsny", 101, 3, "Reactor A");
        ShiftSupervisor sup = new ShiftSupervisor("Holandia SUPERVISOR", 102, 5, 12);
        RadiationInspector rad = new RadiationInspector("Piotr Zieliński", 201, 7, 20.0);

        op.Describe();
        op.MonitorReactor();

        sup.StartShift();

        rad.Inspect();
        rad.MeasureRadiation(12.5);
        rad.MeasureRadiation(25.0);
    }
}