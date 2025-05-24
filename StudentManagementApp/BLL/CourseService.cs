using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;
        private readonly DepartmentRepository _departmentRepository;
        private readonly InstructorRepository _instructorRepository;
        public CourseService()
        {
            _courseRepository = new CourseRepository();
            _departmentRepository = new DepartmentRepository();
            _instructorRepository = new InstructorRepository();
        }
        public List<tblCourses> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }
        public tblCourses AddCourse(tblCourses course)
        {
            return _courseRepository.AddCourse(course);
        }
        public tblCourses GetCourseById(int courseId)
        {
            return _courseRepository.GetCourseById(courseId);
        }
        public tblCourses GetCourseByName(string courseName)
        {
            return _courseRepository.GetCourseByName(courseName);
        }
        public tblCourses UpdateCourse(tblCourses course, string instructorName, string departmentName)
        {
            return _courseRepository.UpdateCourse(course, instructorName, departmentName);
        }
        public tblCourses DeleteCourse(int courseId)
        {
            return _courseRepository.DeleteCourse(courseId);
        }
        public List<tblDepartment> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }
        public List<tblInstructor> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }
    }
}
