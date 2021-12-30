using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.Data;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public List<User> GetAllUserByCompany(int comapanyid)
        {
            var users = _context.Users.Where(x => x.CompanyId == comapanyid).ToList();
            return users;
        }

        public async Task<List<Company>> GetAllCompanyAsync()
        {
            var countries = await _context.Companies.ToListAsync();
            return countries;
        }
    }
}
