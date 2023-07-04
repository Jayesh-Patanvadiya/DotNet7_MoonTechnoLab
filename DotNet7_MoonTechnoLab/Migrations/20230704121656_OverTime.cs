using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNet7_MoonTechnoLab.Migrations
{
    /// <inheritdoc />
    public partial class OverTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OverTimeCal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OVERTIME = table.Column<string>(type: "text", nullable: true),
                    EMPLOYEEID = table.Column<string>(type: "text", nullable: true),
                    LASTNAME = table.Column<string>(type: "text", nullable: true),
                    FIRSTNAME = table.Column<string>(type: "text", nullable: true),
                    ATTDEDUCTION = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimeCal", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OverTimeCal");
        }
    }
}
