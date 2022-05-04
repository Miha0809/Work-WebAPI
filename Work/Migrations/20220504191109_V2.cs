using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Vacancy_VacancyId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_City_CityId",
                table: "Vacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Employer_EmployerId",
                table: "Vacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Salary_SalaryId",
                table: "Vacancy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacancy",
                table: "Vacancy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employer",
                table: "Employer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Vacancy",
                newName: "Vacancies");

            migrationBuilder.RenameTable(
                name: "Employer",
                newName: "Employers");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancy_SalaryId",
                table: "Vacancies",
                newName: "IX_Vacancies_SalaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancy_EmployerId",
                table: "Vacancies",
                newName: "IX_Vacancies_EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancy_CityId",
                table: "Vacancies",
                newName: "IX_Vacancies_CityId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employers",
                newName: "Password");

            migrationBuilder.RenameIndex(
                name: "IX_Category_VacancyId",
                table: "Categories",
                newName: "IX_Categories_VacancyId");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameCompany",
                table: "Employers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Cities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacancies",
                table: "Vacancies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employers",
                table: "Employers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Vacancies_VacancyId",
                table: "Categories",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Cities_CityId",
                table: "Vacancies",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Employers_EmployerId",
                table: "Vacancies",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Salary_SalaryId",
                table: "Vacancies",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Vacancies_VacancyId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Cities_CityId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Employers_EmployerId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Salary_SalaryId",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacancies",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employers",
                table: "Employers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employers");

            migrationBuilder.DropColumn(
                name: "NameCompany",
                table: "Employers");

            migrationBuilder.RenameTable(
                name: "Vacancies",
                newName: "Vacancy");

            migrationBuilder.RenameTable(
                name: "Employers",
                newName: "Employer");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_SalaryId",
                table: "Vacancy",
                newName: "IX_Vacancy_SalaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancy",
                newName: "IX_Vacancy_EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_CityId",
                table: "Vacancy",
                newName: "IX_Vacancy_CityId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Employer",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_VacancyId",
                table: "Category",
                newName: "IX_Category_VacancyId");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "City",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacancy",
                table: "Vacancy",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employer",
                table: "Employer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Vacancy_VacancyId",
                table: "Category",
                column: "VacancyId",
                principalTable: "Vacancy",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_City_CityId",
                table: "Vacancy",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Employer_EmployerId",
                table: "Vacancy",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Salary_SalaryId",
                table: "Vacancy",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");
        }
    }
}
