using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNet7_MoonTechnoLab.Model
{
	public class OTReg
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
		public string? PAYCODE { get; set; }

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

		[JsonProperty("OT CODE")]
		[JsonPropertyName("OT CODE")]
		public string? OTCODE { get; set; }

		[JsonProperty("DATE")]
		[JsonPropertyName("DATE")]
		public string? DATE { get; set; }

		[JsonProperty("COST CENTER")]
		[JsonPropertyName("COST CENTER")]
		public string? COSTCENTER { get; set; }

		[JsonProperty("OT RATE")]
		[JsonPropertyName("OT RATE")]
		public string? OTRATE { get; set; }

		[JsonProperty("OT HOURS")]
		[JsonPropertyName("OT HOURS")]
		public string? OTHOURS { get; set; }

		[JsonProperty("OT MINUTES")]
		[JsonPropertyName("OT MINUTES")]
		public string? OTMINUTES { get; set; }

		[JsonProperty("OT AMOUNT")]
		[JsonPropertyName("OT AMOUNT")]
		public string? OTAMOUNT { get; set; }

		[JsonProperty("OT NP HOURS")]
		[JsonPropertyName("OT NP HOURS")]
		public string? OTNPHOURS { get; set; }

		[JsonProperty("OT NP MINUTES")]
		[JsonPropertyName("OT NP MINUTES")]
		public string? OTNPMINUTES { get; set; }

		[JsonProperty("OT NP AMOUNT")]
		[JsonPropertyName("OT NP AMOUNT")]
		public string? OTNPAMOUNT { get; set; }

		[JsonProperty("OT NP2 HOURS")]
		[JsonPropertyName("OT NP2 HOURS")]
		public string? OTNP2HOURS { get; set; }

		[JsonProperty("OT NP2 MINUTES")]
		[JsonPropertyName("OT NP2 MINUTES")]
		public string? OTNP2MINUTES { get; set; }

		[JsonProperty("OT NP2 AMOUNT")]
		[JsonPropertyName("OT NP2 AMOUNT")]
		public string? OTNP2AMOUNT { get; set; }

		[JsonProperty("OT AND NP AMOUNT")]
		[JsonPropertyName("OT AND NP AMOUNT")]
		public string? OTANDNPAMOUNT { get; set; }

		[JsonProperty("RECUR START")]
		[JsonPropertyName("RECUR START")]
		public string? RECURSTART { get; set; }

		[JsonProperty("RECUR END")]
		[JsonPropertyName("RECUR END")]
		public string? RECUREND { get; set; }

		[JsonProperty("FREQ")]
		[JsonPropertyName("FREQ")]
		public string? FREQ { get; set; }

		[JsonProperty("REMARKS")]
		[JsonPropertyName("REMARKS")]
		public string? REMARKS { get; set; }

		[JsonProperty("SYSTEM OT HOURS")]
		[JsonPropertyName("SYSTEM OT HOURS")]
		public string? SYSTEMOTHOURS { get; set; }

		[JsonProperty("SYSTEM OT TIME")]
		[JsonPropertyName("SYSTEM OT TIME")]
		public string? SYSTEMOTTIME { get; set; }

		[JsonProperty("SYSTEM NP HOURS")]
		[JsonPropertyName("SYSTEM NP HOURS")]
		public string? SYSTEMNPHOURS { get; set; }

		[JsonProperty("SYSTEM NP TIME")]
		[JsonPropertyName("SYSTEM NP TIME")]
		public string? SYSTEMNPTIME { get; set; }

		[JsonProperty("FROM")]
		[JsonPropertyName("FROM")]
		public string? FROM { get; set; }

		[JsonProperty("TO")]
		[JsonPropertyName("TO")]
		public string? TO { get; set; }

		[JsonProperty("JE COST CENTER")]
		[JsonPropertyName("JE COST CENTER")]
		public string? JECOSTCENTER { get; set; }
	}
	
}
