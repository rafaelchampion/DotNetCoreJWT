using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JwtTest.Domain.Models
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}