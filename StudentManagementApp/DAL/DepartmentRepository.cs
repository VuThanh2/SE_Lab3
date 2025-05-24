using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepository
    {
        private readonly MainDbContext _mainDbContext;
        public DepartmentRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<tblDepartment> GetAllDepartments()
        {
            return _mainDbContext.tblDepartments.ToList();
        }
        public tblDepartment GetDepartmentById(int id)
        {
            return _mainDbContext.tblDepartments.FirstOrDefault(x => x.DepartmentID == id);
        }

        public tblDepartment AddDepartment(tblDepartment department)
        {
            _mainDbContext.tblDepartments.Add(department);
            _mainDbContext.SaveChanges();
            return department;
        }

        public tblDepartment UpdateDepartment(tblDepartment department)
        {
            var existingDepartment = _mainDbContext.tblDepartments.FirstOrDefault(x => x.DepartmentID == department.DepartmentID);
            if (existingDepartment != null)
            {
                existingDepartment.DepartmentName = department.DepartmentName;
                _mainDbContext.SaveChanges();
            }
            return existingDepartment;
        }

        public tblDepartment DeleteDepartmentById(int id)
        {
            var department = _mainDbContext.tblDepartments.FirstOrDefault(x => x.DepartmentID == id);
            if (department != null)
            {
                _mainDbContext.tblDepartments.Remove(department);
                _mainDbContext.SaveChanges();
            }
            return department;
        }
    }
}
