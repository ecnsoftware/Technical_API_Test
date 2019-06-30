using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        [JsonProperty(PropertyName = "name")]
        public string FullName { get; set; }
        [JsonProperty(PropertyName = "salary")]
        public string Salary { get; set; }
        [JsonProperty(PropertyName = "age")]
        public string Age { get; set; }
       // [JsonIgnore]
        public string Id { get; set; }

    }
}
