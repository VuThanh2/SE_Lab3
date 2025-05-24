using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblDepartment
    {
        //DepartmentID INT PRIMARY KEY IDENTITY(1,1),
        //DepartmentName NVARCHAR(100) NOT NULL
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<tblCourses> tblCourses { get; set; }
    }
}
