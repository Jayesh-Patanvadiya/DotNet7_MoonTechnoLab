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
		public async Task<IActionResult> PostPayReg(IFormFile excelFile)
		{
			try
			{
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

				FileInfo existingFile = new FileInfo(filePath);

				await StoredPayRegData(existingFile);
				return Ok("Data stored successfully");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}
		[HttpPost("OTReg")]
		public async Task<IActionResult> PostOTRREg(IFormFile excelFile)
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

				FileInfo existingFile = new FileInfo(filePath);
				await StoredOTRegData(existingFile);
				return Ok("Data stored successfully");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}

		[HttpPost("TimeAttendance")]
		public async Task<IActionResult> PostTimeAttendance(IFormFile excelFile)
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

				return Ok("Data stored successfully");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}

		[HttpGet("Payroll")]
		public async Task<IActionResult> GetDataPayroll(string Payroll)
		{
			try
			{
				bool hasHeader = true;
				string path = Path.Combine(this.Environment.WebRootPath, _configuration.GetValue<string>("ExcelFiles:TimeAttendance"));
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string filePath = Path.Combine(this.Environment.WebRootPath, "TimeAttendance\\payreg.xlsx");

				
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

				FileInfo existingFile = new FileInfo(filePath);

				var regPayData = await GetPayRegData(existingFile);

				var otgPayData = await GetOTRegData(existingFile);

				var filterDataRegPayData = regPayData.Where(x => x.PAYROLL == Payroll);

				var filterOtgPayData = otgPayData.Where(x => x.PAYROLL == Payroll);

				// let's convert our object data to Datatable for a simplified logic.
				// Datatable is the easiest way to deal with complex datatypes for easy reading and formatting. 
				DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(filterDataRegPayData), (typeof(DataTable)));
				using (var excelPack = new ExcelPackage(filePath))
				{
					var ws = excelPack.Workbook.Worksheets.Add("PAYREGEXTRA");
					ws.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
					excelPack.Save();
				}
				DataTable tableOTG = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(filterOtgPayData), (typeof(DataTable)));
				using (var excelPack = new ExcelPackage(filePath))
				{
					var ws = excelPack.Workbook.Worksheets.Add("OtgEXTRA");
					ws.Cells.LoadFromDataTable(tableOTG, true, OfficeOpenXml.Table.TableStyles.Light8);
					excelPack.Save();
				}
				return Ok("Data stored successfully");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}

		[HttpGet("OvertimeCalculation")]
		public async Task<IActionResult> OvertimeCalculation(string Payroll)
		{
			try
			{
				bool hasHeader = true;
				string path = Path.Combine(this.Environment.WebRootPath, _configuration.GetValue<string>("ExcelFiles:TimeAttendance"));
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				string filePath = Path.Combine(this.Environment.WebRootPath, "PayReg\\payreg.xlsx");


				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

				FileInfo existingFile = new FileInfo(filePath);

				var regPayData = await GetPayRegData(existingFile);

				//var otgPayData = await GetOTRegData(existingFile);

				var filterDataRegPayData = regPayData.Where(x => x.PAYROLL == Payroll);

				List<OverTimeCal> overTimeCals = new List<OverTimeCal>();

				//get attendance data from the excel sheet
				var attendanceData = await GetAttendaceData(existingFile);
				foreach (var item in filterDataRegPayData)
				{
					//get data from empid and overtime days
					var attend = attendanceData.Where(x => x.EMPID == item.EMPLOYEEID && x.LWOPDAYS != null).FirstOrDefault();
					if (attend != null)
					{
						//Create a method to produce the  Columns
						decimal salary = (Convert.ToDecimal(item.MONTHLYSALARYRATE));
						int days = Convert.ToInt32(attend.LWOPDAYS);
						var calOvertime = ((((salary) * 12) / 261) / 8) * days;
						OverTimeCal Cal = new OverTimeCal
						{
							ATTDEDUCTION = item.ATTDEDUCTION,
							EMPLOYEEID = item.EMPLOYEEID,
							FIRSTNAME = item.FIRSTNAME,
							LASTNAME = item.LASTNAME,
							OVERTIME = calOvertime,
							Id = item.Id
						};
						overTimeCals.Add(Cal);
					}
					
				}
				
				if(overTimeCals.Any())
				{
					// let's convert our object data to Datatable for a simplified logic.
					// Datatable is the easiest way to deal with complex datatypes for easy reading and formatting. 
					DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(overTimeCals), (typeof(DataTable)));
					using (var excelPack = new ExcelPackage(filePath))
					{
						var ws = excelPack.Workbook.Worksheets.Add("PAYREGEXTRA");
						ws.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
						excelPack.Save();
					}
				}


				return Ok("Data stored successfully");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}


		}

		[NonAction]
		public async Task<List<PayReg>> StoredPayRegData(FileInfo existingFile)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			bool hasHeader = true;
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
			   .ToDictionary(col => col.ColumnName, c => row[c]));



				//var serializeData = System.Text.Json.JsonSerializer.Serialize(data);
				var generatedTypeObject = JsonConvert.SerializeObject(data,
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
				return generatedType;
			}


		}
		[NonAction]

		public async Task<List<PayReg>> GetPayRegData(FileInfo existingFile)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			bool hasHeader = true;
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
			   .ToDictionary(col => col.ColumnName, c => row[c]));



				//var serializeData = System.Text.Json.JsonSerializer.Serialize(data);
				var generatedTypeObject = JsonConvert.SerializeObject(data,
						Newtonsoft.Json.Formatting.None,
						new JsonSerializerSettings
						{
							NullValueHandling = NullValueHandling.Ignore
						});
				var generatedType = JsonConvert.DeserializeObject<List<PayReg>>(generatedTypeObject);

				
				return generatedType;
			}


		}
		[NonAction]

		public async Task<List<OTReg>> GetOTRegData(FileInfo existingFile)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			bool hasHeader = true;
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


				return generatedType;
			}


		}
		[NonAction]


		public async Task<List<OTReg>> StoredOTRegData(FileInfo existingFile)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			bool hasHeader = true;
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
				return generatedType;
			}


		}
		[NonAction]

		public async Task<List<TimeAttendance>> GetAttendaceData(FileInfo existingFile)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			bool hasHeader = true;
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


				return generatedType;
			}


		}

	}
}
