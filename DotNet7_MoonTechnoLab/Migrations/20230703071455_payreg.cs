using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNet7_MoonTechnoLab.Migrations
{
    /// <inheritdoc />
    public partial class payreg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PayReg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PAYROLL = table.Column<int>(type: "integer", nullable: false),
                    PAYDATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PAYCODE = table.Column<string>(type: "text", nullable: false),
                    EMPLOYEEID = table.Column<int>(type: "integer", nullable: false),
                    LASTNAME = table.Column<string>(type: "text", nullable: false),
                    FIRSTNAME = table.Column<string>(type: "text", nullable: false),
                    FILESTATUS = table.Column<string>(type: "text", nullable: false),
                    TAXSTATUS = table.Column<string>(type: "text", nullable: false),
                    MONTHLYSALARYRATE = table.Column<double>(type: "double precision", nullable: false),
                    BASICSALARY = table.Column<double>(type: "double precision", nullable: false),
                    DAILYRATE = table.Column<double>(type: "double precision", nullable: false),
                    SALARYRATETYPE = table.Column<double>(type: "double precision", nullable: false),
                    ATTDEDUCTION = table.Column<string>(type: "text", nullable: false),
                    OVERTIME = table.Column<double>(type: "double precision", nullable: false),
                    OTHERTXINCOME = table.Column<double>(type: "double precision", nullable: false),
                    ADJUSTMENTS = table.Column<double>(type: "double precision", nullable: false),
                    GROSSINCOME = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYEESSS = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYEEMCR = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYEEPAGIBIG = table.Column<double>(type: "double precision", nullable: false),
                    TAXABLEINCOME = table.Column<double>(type: "double precision", nullable: false),
                    WITHOLDINGTAX = table.Column<double>(type: "double precision", nullable: false),
                    NETSALARYAFTERTAX = table.Column<double>(type: "double precision", nullable: false),
                    OTHERNTXINCOME = table.Column<double>(type: "double precision", nullable: false),
                    LOANPAYMENTS = table.Column<double>(type: "double precision", nullable: false),
                    DEDUCTIONS = table.Column<double>(type: "double precision", nullable: false),
                    NETSALARY = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYERSSS = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYERMCR = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYEREC = table.Column<double>(type: "double precision", nullable: false),
                    EMPLOYERPAGIBIG = table.Column<double>(type: "double precision", nullable: false),
                    PAYROLLCOST = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDGROSS = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDWITHOLDING = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDSSS = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDMCR = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDPAGIBIG = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDBON13THNT = table.Column<double>(type: "double precision", nullable: false),
                    PREVIOUSYTDBON13THTX = table.Column<double>(type: "double precision", nullable: false),
                    PAYMENTTYPE = table.Column<string>(type: "text", nullable: false),
                    BANKACCT = table.Column<string>(type: "text", nullable: false),
                    BANKNAME = table.Column<string>(type: "text", nullable: false),
                    COMMENTFIELD = table.Column<string>(type: "text", nullable: false),
                    ERRORFIELD = table.Column<string>(type: "text", nullable: false),
                    DATEEMPLOYED = table.Column<string>(type: "text", nullable: false),
                    DATETERMINATED = table.Column<string>(type: "text", nullable: false),
                    COSTCENTER = table.Column<int>(type: "integer", nullable: false),
                    CURRENCY = table.Column<string>(type: "text", nullable: false),
                    EXCHANGERATE = table.Column<int>(type: "integer", nullable: false),
                    TAXTABLE = table.Column<string>(type: "text", nullable: false),
                    PAYMENTFREQ = table.Column<string>(type: "text", nullable: false),
                    MTDGROSS = table.Column<double>(type: "double precision", nullable: false),
                    MTDBASIC = table.Column<double>(type: "double precision", nullable: false),
                    MTDSSSEMPLOYEE = table.Column<double>(type: "double precision", nullable: false),
                    MTDMCREMPLOYEE = table.Column<double>(type: "double precision", nullable: false),
                    MTDPAGIBIGEMPLOYEE = table.Column<double>(type: "double precision", nullable: false),
                    MTDSSSEMPLOYER = table.Column<double>(type: "double precision", nullable: false),
                    MTDMCREMPLOYER = table.Column<double>(type: "double precision", nullable: false),
                    MTDPAGIBIGEMPLOYER = table.Column<double>(type: "double precision", nullable: false),
                    MTDWHTAX = table.Column<double>(type: "double precision", nullable: false),
                    MONTHLYALLOW = table.Column<double>(type: "double precision", nullable: false),
                    MTDNTX = table.Column<double>(type: "double precision", nullable: false),
                    FROM = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayReg", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayReg");
        }
    }
}
