using BMIApplication.Data;
using BMIApplication.Data.Models;
using BMIApplication.Models;

namespace BMIApplication.Services
{
    public class LoginService
    {
        private readonly ApplicationDbContext _context;

        public LoginService(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserViewModel GetUserData(string userName)
        {
            var userData = _context.GetUser(userName);
            return GenerateUserData(userData);
        }

        private UserViewModel GenerateUserData(UserData userData)
        {
            return new UserViewModel()
            {
                Name = userData.User.UserName,
                Email = userData.User.UserName,
                DateOfBirth = userData.DateOfBirth,
                Height = userData.Height,
                Weight = userData.Weight
            };
        }
    }
}
