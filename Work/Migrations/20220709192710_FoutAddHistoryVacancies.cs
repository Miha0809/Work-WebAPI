using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Work.Migrations
{
    public partial class FoutAddHistoryVacancies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_VacancyIsSuitables_VacancyIsSuitableId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoriesId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Experiences_ExperiencesId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_VacancyIsSuitables_VacancyIsSuitableId",
                table: "Vacancies");

            migrationBuilder.DropTable(
                name: "VacancyIsSuitables");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Vacancies");

            migrationBuilder.RenameColumn(
                name: "VacancyIsSuitableId",
                table: "Vacancies",
                newName: "VacancySuitableId");

            migrationBuilder.RenameColumn(
                name: "ExperiencesId",
                table: "Vacancies",
                newName: "HistoryVacancyId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Vacancies",
                newName: "ExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_VacancyIsSuitableId",
                table: "Vacancies",
                newName: "IX_Vacancies_VacancySuitableId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_ExperiencesId",
                table: "Vacancies",
                newName: "IX_Vacancies_HistoryVacancyId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_CategoriesId",
                table: "Vacancies",
                newName: "IX_Vacancies_ExperienceId");

            migrationBuilder.RenameColumn(
                name: "VacancyIsSuitableId",
                table: "Resumes",
                newName: "VacancySuitableId");

            migrationBuilder.RenameIndex(
                name: "IX_Resumes_VacancyIsSuitableId",
                table: "Resumes",
                newName: "IX_Resumes_VacancySuitableId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vacancies",
                type: "character varying(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Vacancies",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Vacancies",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfEmployments",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Street",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Salary",
                type: "character varying(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Experiences",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Educations",
                type: "character varying(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "character varying(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "HistoryVacancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryVacancies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacancySuitables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancySuitables", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CategoryId",
                table: "Vacancies",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes",
                column: "VacancySuitableId",
                principalTable: "VacancySuitables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Experiences_ExperienceId",
                table: "Vacancies",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_HistoryVacancies_HistoryVacancyId",
                table: "Vacancies",
                column: "HistoryVacancyId",
                principalTable: "HistoryVacancies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_VacancySuitables_VacancySuitableId",
                table: "Vacancies",
                column: "VacancySuitableId",
                principalTable: "VacancySuitables",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_VacancySuitables_VacancySuitableId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Categories_CategoryId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Experiences_ExperienceId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_HistoryVacancies_HistoryVacancyId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_VacancySuitables_VacancySuitableId",
                table: "Vacancies");

            migrationBuilder.DropTable(
                name: "HistoryVacancies");

            migrationBuilder.DropTable(
                name: "VacancySuitables");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_CategoryId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Vacancies");

            migrationBuilder.RenameColumn(
                name: "VacancySuitableId",
                table: "Vacancies",
                newName: "VacancyIsSuitableId");

            migrationBuilder.RenameColumn(
                name: "HistoryVacancyId",
                table: "Vacancies",
                newName: "ExperiencesId");

            migrationBuilder.RenameColumn(
                name: "ExperienceId",
                table: "Vacancies",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_VacancySuitableId",
                table: "Vacancies",
                newName: "IX_Vacancies_VacancyIsSuitableId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_HistoryVacancyId",
                table: "Vacancies",
                newName: "IX_Vacancies_ExperiencesId");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_ExperienceId",
                table: "Vacancies",
                newName: "IX_Vacancies_CategoriesId");

            migrationBuilder.RenameColumn(
                name: "VacancySuitableId",
                table: "Resumes",
                newName: "VacancyIsSuitableId");

            migrationBuilder.RenameIndex(
                name: "IX_Resumes_VacancySuitableId",
                table: "Resumes",
                newName: "IX_Resumes_VacancyIsSuitableId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vacancies",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(512)",
                oldMaxLength: 512);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Vacancies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TypeOfEmployments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Street",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Salary",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Experiences",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Educations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(32)",
                oldMaxLength: 32);

            migrationBuilder.CreateTable(
                name: "VacancyIsSuitables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyIsSuitables", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_VacancyIsSuitables_VacancyIsSuitableId",
                table: "Resumes",
                column: "VacancyIsSuitableId",
                principalTable: "VacancyIsSuitables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Categories_CategoriesId",
                table: "Vacancies",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Experiences_ExperiencesId",
                table: "Vacancies",
                column: "ExperiencesId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_VacancyIsSuitables_VacancyIsSuitableId",
                table: "Vacancies",
                column: "VacancyIsSuitableId",
                principalTable: "VacancyIsSuitables",
                principalColumn: "Id");
        }
    }
}
