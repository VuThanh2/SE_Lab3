using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class StudentCourseRepository
    {
        private readonly MainDbContext _mainDbContext;
        public StudentCourseRepository() 
        {
            _mainDbContext = new MainDbContext();
        }
        public List<tblStudentCourse> GetAllStudentCourses()
        {
            return _mainDbContext.tblStudentCourses
                .Include(i => i.tblStudents)
                .Include(i => i.tblCourses)
                .Include(i => i.tblCourses.tblDepartment)
                .Include(i => i.tblCourses.tblInstructor)
                .ToList();
        }
        public List<tblCourses> GetAllMajors()
        {
            return _mainDbContext.tblCourses.ToList();
        }
        public List<tblStudentCourse> GetAllStudentCoursesByMajor(int majorName)
        {
            return _mainDbContext.tblStudentCourses
                .Include(i => i.tblStudents)
                .Include(i => i.tblCourses)
                .Include(i => i.tblCourses.tblDepartment)
                .Include(i => i.tblCourses.tblInstructor)
                .Where(x => x.tblCourses.DepartmentID == majorName)
                .ToList();
        }
    }
}
