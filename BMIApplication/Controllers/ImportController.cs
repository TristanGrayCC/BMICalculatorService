using BMIApplication.Data;
using BMIApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;

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
        public void Import(IFormFile file)
        {
            var fileContent = ReadAsList(file);
            _importService.Import(fileContent);
        }

        private IEnumerable<string> ReadAsList(IFormFile file)
        {
            var result = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.Add(reader.ReadLine());
            }

            return result;
        }
    }
}
