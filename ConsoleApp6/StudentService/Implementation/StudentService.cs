using ConsoleApp6.StudentService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.StudentService.Implementation
{
    public class StudentService : IStudent
    {
        // A dictionary to store student data where the key is the student's ID (string) and the value is a Student object.
        private Dictionary<string, Student> studentData = new Dictionary<string, Student>();

        // Add Student 
        public void AddStudent(string studentId, Student student)
        {
            // Validate the input using helper methods
            ValidateStudentId(studentId);
            ValidateStudent(student);

            // Add Student to the Dictionary
            studentData[studentId] = student;
        }

        // Display all student
        public void DisplayAllStudents()
        {
            foreach (var student in studentData)
            {
                Console.WriteLine($"Student ID: {student.Key}, Name: {student.Value.Name}, Grade: {student.Value.Grade}");
            }
        }

        // Separate function to validate Student ID
        private void ValidateStudentId(string studentId)
        {
            // Check if student already exist in the Dictionary
            if (studentData.ContainsKey(studentId))
            {
                throw new ArgumentException("Student ID already exists.");
            }

            if (string.IsNullOrWhiteSpace(studentId))
            {
                throw new ArgumentException("Student ID cannot be null or whitespace.", nameof(studentId));
            }
        }

        // Separate function to validate Student object and its properties
        private static void ValidateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student object cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(student.Name))
            {
                throw new ArgumentException("Student name cannot be null or whitespace.", nameof(student.Name));
            }

            if (student.Grade < 0 || student.Grade > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(student.Grade), "Grade must be between 0 and 100.");
            }
        }
    }
}
