namespace Assignment03;

public class Instructor: Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
    
    // Constructor
    public Instructor(string name, DateTime birthDate, decimal salary, DateTime joinDate)
        : base(name, birthDate, salary)
    {
        JoinDate = joinDate;
    }
    
    // Calculate experience to today's date
    public int CalculateExperience() => DateTime.Now.Year - JoinDate.Year;
    
    // Calculate the salary
    public override decimal CalculateSalary()
    {
        decimal bonus = (CalculateExperience() * 0.05m) * base.CalculateSalary();
        return base.CalculateSalary() + bonus;
    }
    
    // Override method from base class
    public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor: {Name}, Age: {CalculateAge()}, Salary: {CalculateSalary():C}, Experience: " +
                          $"{CalculateExperience()} yrs");
    }
}