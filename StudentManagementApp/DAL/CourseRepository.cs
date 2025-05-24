using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using DAL;

namespace DAL
{
    public class CourseRepository
    {
        private readonly MainDbContext _mainDbContext;
        public CourseRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<tblCourses> GetAllCourses()
        {
            return _mainDbContext.tblCourses.Include(i => i.tblDepartment).Include(i => i.tblInstructor).ToList();
        }
        public tblCourses GetCourseById(int id)
        {
            return _mainDbContext.tblCourses
                .Include(c => c.tblInstructor)
                .Include(c => c.tblDepartment)
                .FirstOrDefault(x => x.CourseID == id);
        }
        public tblCourses GetCourseByName(string courseName)
        {
            return _mainDbContext.tblCourses
                .Include(c => c.tblInstructor)
                .Include(c => c.tblDepartment)
                .FirstOrDefault(x => x.CourseName == courseName);
        }

        public tblCourses AddCourse(tblCourses course)
        {
            _mainDbContext.tblCourses.Add(course);
            _mainDbContext.SaveChanges();
            return course;
        }

        public tblCourses UpdateCourse(tblCourses course, string instructorName, string departmentName)
        {
            var existingCourse = _mainDbContext.tblCourses.FirstOrDefault(x => x.CourseID == course.CourseID);
            if (existingCourse != null)
            {
                var instructor = _mainDbContext.tblInstructors.FirstOrDefault(i => i.InstructorName == instructorName);
                var department = _mainDbContext.tblDepartments.FirstOrDefault(d => d.DepartmentName == departmentName);

                if (instructor == null)
                {
                    throw new Exception("Instructor not found");
                }

                if (department == null)
                {
                    throw new Exception("Department not found");
                }

                existingCourse.CourseName = course.CourseName;
                existingCourse.Credits = course.Credits;
                existingCourse.DepartmentID = department.DepartmentID;
                existingCourse.InstructorID = instructor.InstructorID;

                _mainDbContext.SaveChanges();
            }
            return existingCourse;
        }

        public tblCourses DeleteCourse(int id)
        {
            var course = _mainDbContext.tblCourses.FirstOrDefault(x => x.CourseID == id);
            if (course != null)
            {
                _mainDbContext.tblCourses.Remove(course);
                _mainDbContext.SaveChanges();
            }
            return course;
        }
    }
}
