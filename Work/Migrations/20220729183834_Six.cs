using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work.Migrations
{
    public partial class Six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryVacancies_Employers_EmployerId",
                table: "HistoryVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Categories_CategoryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_TypeOfEmployments_TypeOfEmploymentsId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes");

            migrationBuilder.AlterColumn<int>(
                name: "VacancySuitableId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfEmploymentsId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SalaryId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ExperienceId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "EducationId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerId",
                table: "HistoryVacancies",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryVacancies_Employers_EmployerId",
                table: "HistoryVacancies",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Categories_CategoryId",
                table: "Resumes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_TypeOfEmployments_TypeOfEmploymentsId",
                table: "Resumes",
                column: "TypeOfEmploymentsId",
                principalTable: "TypeOfEmployments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes",
                column: "VacancySuitableId",
                principalTable: "VacancySuitables",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryVacancies_Employers_EmployerId",
                table: "HistoryVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Categories_CategoryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_TypeOfEmployments_TypeOfEmploymentsId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes");

            migrationBuilder.AlterColumn<int>(
                name: "VacancySuitableId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfEmploymentsId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SalaryId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExperienceId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EducationId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployerId",
                table: "HistoryVacancies",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryVacancies_Employers_EmployerId",
                table: "HistoryVacancies",
                column: "EmployerId",
                principalTable: "Employers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Categories_CategoryId",
                table: "Resumes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Salary_SalaryId",
                table: "Resumes",
                column: "SalaryId",
                principalTable: "Salary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_TypeOfEmployments_TypeOfEmploymentsId",
                table: "Resumes",
                column: "TypeOfEmploymentsId",
                principalTable: "TypeOfEmployments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes",
                column: "VacancySuitableId",
                principalTable: "VacancySuitables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
