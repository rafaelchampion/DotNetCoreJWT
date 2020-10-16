using System.Collections.Generic;

namespace JwtTest.Domain.Models
{
    public class Role : Base
    {
        public string Nome { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}