using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblInstructor
    {
        //InstructorID INT PRIMARY KEY IDENTITY(1,1),
        //InstructorName NVARCHAR(100) NOT NULL,
        //DepartmentID INT NOT NULL
        public int InstructorID {  get; set; }
        public string InstructorName { get; set; }
        public int DepartmentID { get; set; }
        public virtual tblDepartment tblDepartment { get; set; }
        public virtual ICollection<tblCourses> tblCourses { get; set; }
    }
}
