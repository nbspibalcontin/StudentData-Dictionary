using ConsoleApp6.StudentService.Implementation;
using ConsoleApp6.StudentService;
using ConsoleApp6.StudentService.Interface;

public class Program
{
    private static readonly IStudent studentService = new StudentService();

    public static void Main(string[] args)
    {
        try
        {
            // Add Student Details
            studentService.AddStudent("A002", new Student("Alice", 85));
            studentService.AddStudent("A001", new Student("Bob", 92));

            // Display all student details
            studentService.DisplayAllStudents();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ArgumentException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}