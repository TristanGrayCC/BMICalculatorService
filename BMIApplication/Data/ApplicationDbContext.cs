using BMIApplication.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var goodUser = new IdentityUser
            {
                Id = "goodUserId",
                UserName = "gooduser",
                PasswordHash = GetHashedPassword()
            };
            modelBuilder.Entity<IdentityUser>().HasData(
            goodUser,
            new IdentityUser
            {
                UserName = "baduser",
                PasswordHash = GetHashedPassword(),
                LockoutEnd = new DateTimeOffset(new DateTime(2099, 01, 01))
            });

            modelBuilder.Entity<UserData>().HasData(
            new UserData
            {
                Height = 1.85m,
                Weight = 83.5m,
                UserId = goodUser.Id
            });

            base.OnModelCreating(modelBuilder);
        }

        private static string GetHashedPassword()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes("Testing123", salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            var hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
