using BMIApplication.Data;
using BMIApplication.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BMIApplication.Services
{
    public class ImportService
    {
        private readonly ApplicationDbContext _context;

        public ImportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Import(IEnumerable<string> fileData)
        {
            var readData = fileData.Select(BuildUserData);

            SaveImport(readData);
        }

        private void SaveImport(IEnumerable<UserData> userData)
        {
            foreach (var data in userData)
            {
                _context.UserDatas.Add(data);
            }

            _context.SaveChanges();
        }

        private UserData BuildUserData(string line)
        {
            var lineFields = line.Split(",");
            var name = lineFields[0];
            var height = decimal.Parse(lineFields[1]);
            var weight = decimal.Parse(lineFields[2]);

            return new UserData()
            {
                Height = height,
                Weight = weight,
                User = new IdentityUser()
                {
                    UserName = name
                }
            };
        }
    }
}
