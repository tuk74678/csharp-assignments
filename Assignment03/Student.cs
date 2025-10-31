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
    
    // Adds course
    public void EnrollCourse(Course course, char grade)
    {
        if (_courseCount < _courses.Length)
        {
            _courses[_courseCount] = course;
            _grades[_courseCount] = grade;
            _courseCount++;
            course.EnrollStudent(this);
        }
    }
    
    // Converts grades to GPA scale, override from base class
    public double CalculateGPA()
    {
        if (_courseCount == 0) return 0;

        double totalPoints = 0;
        for (int i = 0; i < _courseCount; i++)
        {
            char grade = _grades[i];
            switch (grade)
            {
                case 'A': totalPoints += 4.0; break;
                case 'B': totalPoints += 3.0; break;
                case 'C': totalPoints += 2.0; break;
                case 'D': totalPoints += 1.0; break;
                default: totalPoints += 0.0; break;
            }
        }
        return totalPoints / _courseCount;
    }

    // Override method from base class
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {CalculateAge()}, GPA: {CalculateGPA():F2}");
    }
    
}