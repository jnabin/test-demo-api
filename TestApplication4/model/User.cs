using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestApplication4.model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        [JsonIgnore]
        public Company Company { get; set; }
    }
}
