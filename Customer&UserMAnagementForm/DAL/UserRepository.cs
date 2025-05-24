using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using DAL.Model;

namespace DAL
{
    public class UserRepository
    {
        private readonly MainDbContext _mainDbContext;
        public UserRepository()
        {
            _mainDbContext = new MainDbContext();
        }
        public List<User> GetAllUsers()
        {
            return _mainDbContext.Users.ToList();
        }
    }
}
