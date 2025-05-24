using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class InstructorRepository
    {
        private readonly MainDbContext _mainDbContext;
        public InstructorRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<tblInstructor> GetAllInstructors() 
        {
            return _mainDbContext.tblInstructors.Include(i => i.tblDepartment).ToList();
        }
        public tblInstructor GetInstructorById(int id)
        {
            return _mainDbContext.tblInstructors.FirstOrDefault(x => x.InstructorID == id);
        }
        public bool AddInstructor(tblInstructor instructor)
        {
            _mainDbContext.tblInstructors.Add(instructor);
            _mainDbContext.SaveChanges();
            return true;
        }

        public void AddInstructorByName(string instructorName, string departmentName)
        {
            var department = _mainDbContext.tblDepartments
                .FirstOrDefault(d => d.DepartmentName == departmentName);

            if (department == null)
            {
                throw new Exception("Department not found");
            }

            var instructor = new tblInstructor
            {
                InstructorName = instructorName,
                DepartmentID = department.DepartmentID
            };

            _mainDbContext.tblInstructors.Add(instructor);
            _mainDbContext.SaveChanges();
        }

        public void UpdateInstructor(tblInstructor instructor)
        {
            _mainDbContext.tblInstructors.Update(instructor);
            _mainDbContext.SaveChanges();
        }

        public bool UpdateInstructorByName(int instructorId, string instructorName, string departmentName)
        {
            var instructor = _mainDbContext.tblInstructors.Find(instructorId);
            if (instructor != null)
            {
                var department = _mainDbContext.tblDepartments
                    .FirstOrDefault(d => d.DepartmentName == departmentName);

                if (department == null)
                {
                    throw new Exception("Department not found");
                }

                instructor.InstructorName = instructorName;
                instructor.DepartmentID = department.DepartmentID;

                _mainDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public tblInstructor DeleteInstructor(int instructorId)
        {
            var instructor = _mainDbContext.tblInstructors.Find(instructorId);
            if (instructor != null)
            {
                _mainDbContext.tblInstructors.Remove(instructor);
                _mainDbContext.SaveChanges();
                return instructor;
            }
            return null;
        }

        public tblInstructor DeleteInstructorByName(string instructorName, string departmentName)
        {
            var department = _mainDbContext.tblDepartments
                .FirstOrDefault(d => d.DepartmentName == departmentName);
            if (department == null)
            {
                throw new Exception("Department not found");
            }

            var instructor = _mainDbContext.tblInstructors
                .FirstOrDefault(i => i.InstructorName == instructorName 
                                && i.DepartmentID == department.DepartmentID);
            if (instructor != null)
            {
                _mainDbContext.tblInstructors.Remove(instructor);
                _mainDbContext.SaveChanges();
                return instructor;
            }
            return null;
        }
    }
}
