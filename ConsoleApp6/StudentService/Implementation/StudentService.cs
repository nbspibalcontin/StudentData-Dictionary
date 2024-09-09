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
        public Dictionary<string, Student> studentData = new Dictionary<string, Student>();

        // Add Student 
        public void AddStudent(string studentId, Student student)
        {
            // Check if student already exist in the Dictionary
            if (studentData.ContainsKey(studentId))
            {
                throw new ArgumentException("Student ID already exists.");
            }

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
    }
}
