namespace Assignment03;

public interface IStudentService: IPersonService
{
    double CalculateGPA();
    void EnrollCourse(Course course, char grade);
}