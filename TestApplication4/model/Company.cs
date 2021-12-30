using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApplication4.model
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }
        public List<User> Users { get; set; }
    }
}
