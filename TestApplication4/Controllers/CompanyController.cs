using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestApplication4.Repository;

namespace TestApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCompanyAsync()
        {
            var companies = await _companyRepository.GetAllCompanyAsync();
            return Ok(companies);
        }

        [HttpGet("/GetUser-By-CompanyId/{id}")]
        public IActionResult GetAllCompanyAsync([FromRoute] int id)
        {
            var users = _companyRepository.GetAllUserByCompany(id);
            return Ok(users);
        }

    }
}
