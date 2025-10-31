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
}