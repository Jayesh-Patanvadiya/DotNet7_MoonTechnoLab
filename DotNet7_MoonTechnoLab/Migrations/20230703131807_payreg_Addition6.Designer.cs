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
    [Migration("20230703131807_payreg_Addition6")]
    partial class payreg_Addition6
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
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COST CENTER");

                    b.Property<string>("DATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE");

                    b.Property<string>("EMPLOYEEID")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE ID#");

                    b.Property<string>("FILESTATUS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FILE STATUS");

                    b.Property<string>("FIRSTNAME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("FREQ")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FREQ");

                    b.Property<string>("FROM")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FROM");

                    b.Property<string>("JECOSTCENTER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "JE COST CENTER");

                    b.Property<string>("LASTNAME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("OTAMOUNT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT AMOUNT");

                    b.Property<string>("OTANDNPAMOUNT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT AND NP AMOUNT");

                    b.Property<string>("OTCODE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT CODE");

                    b.Property<string>("OTHOURS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT HOURS");

                    b.Property<string>("OTMINUTES")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT MINUTES");

                    b.Property<string>("OTNP2AMOUNT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 AMOUNT");

                    b.Property<string>("OTNP2HOURS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 HOURS");

                    b.Property<string>("OTNP2MINUTES")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP2 MINUTES");

                    b.Property<string>("OTNPAMOUNT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP AMOUNT");

                    b.Property<string>("OTNPHOURS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP HOURS");

                    b.Property<string>("OTNPMINUTES")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT NP MINUTES");

                    b.Property<string>("OTRATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OT RATE");

                    b.Property<string>("PAYCODE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY CODE");

                    b.Property<string>("PAYDATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY DATE");

                    b.Property<string>("PAYROLL")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL");

                    b.Property<string>("RECUREND")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "RECUR END");

                    b.Property<string>("RECURSTART")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "RECUR START");

                    b.Property<string>("REMARKS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "REMARKS");

                    b.Property<string>("SYSTEMNPHOURS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM NP HOURS");

                    b.Property<string>("SYSTEMNPTIME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM NP TIME");

                    b.Property<string>("SYSTEMOTHOURS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM OT HOURS");

                    b.Property<string>("SYSTEMOTTIME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SYSTEM OT TIME");

                    b.Property<string>("TO")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TO");

                    b.HasKey("Id");

                    b.ToTable("OTReg");
                });

            modelBuilder.Entity("DotNet7_MoonTechnoLab.Model.PayReg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ADJUSTMENTS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ADJUSTMENTS");

                    b.Property<string>("ATTDEDUCTION")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ATT DEDUCTION");

                    b.Property<string>("BANKACCT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BANK ACCT#");

                    b.Property<string>("BANKNAME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BANK NAME");

                    b.Property<string>("BASICSALARY")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "BASIC SALARY");

                    b.Property<string>("COMMENTFIELD")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COMMENT FIELD");

                    b.Property<string>("COSTCENTER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "COST CENTER");

                    b.Property<string>("CURRENCY")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "CURRENCY");

                    b.Property<string>("DAILYRATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DAILY RATE");

                    b.Property<string>("DATEEMPLOYED")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE EMPLOYED");

                    b.Property<string>("DATETERMINATED")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DATE TERMINATED");

                    b.Property<string>("DEDUCTIONS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "DEDUCTIONS");

                    b.Property<string>("EMPLOYEEID")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE ID#");

                    b.Property<string>("EMPLOYEEMCR")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE MCR");

                    b.Property<string>("EMPLOYEEPAGIBIG")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE PAG-IBIG");

                    b.Property<string>("EMPLOYEESSS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYEE SSS");

                    b.Property<string>("EMPLOYEREC")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER EC");

                    b.Property<string>("EMPLOYERMCR")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER MCR");

                    b.Property<string>("EMPLOYERPAGIBIG")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER PAG-IBIG");

                    b.Property<string>("EMPLOYERSSS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EMPLOYER SSS");

                    b.Property<string>("ERRORFIELD")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "ERROR FIELD");

                    b.Property<string>("EXCHANGERATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "EXCHANGE RATE");

                    b.Property<string>("FILESTATUS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FILE STATUS");

                    b.Property<string>("FIRSTNAME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FIRST NAME");

                    b.Property<string>("FROM")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "FROM");

                    b.Property<string>("GROSSINCOME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "GROSS INCOME");

                    b.Property<string>("LASTNAME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LAST NAME");

                    b.Property<string>("LOANPAYMENTS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "LOAN PAYMENTS");

                    b.Property<string>("MONTHLYALLOW")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MONTHLY ALLOW");

                    b.Property<string>("MONTHLYSALARYRATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MONTHLY SALARY RATE");

                    b.Property<string>("MTDBASIC")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD BASIC");

                    b.Property<string>("MTDECEMPLOYER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD EC EMPLOYER");

                    b.Property<string>("MTDGROSS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD GROSS");

                    b.Property<string>("MTDMCREMPLOYEE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD MCR EMPLOYEE");

                    b.Property<string>("MTDMCREMPLOYER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD MCR EMPLOYER");

                    b.Property<string>("MTDNTX")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD NTX");

                    b.Property<string>("MTDPAGIBIGEMPLOYEE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD PAG-IBIG EMPLOYEE");

                    b.Property<string>("MTDPAGIBIGEMPLOYER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD PAG-IBIG EMPLOYER");

                    b.Property<string>("MTDSSSEMPLOYEE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD SSS EMPLOYEE");

                    b.Property<string>("MTDSSSEMPLOYER")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD SSS EMPLOYER");

                    b.Property<string>("MTDWHTAX")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "MTD WH TAX");

                    b.Property<string>("NETSALARY")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "NET SALARY");

                    b.Property<string>("NETSALARYAFTERTAX")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "NET SALARY AFTER TAX");

                    b.Property<string>("OTHERNTXINCOME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OTHER NTX INCOME");

                    b.Property<string>("OTHERTXINCOME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OTHER TX INCOME");

                    b.Property<string>("OVERTIME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "OVERTIME");

                    b.Property<string>("PAYCODE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY CODE");

                    b.Property<string>("PAYDATE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAY DATE");

                    b.Property<string>("PAYMENTFREQ")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYMENT FREQ");

                    b.Property<string>("PAYMENTTYPE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYMENT TYPE");

                    b.Property<string>("PAYROLL")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL #");

                    b.Property<string>("PAYROLLCOST")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PAYROLL COST");

                    b.Property<string>("PREVIOUSYTDBON13THNT")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD BON/13TH NT");

                    b.Property<string>("PREVIOUSYTDBON13THTX")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD BON/13TH TX");

                    b.Property<string>("PREVIOUSYTDGROSS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD GROSS");

                    b.Property<string>("PREVIOUSYTDMCR")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD MCR");

                    b.Property<string>("PREVIOUSYTDPAGIBIG")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD PAG-IBIG");

                    b.Property<string>("PREVIOUSYTDSSS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD SSS");

                    b.Property<string>("PREVIOUSYTDWITHOLDING")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "PREVIOUS YTD WITHOLDING");

                    b.Property<string>("SALARYRATETYPE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "SALARY RATE TYPE");

                    b.Property<string>("TAXABLEINCOME")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAXABLE INCOME");

                    b.Property<string>("TAXSTATUS")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAX STATUS");

                    b.Property<string>("TAXTABLE")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TAX TABLE");

                    b.Property<string>("TO")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "TO");

                    b.Property<string>("WITHOLDINGTAX")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "WITHOLDING TAX");

                    b.HasKey("Id");

                    b.ToTable("PayReg");
                });
#pragma warning restore 612, 618
        }
    }
}