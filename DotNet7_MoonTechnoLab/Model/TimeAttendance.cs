using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNet7_MoonTechnoLab.Model
{
	public class TimeAttendance
	{
		public int Id { get; set; }
		[JsonProperty("PAYROLL #")]
		[JsonPropertyName("PAYROLL #")]
		public string? PAYROLL { get; set; }

		[JsonProperty("EMP ID#")]
		[JsonPropertyName("EMP ID#")]
		public string? EMPID { get; set; }

		[JsonProperty("LAST NAME")]
		[JsonPropertyName("LAST NAME")]
		public string? LASTNAME { get; set; }

		[JsonProperty("FIRST NAME")]
		[JsonPropertyName("FIRST NAME")]
		public string? FIRSTNAME { get; set; }

		[JsonProperty("REG DAYS WRK")]
		[JsonPropertyName("REG DAYS WRK")]
		public string? REGDAYSWRK { get; set; }

		[JsonProperty("TARDY HRS")]
		[JsonPropertyName("TARDY HRS")]
		public string? TARDYHRS { get; set; }

		[JsonProperty("UNDERTIME HRS")]
		[JsonPropertyName("UNDERTIME HRS")]
		public string? UNDERTIMEHRS { get; set; }

		[JsonProperty("ABSENT DAYS")]
		[JsonPropertyName("ABSENT DAYS")]
		public string? ABSENTDAYS { get; set; }

		[JsonProperty("LWOP DAYS")]
		[JsonPropertyName("LWOP DAYS")]
		public string? LWOPDAYS { get; set; }

		[JsonProperty("VL DAYS")]
		[JsonPropertyName("VL DAYS")]
		public string? VLDAYS { get; set; }

		[JsonProperty("SL DAYS")]
		[JsonPropertyName("SL DAYS")]
		public string? SLDAYS { get; set; }

		[JsonProperty("OTHER LV DAYS")]
		[JsonPropertyName("OTHER LV DAYS")]
		public string? OTHERLVDAYS { get; set; }

		[JsonProperty("NITE-DIFF 10%")]
		[JsonPropertyName("NITE-DIFF 10%")]
		public string? NITEDIFF10 { get; set; }

		[JsonProperty("REGULAR-OT")]
		[JsonPropertyName("REGULAR-OT")]
		public string? REGULAROT { get; set; }

		[JsonProperty("REG-OT (NP HRS 10%)")]
		[JsonPropertyName("REG-OT (NP HRS 10%)")]
		public string? REGOTNPHRS10 { get; set; }

		[JsonProperty("LEGAL HOL OT")]
		[JsonPropertyName("LEGAL HOL OT")]
		public string? LEGALHOLOT { get; set; }

		[JsonProperty("LEGAL HOL OT (NP HRS 10%)")]
		[JsonPropertyName("LEGAL HOL OT (NP HRS 10%)")]
		public string? LEGALHOLOTNPHRS10 { get; set; }

		[JsonProperty("LEGAL HOL OT > 8HRS")]
		[JsonPropertyName("LEGAL HOL OT > 8HRS")]
		public string? LEGALHOLOT8HRS { get; set; }

		[JsonProperty("LEGAL HOL OT >8 (NP HRS 10%)")]
		[JsonPropertyName("LEGAL HOL OT >8 (NP HRS 10%)")]
		public string? LEGALHOLOT8NPHRS10 { get; set; }

		[JsonProperty("LEGAL HOL RD")]
		[JsonPropertyName("LEGAL HOL RD")]
		public string? LEGALHOLRD { get; set; }

		[JsonProperty("LEGAL HOL RD (NP HRS 10%)")]
		[JsonPropertyName("LEGAL HOL RD (NP HRS 10%)")]
		public string? LEGALHOLRDNPHRS10 { get; set; }

		[JsonProperty("LEGAL HOL RD >8HRS")]
		[JsonPropertyName("LEGAL HOL RD >8HRS")]
		public string? LEGALHOLRD8HRS { get; set; }

		[JsonProperty("LEGAL HOL RD >8 (NP HRS 10%)")]
		[JsonPropertyName("LEGAL HOL RD >8 (NP HRS 10%)")]
		public string? LEGALHOLRD8NPHRS10 { get; set; }

		[JsonProperty("SPECL HOL OT")]
		[JsonPropertyName("SPECL HOL OT")]
		public string? SPECLHOLOT { get; set; }

		[JsonProperty("SPECL HOL OT (NP HRS 10%)")]
		[JsonPropertyName("SPECL HOL OT (NP HRS 10%)")]
		public string? SPECLHOLOTNPHRS10 { get; set; }

		[JsonProperty("SPECL HOLIDAY OT >8")]
		[JsonPropertyName("SPECL HOLIDAY OT >8")]
		public string? SPECLHOLIDAYOT8 { get; set; }

		[JsonProperty("SPECL HOL OT >8 (NP HRS 10%)")]
		[JsonPropertyName("SPECL HOL OT >8 (NP HRS 10%)")]
		public string? SPECLHOLOT8NPHRS10 { get; set; }

		[JsonProperty("SPECIAL HOLIDAY RD")]
		[JsonPropertyName("SPECIAL HOLIDAY RD")]
		public string? SPECIALHOLIDAYRD { get; set; }

		[JsonProperty("SPECIAL HOL RD (NP HRS 10%)")]
		[JsonPropertyName("SPECIAL HOL RD (NP HRS 10%)")]
		public string? SPECIALHOLRDNPHRS10 { get; set; }

		[JsonProperty("SPECL HOLIDAY ON RD > 8HRS")]
		[JsonPropertyName("SPECL HOLIDAY ON RD > 8HRS")]
		public string? SPECLHOLIDAYONRD8HRS { get; set; }

		[JsonProperty("SPECL HOL RD > 8 (NP HRS 10%)")]
		[JsonPropertyName("SPECL HOL RD > 8 (NP HRS 10%)")]
		public string? SPECLHOLRD8NPHRS10 { get; set; }

		[JsonProperty("REST DAY OT")]
		[JsonPropertyName("REST DAY OT")]
		public string? RESTDAYOT { get; set; }

		[JsonProperty("REST DAY OT (NP HRS 10%)")]
		[JsonPropertyName("REST DAY OT (NP HRS 10%)")]
		public string? RESTDAYOTNPHRS10 { get; set; }

		[JsonProperty("REST DAY OT > 8HRS")]
		[JsonPropertyName("REST DAY OT > 8HRS")]
		public string? RESTDAYOT8HRS { get; set; }

		[JsonProperty("REST DAY OT > 8 (NP HRS 10%)")]
		[JsonPropertyName("REST DAY OT > 8 (NP HRS 10%)")]
		public string? RESTDAYOT8NPHRS10 { get; set; }

		[JsonProperty("DOUBLE HOLIDAY OT")]
		[JsonPropertyName("DOUBLE HOLIDAY OT")]
		public string? DOUBLEHOLIDAYOT { get; set; }

		[JsonProperty("DOUBLE HOLIDAY OT (NP HRS 10%)")]
		[JsonPropertyName("DOUBLE HOLIDAY OT (NP HRS 10%)")]
		public string? DOUBLEHOLIDAYOTNPHRS10 { get; set; }

		[JsonProperty("DOUBLE HOLIDAY OT > 8HRS")]
		[JsonPropertyName("DOUBLE HOLIDAY OT > 8HRS")]
		public string? DOUBLEHOLIDAYOT8HRS { get; set; }

		[JsonProperty("DOUBLE HOLIDAY OT > 8 (NP HRS 10%)")]
		[JsonPropertyName("DOUBLE HOLIDAY OT > 8 (NP HRS 10%)")]
		public string? DOUBLEHOLIDAYOT8NPHRS10 { get; set; }

		[JsonProperty("DOUBLE HOLIDAY RD")]
		[JsonPropertyName("DOUBLE HOLIDAY RD")]
		public string? DOUBLEHOLIDAYRD { get; set; }

		[JsonProperty("DOUBLE HOL RD (NP HRS 10%)")]
		[JsonPropertyName("DOUBLE HOL RD (NP HRS 10%)")]
		public string? DOUBLEHOLRDNPHRS10 { get; set; }

		[JsonProperty("DOUBLE HOL ON RD > 8HRS")]
		[JsonPropertyName("DOUBLE HOL ON RD > 8HRS")]
		public string? DOUBLEHOLONRD8HRS { get; set; }

		[JsonProperty("DOUBLE HOL RD > 8 (NP HRS 10%)")]
		[JsonPropertyName("DOUBLE HOL RD > 8 (NP HRS 10%)")]
		public string? DOUBLEHOLRD8NPHRS10 { get; set; }

		[JsonProperty("Remarks")]
		[JsonPropertyName("Remarks")]
		public string? Remarks { get; set; }

	}

	
}
