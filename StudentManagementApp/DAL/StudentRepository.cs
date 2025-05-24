using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class StudentRepository
    {
        private readonly MainDbContext _mainDbContext;
        public StudentRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<tblStudents> GetAllStudents()
        {
            return _mainDbContext.tblStudents.ToList();
        }
        public tblStudents AddStudent(tblStudents student)
        {
            _mainDbContext.tblStudents.Add(student);
            _mainDbContext.SaveChanges();
            return student;
        }
        public tblStudents GetStudentById(int studentID)
        {
            return _mainDbContext.tblStudents.Find(studentID);
        }
        public tblStudents UpdateStudent(tblStudents student)
        {
            var existingStudent = _mainDbContext.tblStudents.Find(student.StudentID);
            if (existingStudent == null)
            {
                return null; // Student not found
            }

            // Update the properties
            _mainDbContext.Entry(existingStudent).CurrentValues.SetValues(student);

            _mainDbContext.SaveChanges(); // Save changes to the database
            return existingStudent; // Return updated student
        }

        public tblStudents DeleteStudent(int studentId)
        {
            var result = _mainDbContext.tblStudents.FirstOrDefault(x => x.StudentID == studentId);
            if (result != null)
            {
                _mainDbContext.tblStudents.Remove(result);
                _mainDbContext.SaveChanges();
                return null;
            }
            return result;
        }
    }
}
