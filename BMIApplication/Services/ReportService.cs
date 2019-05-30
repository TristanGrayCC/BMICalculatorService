using BMIApplication.Data;
using BMIApplication.Data.Models;
using BMIApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace BMIApplication.Services
{
    public class ReportService
    {
        private readonly ApplicationDbContext _context;

        public ReportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BMIReportViewModel> GetReport()
        {
            var dataList = _context.GetUserData;
            return GenerateReport(dataList);
        }

        public static IEnumerable<BMIReportViewModel> GenerateReport(IEnumerable<UserData> dataList)
        {
            var categoryList = new List<BMIReportViewModel>()
            {
                new BMIReportViewModel{ BMICategory = BMIGeneratorService.UnderWight, PatientCount = 0 },
                new BMIReportViewModel{ BMICategory = BMIGeneratorService.NormalWeight, PatientCount = 0 },
                new BMIReportViewModel{ BMICategory = BMIGeneratorService.PreObesity, PatientCount = 0 },
                new BMIReportViewModel{ BMICategory = BMIGeneratorService.ObesityClass1, PatientCount = 0 },
                new BMIReportViewModel{ BMICategory = BMIGeneratorService.ObesityClass2, PatientCount = 0 }
            };

            foreach(var data in dataList)
            {
                var bmi = BMIGeneratorService.CalculateBMI(data.Height, data.Weight);
                var category = BMIGeneratorService.CalculateCategory(bmi);
                categoryList.Single(x => x.BMICategory == category).PatientCount++;
            }

            return categoryList;
        }
    }
}
