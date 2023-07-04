using DotNet7_MoonTechnoLab.Model;
using DotNet7_MoonTechnoLab.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.Data;

namespace DotNet7_MoonTechnoLab.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImportExcelController : ControllerBase
	{

		IImportExcelInterface importExcelInterface;
		private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;
		protected readonly IConfiguration _configuration;


		public ImportExcelController(IConfiguration configuration,Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment, IImportExcelInterface _importExcelInterface)
		{
			Environment = _environment;
			importExcelInterface = _importExcelInterface;
			_configuration = configuration;
		}

		[HttpPost("PostPayReg")]
		public async Task<string> PostPayReg(IFormFile excelFile)
		{
			try
			{
				bool hasHeader = true;
				string path = Path.Combine(this.Environment.WebRootPath, _configuration.GetValue<string>("ExcelFiles:PayReg"));
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}

				string fileName = Path.GetFileName(excelFile.FileName);
				string filePath = Path.Combine(path, fileName);
				using (FileStream stream = new FileStream(filePath, FileMode.Create))
				{
					excelFile.CopyTo(stream);
				}
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

				FileInfo existingFile = new FileInfo(filePath);
				using (var excelPack = new ExcelPackage(existingFile))
				{


					//Lets Deal with first worksheet.(You may iterate here if dealing with multiple sheets)
					var ws = excelPack.Workbook.Worksheets[_configuration.GetValue<string>("ExcelFiles:PayReg")];

					//Get all details as DataTable -because Datatable make life easy :)
					DataTable excelasTable = new DataTable();
					foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
					{
						//Get colummn details
						if (!string.IsNullOrEmpty(firstRowCell.Text))
						{
							string firstColumn = string.Format("Column {0}", firstRowCell.Start.Column);
							excelasTable.Columns.Add(hasHeader ? firstRowCell.Text : firstColumn);
						}
					}
					var startRow = hasHeader ? 2 : 1;
					//Get row details
					for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
					{
						var wsRow = ws.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
						DataRow row = excelasTable.Rows.Add();
						foreach (var cell in wsRow)
						{

							row[cell.Start.Column - 1] = cell.Text;
						}
					}

					var data = excelasTable.Rows.OfType<DataRow>()
			   .Select(row => excelasTable.Columns.OfType<DataColumn>()
				   .ToDictionary(col => col.ColumnName, c => row[c] ));


					
					//var serializeData = System.Text.Json.JsonSerializer.Serialize(data);
					var generatedTypeObject =  JsonConvert.SerializeObject(data,
							Newtonsoft.Json.Formatting.None,
							new JsonSerializerSettings
							{
								NullValueHandling = NullValueHandling.Ignore
							});
					var generatedType = JsonConvert.DeserializeObject<List<PayReg>>(generatedTypeObject);

					foreach (var payreg in generatedType)
					{
						
						if (!string.IsNullOrEmpty(payreg.PAYDATE))
						{
							await importExcelInterface.Add(payreg);
							
						}


					}
				}

				return "";
			}
			catch (Exception ex)
			{
				return (ex.Message);
			}


		}
		[HttpPost("OTReg")]
		public async Task<string> PostOTRREg(IFormFile excelFile)
		{
			try
			{
				bool hasHeader = true;
				string path = Path.Combine(this.Environment.WebRootPath, _configuration.GetValue<string>("ExcelFiles:OTReg"));
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}

				string fileName = Path.GetFileName(excelFile.FileName);
				string filePath = Path.Combine(path, fileName);
				using (FileStream stream = new FileStream(filePath, FileMode.Create))
				{
					excelFile.CopyTo(stream);
				}
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

				FileInfo existingFile = new FileInfo(filePath);
				using (var excelPack = new ExcelPackage(existingFile))
				{


					//Lets Deal with first worksheet.(You may iterate here if dealing with multiple sheets)
					var ws = excelPack.Workbook.Worksheets[_configuration.GetValue<string>("ExcelFiles:OTReg")];

					//Get all details as DataTable -because Datatable make life easy :)
					DataTable excelasTable = new DataTable();
					foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
					{
						//Get colummn details
						if (!string.IsNullOrEmpty(firstRowCell.Text))
						{
							string firstColumn = string.Format("Column {0}", firstRowCell.Start.Column);
							excelasTable.Columns.Add(hasHeader ? firstRowCell.Text : firstColumn);
						}
					}
					var startRow = hasHeader ? 2 : 1;
					//Get row details
					for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
					{
						var wsRow = ws.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
						DataRow row = excelasTable.Rows.Add();
						foreach (var cell in wsRow)
						{
							row[cell.Start.Column - 1] = cell.Text;
						}
					}
					var data = excelasTable.Rows.OfType<DataRow>()
			   .Select(row => excelasTable.Columns.OfType<DataColumn>()
				   .ToDictionary(col => col.ColumnName, c => row[c]));

					var generatedTypeObject = JsonConvert.SerializeObject(data,
								Newtonsoft.Json.Formatting.None,
								new JsonSerializerSettings
								{
									NullValueHandling = NullValueHandling.Ignore
								});
					var generatedType = JsonConvert.DeserializeObject<List<OTReg>>(generatedTypeObject);


					foreach (var OTReg in generatedType)
					{
						
						if (!string.IsNullOrEmpty(OTReg.PAYDATE))
						{
							await importExcelInterface.Add(OTReg);

						}


					}
				}

				return "";
			}
			catch (Exception ex)
			{
				return (ex.Message);
			}


		}

		[HttpPost("TimeAttendance")]
		public async Task<string> PostTimeAttendance(IFormFile excelFile)
		{
			try
			{
				bool hasHeader = true;
				string path = Path.Combine(this.Environment.WebRootPath, _configuration.GetValue<string>("ExcelFiles:TimeAttendance"));
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}

				string fileName = Path.GetFileName(excelFile.FileName);
				string filePath = Path.Combine(path, fileName);
				using (FileStream stream = new FileStream(filePath, FileMode.Create))
				{
					excelFile.CopyTo(stream);
				}
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

				FileInfo existingFile = new FileInfo(filePath);
				using (var excelPack = new ExcelPackage(existingFile))
				{


					//Lets Deal with first worksheet.(You may iterate here if dealing with multiple sheets)
					var ws = excelPack.Workbook.Worksheets[_configuration.GetValue<string>("ExcelFiles:TimeAttendance")];

					//Get all details as DataTable -because Datatable make life easy :)
					DataTable excelasTable = new DataTable();
					foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
					{
						//Get colummn details
						if (!string.IsNullOrEmpty(firstRowCell.Text))
						{
							string firstColumn = string.Format("Column {0}", firstRowCell.Start.Column);
							excelasTable.Columns.Add(hasHeader ? firstRowCell.Text : firstColumn);
						}
					}
					var startRow = hasHeader ? 2 : 1;
					//Get row details
					for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
					{
						var wsRow = ws.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
						DataRow row = excelasTable.Rows.Add();
						foreach (var cell in wsRow)
						{
							row[cell.Start.Column - 1] = cell.Text;
						}
					}
					var data = excelasTable.Rows.OfType<DataRow>()
			   .Select(row => excelasTable.Columns.OfType<DataColumn>()
				   .ToDictionary(col => col.ColumnName, c => row[c]));


					var generatedTypeObject = JsonConvert.SerializeObject(data,
								Newtonsoft.Json.Formatting.None,
								new JsonSerializerSettings
								{
									NullValueHandling = NullValueHandling.Ignore
								});
					var generatedType = JsonConvert.DeserializeObject<List<TimeAttendance>>(generatedTypeObject);

					
						await importExcelInterface.AddTime(generatedType);

					
					
				}

				return "";
			}
			catch (Exception ex)
			{
				return (ex.Message);
			}


		}

	}
}
