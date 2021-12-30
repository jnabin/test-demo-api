using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.Data;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _context;
        public CountryRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public List<Company> GetAllCompanyByCountry(int countryId)
        {
            var companies = _context.Companies.Where(x => x.CountryId == countryId).ToList();
            return companies;
        }

        public async Task<List<Country>> GetAllCountryAsync()
        {
            var countries = await _context.Countries.Include(x => x.Company).ThenInclude(x => x.Users).AsNoTracking().ToListAsync();
            return countries;
        }
    }
}
