using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Xml.Linq;

namespace EmployeeSamGTU.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double Salary { get; set; }
        // опыт
        [Required]
        [Display(Name = "Experience")]
        public int Experience { get; set; }

        //С#
        [Display(Name = "Base C#")]
        public ProficiencyLevel BasicCsharp { get; set; }

        public ProficiencyLevel AspNet { get; set; }

        public ProficiencyLevel Entity { get; set; }

        // Java
        [Display(Name = "Base Java")]
        public ProficiencyLevel BasicJava { get; set; }

        public ProficiencyLevel SpringJava { get; set; }

        public ProficiencyLevel GuiJava { get; set; }

        // JS
        [Display(Name = "Base JavaScript")]
        public ProficiencyLevel BasicJS { get; set; }

        public ProficiencyLevel ReactJS { get; set; }

        public ProficiencyLevel Angular { get; set; }

        // Frontend
        [Display(Name = "HTML&CSS")]
        public ProficiencyLevel HtmlAndCss { get; set; }

        public ProficiencyLevel Bootstrap { get; set; }

        public ProficiencyLevel Sass { get; set; }

        // python
        [Display(Name = "Base Python")]
        public ProficiencyLevel BasicPython { get; set; }

        public ProficiencyLevel Django { get; set; }

        public ProficiencyLevel Flask { get; set; }
    }
}
