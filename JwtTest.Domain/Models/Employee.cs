using System.ComponentModel.DataAnnotations.Schema;

namespace JwtTest.Domain.Models
{
    public class Employee : Base
    {
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}