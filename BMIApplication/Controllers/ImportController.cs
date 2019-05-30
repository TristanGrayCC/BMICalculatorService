using BMIApplication.Data;
using BMIApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace BMIApplication.Controllers
{
    public class ImportController : Controller
    {
        private readonly ImportService _importService;

        public ImportController(ApplicationDbContext context)
        {
            _importService = new ImportService(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Import([FromBody] string fileAddress)
        {
            _importService.Import(fileAddress);
        }
    }
}
