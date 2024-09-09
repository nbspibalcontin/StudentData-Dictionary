using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.StudentService.Interface
{
    public interface IStudent
    {
        void AddStudent(string studentId, Student student);
        void DisplayAllStudents();
    }
}
