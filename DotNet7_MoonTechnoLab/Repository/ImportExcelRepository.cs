using DocumentFormat.OpenXml.Spreadsheet;
using DotNet7_MoonTechnoLab.Migrations;
using DotNet7_MoonTechnoLab.Model;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DotNet7_MoonTechnoLab.Repository
{
	public class ImportExcelRepository : IImportExcelInterface
	{
		private readonly DBContext _context;

		public ImportExcelRepository(DBContext context)
		{
			_context = context;
		}


		public async Task Add(PayReg payReg)
		{
			try
			{
				await _context.PayReg.AddAsync(payReg);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}



		}

		public async Task Add(OTReg oTReg)
		{
			try
			{
				await _context.OTReg.AddAsync(oTReg);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}


		}
		public async Task AddTime(List<TimeAttendance> timeAttendance)
		{
			try
			{
				var data = timeAttendance.Where(x => x.EMPID != "");
				var bulkConfig = new BulkConfig()
				{
					SetOutputIdentity = true,
					PreserveInsertOrder = true
				};
				await _context.BulkInsertOrUpdateAsync(timeAttendance, bulkConfig);
			}
			catch (Exception ex)
			{
				throw ex;
			}




		}


	}

}