using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }
        public List<tblStudents> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }
        public tblStudents AddStudent(tblStudents student)
        {
            return _studentRepository.AddStudent(student);
        }
        public tblStudents GetStudentById(int studentId)
        {
            return _studentRepository.GetStudentById(studentId);
        }
        public tblStudents UpdateStudent(tblStudents student) 
        {
            return _studentRepository.UpdateStudent(student);
        }
        public tblStudents DeleteStudent(int studentId) 
        {
            return _studentRepository.DeleteStudent(studentId);
        }
    }
}
