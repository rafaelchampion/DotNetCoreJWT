using System;
using System.ComponentModel.DataAnnotations;

namespace JwtTest.Domain.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}