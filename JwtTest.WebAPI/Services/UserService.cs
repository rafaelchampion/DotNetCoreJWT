using JwtTest.Domain.Context;
using JwtTest.Domain.Models;
using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace JwtTest.WebAPI.Services
{
    public static class UserService
    {
        public static User GetUser(string username, string passsword)
        {
            // var loggerFactory = LoggerFactory.Create(builder =>
            // {
            //     builder
            //     .AddConsole((options) => { })
            //     .AddFilter((category, level) =>
            //         category == DbLoggerCategory.Database.Command.Name
            //         && level == LogLevel.Information);
            // });
            using (var db = new DataContext())
            {
                var user = db.Users.Include(x => x.Employee).ThenInclude(x => x.Role).Include(x => x.Employee.Person).Where(x => x.Username == username && x.Password == passsword).FirstOrDefault();
                return user;
            }
        }
    }
}
