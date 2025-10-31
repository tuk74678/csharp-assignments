namespace Assignment03;

public class Department: IDepartmentService
{
    public string Name { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartYear { get; set; }
    public DateTime EndYear { get; set; }
    
    private Course[] _courses = new Course[5];
    private int _courseCount = 0;
    
    // Constructor
    public Department(string name, decimal budget, DateTime startYear, DateTime endYear)
    {
        Name = name;
        Budget = budget;
        StartYear = startYear;
        EndYear = endYear;
    }
    public void AddCourse(Course course)
    {
        if (_courseCount < _courses.Length)
            _courses[_courseCount++] = course;
    }

    public void DisplayDepartmentInfo()
    {
        Console.WriteLine($"Department: {Name}, Budget: {Budget:C}, Head: {Head?.Name}");
    }
    
}