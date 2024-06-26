namespace ConsoleApp2;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    // public virtual void PerformWork()
    // {
    //    
    // }
    
    public abstract void PerformWork();

    public virtual void VirtualMethodDemo()
    {
        Console.WriteLine("This is a virtual method from a base class");
    }

    public Employee(int id)
    {
        Id = id;
    }
    
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id,decimal biWeeklyPay): base(id)
    {
        BiWeeklyPay = biWeeklyPay;
    }
    public decimal BiWeeklyPay { get; set; }
    public string Benefits { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("Full time employee works 40 hours.");
    }
}

public sealed class PartTimeEmployee : Employee
{
    public PartTimeEmployee(int id): base(id)
    {
        
    }
    public decimal HourlyPay { get; set; }

    public override void PerformWork()
    {
        Console.WriteLine("Part time employee works 20 hours.");
    }
}

public class Manager : FullTimeEmployee
{
    public Manager(int id, decimal biWeeklyPay):base(id, biWeeklyPay)
    {
        
    }
    public decimal ExtraBonus { get; set; }

    public void AttendMeeting()
    {
        Console.WriteLine("Managers have to attend some meetings. ");
    }

    // public override void PerformWork()
    // {
    //     Console.WriteLine("Managers do some work");
    // }
}

