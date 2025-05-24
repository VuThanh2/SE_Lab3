using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStudentCourse
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public virtual tblStudents tblStudents { get; set; }
        public virtual tblCourses tblCourses { get; set; }
        //public virtual tblDepartment tblDepartment { get; set; }
        //public virtual tblInstructor tblInstructor { get; set; }
    }
}
