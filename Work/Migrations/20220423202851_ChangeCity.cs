using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Work.Migrations
{
    public partial class ChangeCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Street_StreetId",
                table: "City");

            migrationBuilder.DropTable(
                name: "Street");

            migrationBuilder.DropIndex(
                name: "IX_City_StreetId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "StreetId",
                table: "City");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "City",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "StreetId",
                table: "City",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_StreetId",
                table: "City",
                column: "StreetId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Street_StreetId",
                table: "City",
                column: "StreetId",
                principalTable: "Street",
                principalColumn: "Id");
        }
    }
}
