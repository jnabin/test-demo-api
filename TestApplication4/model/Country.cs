using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApplication4.model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Company> Company { get; set; }
    }
}
