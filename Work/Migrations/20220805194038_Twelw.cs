using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work.Migrations
{
    public partial class Twelw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Salary_SalaryId",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salary",
                table: "Salary");

            migrationBuilder.RenameTable(
                name: "Salary",
                newName: "Salaries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Salaries_SalaryId",
                table: "Resumes",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Salaries_SalaryId",
                table: "Vacancies",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Salaries_SalaryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Salaries_SalaryId",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salary");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salary",
                table: "Salary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Salary_SalaryId",
                table: "Vacancies",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");
        }
    }
}
