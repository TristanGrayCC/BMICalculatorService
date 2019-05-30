using BMIApplication.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BMIApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<UserData> UserDatas { get; set; }

        public IQueryable<UserData> GetUserData => UserDatas;
        public UserData GetUser(string userName)
        {
            return UserDatas.Include(x => x.User).SingleOrDefault(x => x.User.UserName == userName);
        }
    }
}
