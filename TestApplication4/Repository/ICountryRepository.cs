using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAllCountryAsync();
        List<Company> GetAllCompanyByCountry(int countryId);
    }
}
