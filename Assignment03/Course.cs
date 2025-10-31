namespace Assignment03;

public class Course: ICourseService
{
    public string Title { get; set; }
    private Student[] _enrolledStudents = new Student[10];
    private int _studentCount = 0;
    
    public Course(string title)
    {
        Title = title;
    }

    public void EnrollStudent(Student student)
    {
        if (_studentCount < _enrolledStudents.Length)
            _enrolledStudents[_studentCount++] = student;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course: {Title}, Enrolled Students: {_studentCount}");
    }
}