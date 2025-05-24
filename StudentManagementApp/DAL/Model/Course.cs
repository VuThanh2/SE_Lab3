using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblCourses
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public int InstructorID { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual tblInstructor tblInstructor { get; set; }
        public virtual ICollection<tblStudentCourse> tblStudentCourse { get; set; }
    }
}
