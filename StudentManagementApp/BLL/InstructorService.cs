using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepository;
        public InstructorService()
        {
            _instructorRepository = new InstructorRepository();
        }
        public List<tblInstructor> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }
        public bool AddInstructor(tblInstructor instructor)
        {
            return _instructorRepository.AddInstructor(instructor);
        }
        public tblInstructor GetInstructorById(int instructorId)
        {
            return _instructorRepository.GetInstructorById(instructorId);
        }
        public bool UpdateInstructor(int instructorId, string instructorName, string departmentName)
        {
            return _instructorRepository.UpdateInstructorByName(instructorId, instructorName, departmentName);
        }
        public tblInstructor DeleteInstructor(int instructorId)
        {
            return _instructorRepository.DeleteInstructor(instructorId);
        }
    }
}
