using BMIApplication.Data;
using BMIApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace BMIApplication.Controllers
{
    public class ReportController : Controller
    {
        private readonly ReportService _reportService;

        public ReportController(ApplicationDbContext context)
        {
            _reportService = new ReportService(context);
        }

        public IActionResult Index()
        {
            var categories = _reportService.GetReport();
            return View(categories);
        }
    }
}
