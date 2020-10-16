using JwtTest.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore;

namespace JwtTest.Domain.Context
{
    public class DataContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory;
        public DataContext() : base()
        {

        }

        public DataContext(ILoggerFactory loggerFactory) : base()
        {
            _loggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseMySQL("server=localhost;password=jwttestuser;user id=jwttestuser;database=jwttest");
            builder.UseLoggerFactory(_loggerFactory);
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}