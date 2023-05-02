using EmployeeSamGTU.Migrations;
using EmployeeSamGTU.Models;
using Employee = EmployeeSamGTU.Models.Employee;

namespace EmployeeSamGTU.Services
{
    public class SelectionService
    {
        private readonly AppDbContext _db;
        public SelectionService(AppDbContext db)
        {
            _db = db;
        }
        // логика
        public List<Employee> Selection(Project project)
        {
            var employees = _db.Employees.ToList();

            var selection = new List<Employee>();

            
            foreach (var emp in employees)
            {
                if ((int)project.BasicCsharp > (int)emp.BasicCsharp)
                {
                    continue;
                }
                if ((int)project.AspNet > (int)emp.AspNet)
                {
                    continue;
                }
                if ((int)project.Entity > (int)emp.Entity)
                {
                    continue;
                }
                if ((int)project.BasicJava > (int)emp.BasicJava)
                {
                    continue;
                }
                if ((int)project.SpringJava > (int)emp.SpringJava)
                {
                    continue;
                }
                if ((int)project.GuiJava > (int)emp.GuiJava)
                {
                    continue;
                }
                if ((int)project.BasicJS > (int)emp.BasicJS)
                {
                    continue;
                }
                if ((int)project.Angular > (int)emp.Angular)
                {
                    continue;
                }
                if ((int)project.ReactJS > (int)emp.ReactJS)
                {
                    continue;
                }
                if ((int)project.HtmlAndCss > (int)emp.HtmlAndCss)
                {
                    continue;
                }
                if ((int)project.Bootstrap > (int)emp.Bootstrap)
                {
                    continue;
                }
                if ((int)project.Sass > (int)emp.Sass)
                {
                    continue;
                }
                if ((int)project.BasicPython > (int)emp.BasicPython)
                {
                    continue;
                }
                if ((int)project.Django > (int)emp.Django)
                {
                    continue;
                }
                if ((int)project.Flask > (int)emp.Flask)
                {
                    continue;
                }

                selection.Add(emp);
            }

            return selection;
        }
    }

}
