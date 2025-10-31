namespace Assignment03;

public class Instructor: Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
}