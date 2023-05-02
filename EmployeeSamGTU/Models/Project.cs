using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeSamGTU.Models
{
    public class Project
    {
        public string Name {get; set;}

        public double Budget { get; set; }
        // опыт
        [Required]
        [Display(Name = "Опыт")]
        public int Experience { get; set; }

        //С#
        [Display(Name = "Основы C#")]
        public ProficiencyLevel BasicCsharp { get; set; }

        public ProficiencyLevel AspNet { get; set; }

        public ProficiencyLevel Entity { get; set; }

        // Java
        [Display(Name = "Основы Java")]
        public ProficiencyLevel BasicJava { get; set; }

        public ProficiencyLevel SpringJava { get; set; }

        public ProficiencyLevel GuiJava { get; set; }

        // JS
        [Display(Name = "Основы JavaScript")]
        public ProficiencyLevel BasicJS { get; set; }

        public ProficiencyLevel ReactJS { get; set; }

        public ProficiencyLevel Angular { get; set; }

        // Frontend
        [Display(Name = "HTML&CSS")]
        public ProficiencyLevel HtmlAndCss { get; set; }

        public ProficiencyLevel Bootstrap { get; set; }

        public ProficiencyLevel Sass { get; set; }

        // python
        [Display(Name = "Основы Python")]
        public ProficiencyLevel BasicPython { get; set; }

        public ProficiencyLevel Django { get; set; }

        public ProficiencyLevel Flask { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
