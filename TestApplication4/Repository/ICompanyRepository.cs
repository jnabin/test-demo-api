using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllCompanyAsync();
        List<User> GetAllUserByCompany(int comapanyid);
    }
}
