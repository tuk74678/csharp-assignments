namespace Assignment03;

public interface IStudentService: IPersonService
{
    double CalculateGPA();      // Compute GPA
    void EnrollCourse(Course course, char grade);       // Add a course and grade
}   