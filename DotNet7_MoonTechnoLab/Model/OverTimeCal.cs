using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DotNet7_MoonTechnoLab.Model
{
	public class OverTimeCal
	{
		public int Id { get; set; }

		[JsonProperty("OVERTIME")]
		[JsonPropertyName("OVERTIME")]
		public string OVERTIME { get; set; }

	

		[JsonProperty("EMPLOYEE ID#")]
		[JsonPropertyName("EMPLOYEE ID#")]
		public string? EMPLOYEEID { get; set; }

		[JsonProperty("LAST NAME")]
		[JsonPropertyName("LAST NAME")]
		public string? LASTNAME { get; set; }

		[JsonProperty("FIRST NAME")]
		[JsonPropertyName("FIRST NAME")]
		public string? FIRSTNAME { get; set; }

		[JsonProperty("ATT DEDUCTION")]
		[JsonPropertyName("ATT DEDUCTION")]
		public string? ATTDEDUCTION { get; set; }


	}
}
