using ConsoleApp6.StudentService.Implementation;
using ConsoleApp6.StudentService;
using ConsoleApp6.StudentService.Interface;

public class Program
{
    private static readonly IStudent studentService = new StudentService();

    public static void Main(string[] args)
    {
        // Add Student Details
        studentService.AddStudent("A001", new Student("Alice", 85));
        studentService.AddStudent("B002", new Student("Bob", 92));

        // Display all student details
        studentService.DisplayAllStudents();
    }
}