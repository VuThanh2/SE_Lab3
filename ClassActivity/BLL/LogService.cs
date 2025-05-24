using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class LogService
    {
        private readonly LogRepository _logRepository;
        public LogService()
        {
            _logRepository = new LogRepository();
        }
        public List<Users> GetAllUsers()
        {
            return _logRepository.GetAllUsers();
        }
    }
}
