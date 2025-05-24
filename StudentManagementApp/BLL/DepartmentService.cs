using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _departmentRepository;
        public DepartmentService()
        {
            _departmentRepository = new DepartmentRepository();
        }
        public List<tblDepartment> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }
        public tblDepartment GetDepartmentById(int id)
        {
            return _departmentRepository.GetDepartmentById(id);
        }
        public tblDepartment AddDepartment(tblDepartment department)
        {
            return _departmentRepository.AddDepartment(department);
        }
        public tblDepartment UpdateDepartment(tblDepartment department)
        {
            return _departmentRepository.UpdateDepartment(department);
        }
        public tblDepartment DeleteDepartmentById(int id)
        {
            return _departmentRepository.DeleteDepartmentById(id);
        }
    }
}
