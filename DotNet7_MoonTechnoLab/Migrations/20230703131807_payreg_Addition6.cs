using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNet7_MoonTechnoLab.Migrations
{
    /// <inheritdoc />
    public partial class payreg_Addition6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OTReg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PAYROLL = table.Column<string>(type: "text", nullable: false),
                    PAYDATE = table.Column<string>(type: "text", nullable: false),
                    PAYCODE = table.Column<string>(type: "text", nullable: false),
                    EMPLOYEEID = table.Column<string>(type: "text", nullable: false),
                    LASTNAME = table.Column<string>(type: "text", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "text", nullable: false),
                    FILESTATUS = table.Column<string>(type: "text", nullable: false),
                    OTCODE = table.Column<string>(type: "text", nullable: false),
                    DATE = table.Column<string>(type: "text", nullable: false),
                    COSTCENTER = table.Column<string>(type: "text", nullable: false),
                    OTRATE = table.Column<string>(type: "text", nullable: false),
                    OTHOURS = table.Column<string>(type: "text", nullable: false),
                    OTMINUTES = table.Column<string>(type: "text", nullable: false),
                    OTAMOUNT = table.Column<string>(type: "text", nullable: false),
                    OTNPHOURS = table.Column<string>(type: "text", nullable: false),
                    OTNPMINUTES = table.Column<string>(type: "text", nullable: false),
                    OTNPAMOUNT = table.Column<string>(type: "text", nullable: false),
                    OTNP2HOURS = table.Column<string>(type: "text", nullable: false),
                    OTNP2MINUTES = table.Column<string>(type: "text", nullable: false),
                    OTNP2AMOUNT = table.Column<string>(type: "text", nullable: false),
                    OTANDNPAMOUNT = table.Column<string>(type: "text", nullable: false),
                    RECURSTART = table.Column<string>(type: "text", nullable: false),
                    RECUREND = table.Column<string>(type: "text", nullable: false),
                    FREQ = table.Column<string>(type: "text", nullable: false),
                    REMARKS = table.Column<string>(type: "text", nullable: false),
                    SYSTEMOTHOURS = table.Column<string>(type: "text", nullable: false),
                    SYSTEMOTTIME = table.Column<string>(type: "text", nullable: false),
                    SYSTEMNPHOURS = table.Column<string>(type: "text", nullable: false),
                    SYSTEMNPTIME = table.Column<string>(type: "text", nullable: false),
                    FROM = table.Column<string>(type: "text", nullable: false),
                    TO = table.Column<string>(type: "text", nullable: false),
                    JECOSTCENTER = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTReg", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OTReg");
        }
    }
}
