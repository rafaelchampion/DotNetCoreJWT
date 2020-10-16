using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtTest.Domain.Models
{
    public class Person : Base
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}