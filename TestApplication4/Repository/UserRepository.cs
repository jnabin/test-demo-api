using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication4.Data;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
