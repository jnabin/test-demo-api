using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.Data;
using TestApplication4.Repository;

namespace TestApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCountryAsync()
        {
            var countries = await _countryRepository.GetAllCountryAsync();

            return Ok(countries);
        }

        [HttpGet("GetCompanyByCountryId/{id}")]
        public IActionResult GetCompanyByCountryId([FromRoute] int id)
        {
            var comapanies = _countryRepository.GetAllCompanyByCountry(id);
           
            return Ok(comapanies);
        }
    }
}
