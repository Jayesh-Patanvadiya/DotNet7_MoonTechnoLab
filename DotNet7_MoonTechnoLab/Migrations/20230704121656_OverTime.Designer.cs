﻿// <auto-generated />
using DotNet7_MoonTechnoLab.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotNet7_MoonTechnoLab.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230704121656_OverTime")]
    partial class OverTime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DotNet7_MoonTechnoLab.Model.OTReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("COSTCENTER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COST CENTER");

                    b.Property<string>("DATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE");

                    b.Property<string>("EMPLOYEEID")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE ID#");

                    b.Property<string>("FILESTATUS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FILE STATUS");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("FREQ")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FREQ");

                    b.Property<string>("FROM")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FROM");

                    b.Property<string>("JECOSTCENTER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "JE COST CENTER");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("OTAMOUNT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT AMOUNT");

                    b.Property<string>("OTANDNPAMOUNT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT AND NP AMOUNT");

                    b.Property<string>("OTCODE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT CODE");

                    b.Property<string>("OTHOURS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT HOURS");

                    b.Property<string>("OTMINUTES")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT MINUTES");

                    b.Property<string>("OTNP2AMOUNT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 AMOUNT");

                    b.Property<string>("OTNP2HOURS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 HOURS");

                    b.Property<string>("OTNP2MINUTES")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 MINUTES");

                    b.Property<string>("OTNPAMOUNT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP AMOUNT");

                    b.Property<string>("OTNPHOURS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP HOURS");

                    b.Property<string>("OTNPMINUTES")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP MINUTES");

                    b.Property<string>("OTRATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT RATE");

                    b.Property<string>("PAYCODE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY CODE");

                    b.Property<string>("PAYDATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY DATE");

                    b.Property<string>("PAYROLL")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL #");

                    b.Property<string>("RECUREND")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "RECUR END");

                    b.Property<string>("RECURSTART")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "RECUR START");

                    b.Property<string>("REMARKS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REMARKS");

                    b.Property<string>("SYSTEMNPHOURS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM NP HOURS");

                    b.Property<string>("SYSTEMNPTIME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM NP TIME");

                    b.Property<string>("SYSTEMOTHOURS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM OT HOURS");

                    b.Property<string>("SYSTEMOTTIME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM OT TIME");

                    b.Property<string>("TO")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TO");

                    b.HasKey("Id");

                    b.ToTable("OTReg");
                });

            modelBuilder.Entity("DotNet7_MoonTechnoLab.Model.OverTimeCal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ATTDEDUCTION")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ATT DEDUCTION");

                    b.Property<string>("EMPLOYEEID")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE ID#");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("OVERTIME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OVERTIME");

                    b.HasKey("Id");

                    b.ToTable("OverTimeCal");
                });

            modelBuilder.Entity("DotNet7_MoonTechnoLab.Model.PayReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ADJUSTMENTS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ADJUSTMENTS");

                    b.Property<string>("ATTDEDUCTION")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ATT DEDUCTION");

                    b.Property<string>("BANKACCT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BANK ACCT#");

                    b.Property<string>("BANKNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BANK NAME");

                    b.Property<string>("BASICSALARY")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BASIC SALARY");

                    b.Property<string>("COMMENTFIELD")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COMMENT FIELD");

                    b.Property<string>("COSTCENTER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COST CENTER");

                    b.Property<string>("CURRENCY")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "CURRENCY");

                    b.Property<string>("DAILYRATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DAILY RATE");

                    b.Property<string>("DATEEMPLOYED")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE EMPLOYED");

                    b.Property<string>("DATETERMINATED")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE TERMINATED");

                    b.Property<string>("DEDUCTIONS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DEDUCTIONS");

                    b.Property<string>("EMPLOYEEID")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE ID#");

                    b.Property<string>("EMPLOYEEMCR")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE MCR");

                    b.Property<string>("EMPLOYEEPAGIBIG")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE PAG-IBIG");

                    b.Property<string>("EMPLOYEESSS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE SSS");

                    b.Property<string>("EMPLOYEREC")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER EC");

                    b.Property<string>("EMPLOYERMCR")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER MCR");

                    b.Property<string>("EMPLOYERPAGIBIG")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER PAG-IBIG");

                    b.Property<string>("EMPLOYERSSS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER SSS");

                    b.Property<string>("ERRORFIELD")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ERROR FIELD");

                    b.Property<string>("EXCHANGERATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EXCHANGE RATE");

                    b.Property<string>("FILESTATUS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FILE STATUS");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("FROM")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FROM");

                    b.Property<string>("GROSSINCOME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "GROSS INCOME");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("LOANPAYMENTS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LOAN PAYMENTS");

                    b.Property<string>("MONTHLYALLOW")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MONTHLY ALLOW");

                    b.Property<string>("MONTHLYSALARYRATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MONTHLY SALARY RATE");

                    b.Property<string>("MTDBASIC")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD BASIC");

                    b.Property<string>("MTDECEMPLOYER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD EC EMPLOYER");

                    b.Property<string>("MTDGROSS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD GROSS");

                    b.Property<string>("MTDMCREMPLOYEE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD MCR EMPLOYEE");

                    b.Property<string>("MTDMCREMPLOYER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD MCR EMPLOYER");

                    b.Property<string>("MTDNTX")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD NTX");

                    b.Property<string>("MTDPAGIBIGEMPLOYEE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD PAG-IBIG EMPLOYEE");

                    b.Property<string>("MTDPAGIBIGEMPLOYER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD PAG-IBIG EMPLOYER");

                    b.Property<string>("MTDSSSEMPLOYEE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD SSS EMPLOYEE");

                    b.Property<string>("MTDSSSEMPLOYER")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD SSS EMPLOYER");

                    b.Property<string>("MTDWHTAX")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD WH TAX");

                    b.Property<string>("NETSALARY")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "NET SALARY");

                    b.Property<string>("NETSALARYAFTERTAX")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "NET SALARY AFTER TAX");

                    b.Property<string>("OTHERNTXINCOME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OTHER NTX INCOME");

                    b.Property<string>("OTHERTXINCOME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OTHER TX INCOME");

                    b.Property<string>("OVERTIME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OVERTIME");

                    b.Property<string>("PAYCODE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY CODE");

                    b.Property<string>("PAYDATE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY DATE");

                    b.Property<string>("PAYMENTFREQ")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYMENT FREQ");

                    b.Property<string>("PAYMENTTYPE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYMENT TYPE");

                    b.Property<string>("PAYROLL")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL #");

                    b.Property<string>("PAYROLLCOST")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL COST");

                    b.Property<string>("PREVIOUSYTDBON13THNT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD BON/13TH NT");

                    b.Property<string>("PREVIOUSYTDBON13THTX")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD BON/13TH TX");

                    b.Property<string>("PREVIOUSYTDGROSS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD GROSS");

                    b.Property<string>("PREVIOUSYTDMCR")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD MCR");

                    b.Property<string>("PREVIOUSYTDPAGIBIG")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD PAG-IBIG");

                    b.Property<string>("PREVIOUSYTDSSS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD SSS");

                    b.Property<string>("PREVIOUSYTDWITHOLDING")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD WITHOLDING");

                    b.Property<string>("SALARYRATETYPE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SALARY RATE TYPE");

                    b.Property<string>("TAXABLEINCOME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAXABLE INCOME");

                    b.Property<string>("TAXSTATUS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAX STATUS");

                    b.Property<string>("TAXTABLE")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAX TABLE");

                    b.Property<string>("TO")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TO");

                    b.Property<string>("WITHOLDINGTAX")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "WITHOLDING TAX");

                    b.HasKey("Id");

                    b.ToTable("PayReg");
                });

            modelBuilder.Entity("DotNet7_MoonTechnoLab.Model.TimeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ABSENTDAYS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ABSENT DAYS");

                    b.Property<string>("DOUBLEHOLIDAYOT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOLIDAY OT");

                    b.Property<string>("DOUBLEHOLIDAYOT8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOLIDAY OT > 8HRS");

                    b.Property<string>("DOUBLEHOLIDAYOT8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOLIDAY OT > 8 (NP HRS 10%)");

                    b.Property<string>("DOUBLEHOLIDAYOTNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOLIDAY OT (NP HRS 10%)");

                    b.Property<string>("DOUBLEHOLIDAYRD")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOLIDAY RD");

                    b.Property<string>("DOUBLEHOLONRD8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOL ON RD > 8HRS");

                    b.Property<string>("DOUBLEHOLRD8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOL RD > 8 (NP HRS 10%)");

                    b.Property<string>("DOUBLEHOLRDNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DOUBLE HOL RD (NP HRS 10%)");

                    b.Property<string>("EMPID")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMP ID#");

                    b.Property<string>("FIRSTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("LASTNAME")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("LEGALHOLOT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL OT");

                    b.Property<string>("LEGALHOLOT8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL OT > 8HRS");

                    b.Property<string>("LEGALHOLOT8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL OT >8 (NP HRS 10%)");

                    b.Property<string>("LEGALHOLOTNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL OT (NP HRS 10%)");

                    b.Property<string>("LEGALHOLRD")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL RD");

                    b.Property<string>("LEGALHOLRD8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL RD >8HRS");

                    b.Property<string>("LEGALHOLRD8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL RD >8 (NP HRS 10%)");

                    b.Property<string>("LEGALHOLRDNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LEGAL HOL RD (NP HRS 10%)");

                    b.Property<string>("LWOPDAYS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LWOP DAYS");

                    b.Property<string>("NITEDIFF10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "NITE-DIFF 10%");

                    b.Property<string>("OTHERLVDAYS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OTHER LV DAYS");

                    b.Property<string>("PAYROLL")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL #");

                    b.Property<string>("REGDAYSWRK")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REG DAYS WRK");

                    b.Property<string>("REGOTNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REG-OT (NP HRS 10%)");

                    b.Property<string>("REGULAROT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REGULAR-OT");

                    b.Property<string>("RESTDAYOT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REST DAY OT");

                    b.Property<string>("RESTDAYOT8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REST DAY OT > 8HRS");

                    b.Property<string>("RESTDAYOT8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REST DAY OT > 8 (NP HRS 10%)");

                    b.Property<string>("RESTDAYOTNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REST DAY OT (NP HRS 10%)");

                    b.Property<string>("Remarks")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "Remarks");

                    b.Property<string>("SLDAYS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SL DAYS");

                    b.Property<string>("SPECIALHOLIDAYRD")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECIAL HOLIDAY RD");

                    b.Property<string>("SPECIALHOLRDNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECIAL HOL RD (NP HRS 10%)");

                    b.Property<string>("SPECLHOLIDAYONRD8HRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOLIDAY ON RD > 8HRS");

                    b.Property<string>("SPECLHOLIDAYOT8")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOLIDAY OT >8");

                    b.Property<string>("SPECLHOLOT")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOL OT");

                    b.Property<string>("SPECLHOLOT8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOL OT >8 (NP HRS 10%)");

                    b.Property<string>("SPECLHOLOTNPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOL OT (NP HRS 10%)");

                    b.Property<string>("SPECLHOLRD8NPHRS10")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SPECL HOL RD > 8 (NP HRS 10%)");

                    b.Property<string>("TARDYHRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TARDY HRS");

                    b.Property<string>("UNDERTIMEHRS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "UNDERTIME HRS");

                    b.Property<string>("VLDAYS")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "VL DAYS");

                    b.HasKey("Id");

                    b.ToTable("TimeAttendance");
                });
#pragma warning restore 612, 618
        }
    }
}
