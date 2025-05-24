using Microsoft.EntityFrameworkCore;
using DAL;

namespace DAL
{
    public class LogRepository
    {
        private readonly MainDbContext _mainDbContext;
        public LogRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<Users> GetAllUsers()
        {
            return _mainDbContext.Users.ToList();
        }
    }
}
