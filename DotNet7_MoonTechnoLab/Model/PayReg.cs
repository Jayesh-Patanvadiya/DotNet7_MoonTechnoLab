using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNet7_MoonTechnoLab.Model
{
	public class PayReg
	{

		public int Id { get; set; }

		[JsonProperty("PAYROLL #")]
		[JsonPropertyName("PAYROLL #")]
		public string? PAYROLL { get; set; }

		[JsonProperty("PAY DATE")]
		[JsonPropertyName("PAY DATE")]
		public string? PAYDATE { get; set; }

		[JsonProperty("PAY CODE")]
		[JsonPropertyName("PAY CODE")]
		public string PAYCODE { get; set; }

		[JsonProperty("EMPLOYEE ID#")]
		[JsonPropertyName("EMPLOYEE ID#")]
		public string? EMPLOYEEID { get; set; }

		[JsonProperty("LAST NAME")]
		[JsonPropertyName("LAST NAME")]
		public string? LASTNAME { get; set; }

		[JsonProperty("FIRST NAME")]
		[JsonPropertyName("FIRST NAME")]
		public string? FIRSTNAME { get; set; }

		[JsonProperty("FILE STATUS")]
		[JsonPropertyName("FILE STATUS")]
		public string? FILESTATUS { get; set; }

		[JsonProperty("TAX STATUS")]
		[JsonPropertyName("TAX STATUS")]
		public string? TAXSTATUS { get; set; }

		[JsonProperty("MONTHLY SALARY RATE")]
		[JsonPropertyName("MONTHLY SALARY RATE")]
		public string? MONTHLYSALARYRATE { get; set; }

		[JsonProperty("BASIC SALARY")]
		[JsonPropertyName("BASIC SALARY")]
		public string? BASICSALARY { get; set; }

		[JsonProperty("DAILY RATE")]
		[JsonPropertyName("DAILY RATE")]
		public string? DAILYRATE { get; set; }

		[JsonProperty("SALARY RATE TYPE")]
		[JsonPropertyName("SALARY RATE TYPE")]
		public string? SALARYRATETYPE { get; set; }

		[JsonProperty("ATT DEDUCTION")]
		[JsonPropertyName("ATT DEDUCTION")]
		public string? ATTDEDUCTION { get; set; }

		[JsonProperty("OVERTIME")]
		[JsonPropertyName("OVERTIME")]
		public string? OVERTIME { get; set; }

		[JsonProperty("OTHER TX INCOME")]
		[JsonPropertyName("OTHER TX INCOME")]
		public string? OTHERTXINCOME { get; set; }

		[JsonProperty("ADJUSTMENTS")]
		[JsonPropertyName("ADJUSTMENTS")]
		public string? ADJUSTMENTS { get; set; }

		[JsonProperty("GROSS INCOME")]
		[JsonPropertyName("GROSS INCOME")]
		public string? GROSSINCOME { get; set; }

		[JsonProperty("EMPLOYEE SSS")]
		[JsonPropertyName("EMPLOYEE SSS")]
		public string? EMPLOYEESSS { get; set; }

		[JsonProperty("EMPLOYEE MCR")]
		[JsonPropertyName("EMPLOYEE MCR")]
		public string? EMPLOYEEMCR { get; set; }

		[JsonProperty("EMPLOYEE PAG-IBIG")]
		[JsonPropertyName("EMPLOYEE PAG-IBIG")]
		public string? EMPLOYEEPAGIBIG { get; set; }

		[JsonProperty("TAXABLE INCOME")]
		[JsonPropertyName("TAXABLE INCOME")]
		public string? TAXABLEINCOME { get; set; }

		[JsonProperty("WITHOLDING TAX")]
		[JsonPropertyName("WITHOLDING TAX")]
		public string? WITHOLDINGTAX { get; set; }

		[JsonProperty("NET SALARY AFTER TAX")]
		[JsonPropertyName("NET SALARY AFTER TAX")]
		public string? NETSALARYAFTERTAX { get; set; }

		[JsonProperty("OTHER NTX INCOME")]
		[JsonPropertyName("OTHER NTX INCOME")]
		public string? OTHERNTXINCOME { get; set; }

		[JsonProperty("LOAN PAYMENTS")]
		[JsonPropertyName("LOAN PAYMENTS")]
		public string? LOANPAYMENTS { get; set; }

		[JsonProperty("DEDUCTIONS")]
		[JsonPropertyName("DEDUCTIONS")]
		public string? DEDUCTIONS { get; set; }

		[JsonProperty("NET SALARY")]
		[JsonPropertyName("NET SALARY")]
		public string? NETSALARY { get; set; }

		[JsonProperty("EMPLOYER SSS")]
		[JsonPropertyName("EMPLOYER SSS")]
		public string? EMPLOYERSSS { get; set; }

		[JsonProperty("EMPLOYER MCR")]
		[JsonPropertyName("EMPLOYER MCR")]
		public string? EMPLOYERMCR { get; set; }

		[JsonProperty("EMPLOYER EC")]
		[JsonPropertyName("EMPLOYER EC")]
		public string? EMPLOYEREC { get; set; }

		[JsonProperty("EMPLOYER PAG-IBIG")]
		[JsonPropertyName("EMPLOYER PAG-IBIG")]
		public string? EMPLOYERPAGIBIG { get; set; }

		[JsonProperty("PAYROLL COST")]
		[JsonPropertyName("PAYROLL COST")]
		public string? PAYROLLCOST { get; set; }

		[JsonProperty("PREVIOUS YTD GROSS")]
		[JsonPropertyName("PREVIOUS YTD GROSS")]
		public string? PREVIOUSYTDGROSS { get; set; }

		[JsonProperty("PREVIOUS YTD WITHOLDING")]
		[JsonPropertyName("PREVIOUS YTD WITHOLDING")]
		public string? PREVIOUSYTDWITHOLDING { get; set; }

		[JsonProperty("PREVIOUS YTD SSS")]
		[JsonPropertyName("PREVIOUS YTD SSS")]
		public string? PREVIOUSYTDSSS { get; set; }

		[JsonProperty("PREVIOUS YTD MCR")]
		[JsonPropertyName("PREVIOUS YTD MCR")]
		public string? PREVIOUSYTDMCR { get; set; }

		[JsonProperty("PREVIOUS YTD PAG-IBIG")]
		[JsonPropertyName("PREVIOUS YTD PAG-IBIG")]
		public string? PREVIOUSYTDPAGIBIG { get; set; }

		[JsonProperty("PREVIOUS YTD BON/13TH NT")]
		[JsonPropertyName("PREVIOUS YTD BON/13TH NT")]
		public string? PREVIOUSYTDBON13THNT { get; set; }

		[JsonProperty("PREVIOUS YTD BON/13TH TX")]
		[JsonPropertyName("PREVIOUS YTD BON/13TH TX")]
		public string? PREVIOUSYTDBON13THTX { get; set; }

		[JsonProperty("PAYMENT TYPE")]
		[JsonPropertyName("PAYMENT TYPE")]
		public string? PAYMENTTYPE { get; set; }

		[JsonProperty("BANK ACCT#")]
		[JsonPropertyName("BANK ACCT#")]
		public string? BANKACCT { get; set; }

		[JsonProperty("BANK NAME")]
		[JsonPropertyName("BANK NAME")]
		public string? BANKNAME { get; set; }

		[JsonProperty("COMMENT FIELD")]
		[JsonPropertyName("COMMENT FIELD")]
		public string? COMMENTFIELD { get; set; }

		[JsonProperty("ERROR FIELD")]
		[JsonPropertyName("ERROR FIELD")]
		public string? ERRORFIELD { get; set; }

		[JsonProperty("DATE EMPLOYED")]
		[JsonPropertyName("DATE EMPLOYED")]
		public string? DATEEMPLOYED { get; set; }

		[JsonProperty("DATE TERMINATED")]
		[JsonPropertyName("DATE TERMINATED")]
		public string? DATETERMINATED { get; set; }

		[JsonProperty("COST CENTER")]
		[JsonPropertyName("COST CENTER")]
		public string? COSTCENTER { get; set; }

		[JsonProperty("CURRENCY")]
		[JsonPropertyName("CURRENCY")]
		public string? CURRENCY { get; set; }

		[JsonProperty("EXCHANGE RATE")]
		[JsonPropertyName("EXCHANGE RATE")]
		public string? EXCHANGERATE { get; set; }

		[JsonProperty("TAX TABLE")]
		[JsonPropertyName("TAX TABLE")]
		public string? TAXTABLE { get; set; }

		[JsonProperty("PAYMENT FREQ")]
		[JsonPropertyName("PAYMENT FREQ")]
		public string? PAYMENTFREQ { get; set; }

		[JsonProperty("MTD GROSS")]
		[JsonPropertyName("MTD GROSS")]
		public string? MTDGROSS { get; set; }

		[JsonProperty("MTD BASIC")]
		[JsonPropertyName("MTD BASIC")]
		public string? MTDBASIC { get; set; }

		[JsonProperty("MTD SSS EMPLOYEE")]
		[JsonPropertyName("MTD SSS EMPLOYEE")]
		public string? MTDSSSEMPLOYEE { get; set; }

		[JsonProperty("MTD MCR EMPLOYEE")]
		[JsonPropertyName("MTD MCR EMPLOYEE")]
		public string? MTDMCREMPLOYEE { get; set; }

		[JsonProperty("MTD PAG-IBIG EMPLOYEE")]
		[JsonPropertyName("MTD PAG-IBIG EMPLOYEE")]
		public string? MTDPAGIBIGEMPLOYEE { get; set; }

		[JsonProperty("MTD SSS EMPLOYER")]
		[JsonPropertyName("MTD SSS EMPLOYER")]
		public string? MTDSSSEMPLOYER { get; set; }

		[JsonProperty("MTD MCR EMPLOYER")]
		[JsonPropertyName("MTD MCR EMPLOYER")]
		public string? MTDMCREMPLOYER { get; set; }

		[JsonProperty("MTD EC EMPLOYER")]
		[JsonPropertyName("MTD EC EMPLOYER")]
		public string? MTDECEMPLOYER { get; set; }

		[JsonProperty("MTD PAG-IBIG EMPLOYER")]
		[JsonPropertyName("MTD PAG-IBIG EMPLOYER")]
		public string? MTDPAGIBIGEMPLOYER { get; set; }

		[JsonProperty("MTD WH TAX")]
		[JsonPropertyName("MTD WH TAX")]
		public string? MTDWHTAX { get; set; }

		[JsonProperty("MONTHLY ALLOW")]
		[JsonPropertyName("MONTHLY ALLOW")]
		public string? MONTHLYALLOW { get; set; }

		[JsonProperty("MTD NTX")]
		[JsonPropertyName("MTD NTX")]
		public string? MTDNTX { get; set; }

		[JsonProperty("FROM")]
		[JsonPropertyName("FROM")]
		public string? FROM { get; set; }

		[JsonProperty("TO")]
		[JsonPropertyName("TO")]
		public string? TO { get; set; }
		

	}
}
