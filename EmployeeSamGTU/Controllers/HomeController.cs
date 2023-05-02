using EmployeeSamGTU.Models;
using EmployeeSamGTU.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeSamGTU.Controllers
{
    public class HomeController : Controller
    {
        private readonly SelectionService selectionService;

        public HomeController(SelectionService selectionService)
        {
            this.selectionService = selectionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(Project project)
        {
            project.Employees = selectionService.Selection(project);


            return View(project);
        }
    }
}