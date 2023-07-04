using DotNet7_MoonTechnoLab.Model;
using Npgsql;

namespace DotNet7_MoonTechnoLab.Repository
{
	public interface IImportExcelInterface
	{
		Task Add(PayReg payReg);

		Task Add(OTReg oTReg);
		Task AddTime(List<TimeAttendance> timeAttendance);
	}
}
