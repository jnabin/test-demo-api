using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication4.Data;

namespace TestApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserValuesController : ControllerBase
    {
        private static readonly List<SampleUserData> userData = new List<SampleUserData>
        {
            {new SampleUserData{ CountryName = "India", Companyname="XYZ", UserName="Nabin", Address="sdhh-e7"} },
            {new SampleUserData{ CountryName = "Uk", Companyname="ABC", UserName="Nabin", Address="hegy-37"} },
            {new SampleUserData{ CountryName = "Germany", Companyname="DHJF", UserName="Nabin", Address="sjjwhd-3878"} },
            {new SampleUserData{ CountryName = "USA", Companyname="CHD", UserName="Nabin", Address="knde-38"} },
            {new SampleUserData{ CountryName = "Nepal", Companyname="DJMM", UserName="Nabin", Address="sj-388"} },
            {new SampleUserData{ CountryName = "Pakistan", Companyname="DHBJ", UserName="Nabin", Address="wejduw-387"} },
            {new SampleUserData{ CountryName = "Bhutan", Companyname="XYZ", UserName="Nabin", Address="ej-384"} },
            {new SampleUserData{ CountryName = "Afganisthan", Companyname="XYZ", UserName="Nabin", Address="kef-384"} },
            {new SampleUserData{ CountryName = "Nepal", Companyname="DJMM", UserName="Nabin", Address="sj-388"} },
            {new SampleUserData{ CountryName = "Pakistan", Companyname="DHBJ", UserName="Nabin", Address="wejduw-387"} },
        };

        private readonly ILogger<UserValuesController> _logger;

        public UserValuesController(ILogger<UserValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<SampleUserData> Get()
        {
            return userData;
        }
    }
}
