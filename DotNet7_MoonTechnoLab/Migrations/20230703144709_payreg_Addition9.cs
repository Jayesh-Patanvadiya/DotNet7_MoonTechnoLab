using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNet7_MoonTechnoLab.Migrations
{
    /// <inheritdoc />
    public partial class payreg_Addition9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PAYROLL = table.Column<string>(type: "text", nullable: true),
                    EMPID = table.Column<string>(type: "text", nullable: false),
                    LASTNAME = table.Column<string>(type: "text", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "text", nullable: false),
                    REGDAYSWRK = table.Column<string>(type: "text", nullable: false),
                    TARDYHRS = table.Column<string>(type: "text", nullable: false),
                    UNDERTIMEHRS = table.Column<string>(type: "text", nullable: false),
                    ABSENTDAYS = table.Column<string>(type: "text", nullable: false),
                    LWOPDAYS = table.Column<string>(type: "text", nullable: false),
                    VLDAYS = table.Column<string>(type: "text", nullable: false),
                    SLDAYS = table.Column<string>(type: "text", nullable: false),
                    OTHERLVDAYS = table.Column<string>(type: "text", nullable: false),
                    NITEDIFF10 = table.Column<string>(type: "text", nullable: false),
                    REGULAROT = table.Column<string>(type: "text", nullable: false),
                    REGOTNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLOT = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLOTNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLOT8HRS = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLOT8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLRD = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLRDNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLRD8HRS = table.Column<string>(type: "text", nullable: false),
                    LEGALHOLRD8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLOT = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLOTNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLIDAYOT8 = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLOT8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    SPECIALHOLIDAYRD = table.Column<string>(type: "text", nullable: false),
                    SPECIALHOLRDNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLIDAYONRD8HRS = table.Column<string>(type: "text", nullable: false),
                    SPECLHOLRD8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    RESTDAYOT = table.Column<string>(type: "text", nullable: false),
                    RESTDAYOTNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    RESTDAYOT8HRS = table.Column<string>(type: "text", nullable: false),
                    RESTDAYOT8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLIDAYOT = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLIDAYOTNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLIDAYOT8HRS = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLIDAYOT8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLIDAYRD = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLRDNPHRS10 = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLONRD8HRS = table.Column<string>(type: "text", nullable: false),
                    DOUBLEHOLRD8NPHRS10 = table.Column<string>(type: "text", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAttendance", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeAttendance");
        }
    }
}
