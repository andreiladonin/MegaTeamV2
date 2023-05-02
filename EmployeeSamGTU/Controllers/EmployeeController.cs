using EmployeeSamGTU.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSamGTU.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _db;

        public EmployeeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        { 
            return View(_db.Employees.ToList());
        }

        // страница создания сотрудников
        public IActionResult Create()
        {
            return View();
        }

        // POST - запрос
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // добавление
                _db.Employees.Add(employee);
                _db.SaveChanges();
                //перенаправление в другой action - methods
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Profile(int id)
        {
            var employee = _db.Employees.SingleOrDefault(x => x.Id == id);

            if (employee == null)
            {
                NotFound();
            }

            return View(employee);
        }
    }
}
