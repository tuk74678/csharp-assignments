namespace Assignment03;

// Abstract base class represent generic person(base for student and instructor).
// Use 4 principles of OOP: Encapsulation, Abstraction, Inheritance, Polymorphism
// Define a general template for people.

public abstract class Person : IPersonService
{
    // use _ to avoid confusion when creating constructor
    private string _name;
    private DateTime _dateOfBirth;
    private string[] _addresses = new string[10];
    private decimal _salary;
    private int _addressCount = 0;
    
    // Constructor
    protected Person(string name, DateTime dateOfBirth, decimal salary)
    {
        _name = name;
        _dateOfBirth = dateOfBirth;
        _salary = salary;
    } 
    
    // get and set methods
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public DateTime BirthDate
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            _salary = value;
        }
    }

    public void AddAddress(string address)
    {
        if (_addressCount < _addresses.Length)
            _addresses[_addressCount++] = address;
    }

    public void ShowAddresses()
    {
        for (int i = 0; i < _addressCount; i++)
            Console.WriteLine($"Address {i + 1}: {_addresses[i]}");
    }
    public int CalculateAge() => DateTime.Now.Year - _dateOfBirth.Year;
    
    // Example of polymorphism 
    public virtual decimal CalculateSalary() => Salary;

    // Example of polymorphism
    public abstract void DisplayInfo();
}