namespace Assignment03;

public class Course: ICourseService
{
    public string Title { get; set; }
    private Student[] _enrolledStudents = new Student[10];
    private int _studentCount = 0;
}