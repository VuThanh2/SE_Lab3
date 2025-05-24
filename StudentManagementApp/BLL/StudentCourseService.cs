using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentCourseService
    {
        private readonly StudentCourseRepository _studentCourseRepository;
        private readonly CourseRepository _courseRepository;
        public StudentCourseService() 
        {
            _studentCourseRepository = new StudentCourseRepository();
            _courseRepository = new CourseRepository();
        }
        public List<tblStudentCourse> GetAllStudentCourses()
        {
            return _studentCourseRepository.GetAllStudentCourses();
        }
        public List<tblCourses> GetAllMajors()
        {
            return _courseRepository.GetAllCourses();
        }
        public List<tblStudentCourse> GetAllStudentCoursesByMajor(int majorName)
        {
            return _studentCourseRepository.GetAllStudentCoursesByMajor(majorName);
        }
    }
}
