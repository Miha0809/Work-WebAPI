using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Work.Migrations
{
    public partial class Five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Resumes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Resumes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "HistoryVacancies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HistoryVacancies_EmployerId",
                table: "HistoryVacancies",
                column: "EmployerId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoryVacancies_Employers_EmployerId",
                table: "HistoryVacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_HistoryVacancies_EmployerId",
                table: "HistoryVacancies");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "HistoryVacancies");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Resumes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Applicants_ApplicantId",
                table: "Resumes",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "Id");
        }
    }
}
