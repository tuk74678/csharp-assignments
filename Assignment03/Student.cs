namespace Assignment03;

public class Student : Person, IStudentService
{
    private Course[] _courses = new Course[10];
    private char[] _grades =  new char[10];
    private int _courseCount = 0;

    // Constructor initializer, call base class constructor from within a derived class
    public Student(string name, DateTime birthDate)
        : base(name, birthDate, 0)
    {
        
    }
    
}