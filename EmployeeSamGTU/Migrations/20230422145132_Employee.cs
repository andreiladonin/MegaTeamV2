using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EmployeeSamGTU.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<double>(type: "double precision", nullable: false),
                    Experience = table.Column<int>(type: "integer", nullable: false),
                    BasicCsharp = table.Column<int>(type: "integer", nullable: false),
                    AspNet = table.Column<int>(type: "integer", nullable: false),
                    Entity = table.Column<int>(type: "integer", nullable: false),
                    BasicJava = table.Column<int>(type: "integer", nullable: false),
                    SpringJava = table.Column<int>(type: "integer", nullable: false),
                    GuiJava = table.Column<int>(type: "integer", nullable: false),
                    BasicJS = table.Column<int>(type: "integer", nullable: false),
                    ReactJS = table.Column<int>(type: "integer", nullable: false),
                    Angular = table.Column<int>(type: "integer", nullable: false),
                    HtmlAndCss = table.Column<int>(type: "integer", nullable: false),
                    Bootstrap = table.Column<int>(type: "integer", nullable: false),
                    Sass = table.Column<int>(type: "integer", nullable: false),
                    BasicPython = table.Column<int>(type: "integer", nullable: false),
                    Django = table.Column<int>(type: "integer", nullable: false),
                    Flask = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
