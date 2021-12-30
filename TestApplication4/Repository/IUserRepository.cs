using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.model;

namespace TestApplication4.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync();
    }
}
