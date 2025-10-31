namespace Assignment03;

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
    public string Name { get; set;}
    public DateTime DateOfBirth { get;  set;}
    public decimal Salary { get; private set; }
    public void SetSalary(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Salary cannot be negative.");
        Salary = amount;
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

    public virtual decimal CalculateSalary() => Salary;

    public abstract void DisplayInfo();
}