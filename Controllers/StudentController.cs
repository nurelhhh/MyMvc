using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Mvc;
using MyMvc.Data;
using MyMvc.Models;
using System.Diagnostics;

namespace MyMvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string id)
        {
            var student = StudentData.GetAllData()
                .Where(Q => Q.StudentId == id)
                .FirstOrDefault();

            if (student == null)
            {
                return Redirect("/Student");
            }

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
